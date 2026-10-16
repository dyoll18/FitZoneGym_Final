using System.Data;
using System.Globalization;
using FitZoneGym.Data;

namespace FitZoneGym.Services
{
    /// <summary>Abstraction: forms call CalculateFee, the rounding/day-count rules stay hidden here.</summary>
    public abstract class BillingPolicy
    {
        public abstract decimal DailyRate(decimal monthlyFee);
        public abstract decimal CalculateFee(decimal monthlyFee, int chargeableDays);
    }

    /// <summary>
    /// Polymorphic policy: fixed 30-day month.  Daily rate = monthly fee / 30, rounded to 2 dp (half away from zero);
    /// prorated fee = rounded daily rate x chargeable days. Chargeable days are counted inclusively.
    /// </summary>
    public class FixedThirtyDayPolicy : BillingPolicy
    {
        public const int DaysInPeriod = 30;
        public override decimal DailyRate(decimal monthlyFee) => Math.Round(monthlyFee / DaysInPeriod, 2, MidpointRounding.AwayFromZero);
        public override decimal CalculateFee(decimal monthlyFee, int chargeableDays) =>
            Math.Round(DailyRate(monthlyFee) * chargeableDays, 2, MidpointRounding.AwayFromZero);
    }

    public class ProratedResult
    {
        public decimal MonthlyFee, DailyRate, ProratedAmount, Discount, AdditionalFees, Total;
        public int ChargeableDays;
    }

    public static class BillingService
    {
        public static readonly BillingPolicy Policy = new FixedThirtyDayPolicy();

        public static int ChargeableDays(DateTime start, DateTime end)
        {
            if (end.Date < start.Date) throw new ValidationException("End date cannot be earlier than the start date.");
            return (end.Date - start.Date).Days + 1;
        }

        /// <summary>Checks the discount percentage and whether the current user may grant it.</summary>
        public static void ValidateDiscount(decimal percent)
        {
            if (percent < 0m || percent > 100m) throw new ValidationException("Discount must be between 0% and 100%.");
            decimal limit = Settings.GetDecimal("MaxStaffDiscountPercent", 20m);
            if (percent > limit && !(Session.Current?.IsAdmin ?? false))
                throw new PermissionException("Discounts above " + limit.ToString("0.##") + "% must be authorized by an administrator.");
        }

        public static decimal DiscountAmount(decimal baseCharge, decimal percent) =>
            Math.Round(baseCharge * percent / 100m, 2, MidpointRounding.AwayFromZero);

        public static ProratedResult Calculate(decimal monthlyFee, DateTime start, DateTime end, decimal discountPercent, decimal additionalFees)
        {
            if (monthlyFee <= 0m) throw new ValidationException("Monthly fee must be greater than zero.");
            if (additionalFees < 0m) throw new ValidationException("Additional fees cannot be negative.");
            ValidateDiscount(discountPercent);
            int days = ChargeableDays(start, end);

            var r = new ProratedResult
            {
                MonthlyFee = monthlyFee,
                DailyRate = Policy.DailyRate(monthlyFee),
                ChargeableDays = days,
                ProratedAmount = Policy.CalculateFee(monthlyFee, days),
                AdditionalFees = additionalFees,
            };
            r.Discount = DiscountAmount(r.ProratedAmount, discountPercent);
            r.Total = new Invoice { BaseCharge = r.ProratedAmount, Discount = r.Discount, AdditionalFees = additionalFees }.TotalDue;
            return r;
        }

        // ---- invoices -----------------------------------------------------------------------
        public static string NextInvoiceNo(DbSession s, DateTime date)
        {
            string prefix = "INV-" + date.Year + "-";
            object max = s.Scalar("SELECT MAX(CAST(SUBSTR(InvoiceNo, @p1) AS INTEGER)) FROM Invoices WHERE InvoiceNo LIKE @p0",
                prefix + "%", prefix.Length + 1);
            return prefix + ((max == null ? 0 : Convert.ToInt32(max)) + 1).ToString("000");
        }

        /// <summary>Creates an invoice and its line items inside the caller's transaction.</summary>
        public static int CreateInvoice(DbSession s, string memberId, int? membershipId, string kind, DateTime? billStart, DateTime? billEnd,
                                        string description, decimal baseCharge, decimal discount, decimal additionalFees)
        {
            if (baseCharge < 0m || discount < 0m || additionalFees < 0m) throw new ValidationException("Invoice amounts cannot be negative.");
            if (discount > baseCharge) throw new ValidationException("Discount cannot exceed the base charge.");
            var inv = new Invoice { BaseCharge = baseCharge, Discount = discount, AdditionalFees = additionalFees };
            string no = NextInvoiceNo(s, DateTime.Today);

            long id = s.Insert(@"INSERT INTO Invoices(InvoiceNo, MembershipID, MemberID, Kind, InvoiceDate, BillingStart, BillingEnd,
                                   BaseCharge, Discount, AdditionalFees, TotalDue, Status, CreatedBy)
                                 VALUES (@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,'Unpaid',@p11)",
                no, membershipId, memberId, kind, DateTime.Today, billStart, billEnd,
                baseCharge, discount, additionalFees, inv.TotalDue, Session.UserId == 0 ? (object)null : Session.UserId);

            s.Exec("INSERT INTO InvoiceItems(InvoiceID, Description, Quantity, UnitPrice, Discount) VALUES (@p0,@p1,1,@p2,@p3)",
                id, description, baseCharge, discount);
            if (additionalFees > 0m)
                s.Exec("INSERT INTO InvoiceItems(InvoiceID, Description, Quantity, UnitPrice, Discount) VALUES (@p0,'Additional fees',1,@p1,0)",
                    id, additionalFees);

            if (inv.TotalDue == 0m) s.Exec("UPDATE Invoices SET Status = 'Paid' WHERE InvoiceID = @p0", id);
            return (int)id;
        }

        /// <summary>Saves a prorated charge as an invoice against the member's current membership.</summary>
        public static string CreateProratedInvoice(string memberId, decimal monthlyFee, DateTime start, DateTime end,
                                                   decimal discountPercent, decimal additionalFees, string planName)
        {
            Session.Require(Perm.RecordPayments);
            var calc = Calculate(monthlyFee, start, end, discountPercent, additionalFees);
            if (calc.Total <= 0m) throw new ValidationException("The calculated total must be greater than zero to create an invoice.");

            using var s = new DbSession(true);
            var ms = s.Row("SELECT MembershipID FROM Memberships WHERE MemberID = @p0 AND Status <> 'Cancelled' ORDER BY ExpirationDate DESC LIMIT 1", memberId);
            if (ms == null) throw new ValidationException("This member has no membership to bill. Register a membership first.");

            string desc = string.Format(CultureInfo.InvariantCulture, "Prorated {0} fee: {1} day(s) x {2:N2}/day",
                planName, calc.ChargeableDays, calc.DailyRate);
            int id = CreateInvoice(s, memberId, Db.I(ms["MembershipID"]), "Prorated", start, end, desc, calc.ProratedAmount, calc.Discount, calc.AdditionalFees);
            string no = Db.S(s.Scalar("SELECT InvoiceNo FROM Invoices WHERE InvoiceID = @p0", id));
            Audit.Log(s, "Prorated invoice created", no + " for " + memberId + " total " + calc.Total.ToString("N2"));
            s.Commit();
            return no;
        }

        public static DataTable ListInvoices(string search = "")
        {
            Session.Require(Perm.ViewInvoices);
            return DbSession.Q(@"
SELECT i.InvoiceID, i.InvoiceNo, i.MemberID, m.FullName, i.Kind, i.InvoiceDate, i.TotalDue,
       IFNULL((SELECT SUM(Amount) FROM Payments WHERE InvoiceID = i.InvoiceID),0) AS Paid, i.Status
FROM Invoices i JOIN Members m ON m.MemberID = i.MemberID
WHERE (@p0 = '' OR i.InvoiceNo LIKE '%' || @p0 || '%' OR i.MemberID LIKE '%' || @p0 || '%' OR m.FullName LIKE '%' || @p0 || '%')
ORDER BY i.InvoiceID DESC", (search ?? "").Trim());
        }

        public class InvoiceDetail
        {
            public DataRow Header;
            public DataTable Items, Payments;
            public decimal Paid, Balance, Total;
            public string Status() => Db.S(Header["Status"]);
        }

        public static InvoiceDetail GetDetail(int invoiceId)
        {
            Session.Require(Perm.ViewInvoices);
            using var s = new DbSession();
            var h = s.Row(@"SELECT i.*, m.FullName, m.ContactNumber FROM Invoices i JOIN Members m ON m.MemberID = i.MemberID WHERE i.InvoiceID = @p0", invoiceId);
            if (h == null) throw new ValidationException("Invoice not found.");
            var d = new InvoiceDetail
            {
                Header = h,
                Items = s.Query("SELECT Description, Quantity, UnitPrice, Discount FROM InvoiceItems WHERE InvoiceID = @p0 ORDER BY ItemID", invoiceId),
                Payments = s.Query("SELECT PaymentDate, Method, ReferenceNumber, Amount FROM Payments WHERE InvoiceID = @p0 ORDER BY PaymentID", invoiceId),
            };
            d.Total = Db.ToDec(h["TotalDue"]);
            d.Paid = PaymentService.PaidAmount(s, invoiceId);
            d.Balance = d.Status() == "Voided" ? 0m : d.Total - d.Paid;
            return d;
        }

        public static void Void(int invoiceId, string reason)
        {
            Session.Require(Perm.ManageSettings); // administrators only
            if (string.IsNullOrWhiteSpace(reason)) throw new ValidationException("A reason is required to void an invoice.");
            using var s = new DbSession(true);
            var inv = s.Row("SELECT InvoiceNo, Status FROM Invoices WHERE InvoiceID = @p0", invoiceId);
            if (inv == null) throw new ValidationException("Invoice not found.");
            if (Db.S(inv["Status"]) == "Voided") throw new ValidationException("Invoice is already voided.");
            if (Convert.ToInt32(s.Scalar("SELECT COUNT(*) FROM Payments WHERE InvoiceID = @p0", invoiceId)) > 0)
                throw new ValidationException("An invoice with recorded payments cannot be voided. Payments must be reversed through an authorized adjustment first.");
            s.Exec("UPDATE Invoices SET Status = 'Voided', VoidReason = @p1 WHERE InvoiceID = @p0", invoiceId, reason.Trim());
            Audit.Log(s, "Invoice voided", Db.S(inv["InvoiceNo"]) + ": " + reason.Trim());
            s.Commit();
        }
    }

    public static class PaymentService
    {
        public static readonly string[] Methods = { "Cash", "GCash", "Card", "Bank Transfer", "Other" };

        public static decimal PaidAmount(DbSession s, int invoiceId) => Db.ToDec(s.Scalar("SELECT IFNULL(SUM(Amount),0) FROM Payments WHERE InvoiceID = @p0", invoiceId));

        /// <summary>Open invoices (not paid, not voided) for a member, with current balance.</summary>
        public static DataTable OpenInvoices(string memberId)
        {
            Session.Require(Perm.RecordPayments);
            return DbSession.Q(@"
SELECT i.InvoiceID, i.InvoiceNo, i.InvoiceDate, i.TotalDue, i.Status,
       IFNULL((SELECT SUM(Amount) FROM Payments WHERE InvoiceID = i.InvoiceID),0) AS Paid
FROM Invoices i WHERE i.MemberID = @p0 AND i.Status IN ('Unpaid','Partially Paid') ORDER BY i.InvoiceID", memberId);
        }

        public static DataTable History(int invoiceId) =>
            DbSession.Q("SELECT PaymentID, PaymentDate, Amount, Method, ReferenceNumber FROM Payments WHERE InvoiceID = @p0 ORDER BY PaymentID", invoiceId);

        public static void Validate(Payment p, decimal balance)
        {
            if (p.Amount <= 0m) throw new ValidationException("Payment amount must be greater than zero.");
            if (decimal.Round(p.Amount, 2) != p.Amount) throw new ValidationException("Payment amount can have at most 2 decimal places.");
            if (p.Amount > balance)
                throw new ValidationException("Payment (" + p.Amount.ToString("N2") + ") exceeds the remaining balance (" + balance.ToString("N2") + ").");
            if (p.PaymentDate.Date > DateTime.Today) throw new ValidationException("Payment date cannot be in the future.");
            if (string.IsNullOrWhiteSpace(p.Method)) throw new ValidationException("Select a payment method.");
            if (p.Method != "Cash" && Settings.GetBool("RequireReferenceForNonCash", true) && string.IsNullOrWhiteSpace(p.ReferenceNumber))
                throw new ValidationException("A reference number is required for " + p.Method + " payments.");
        }

        /// <summary>Records one payment as its own transaction row and recalculates the invoice status. Returns the new balance.</summary>
        public static decimal Record(Payment p)
        {
            Session.Require(Perm.RecordPayments);
            using var s = new DbSession(true);
            decimal balance = ApplyPayment(s, p);
            s.Commit();
            return balance;
        }

        /// <summary>Same as Record but joins the caller's transaction (used by registration with an initial payment).</summary>
        public static decimal ApplyPayment(DbSession s, Payment p)
        {
            var inv = s.Row("SELECT InvoiceNo, TotalDue, Status FROM Invoices WHERE InvoiceID = @p0", p.InvoiceId);
            if (inv == null) throw new ValidationException("Invoice not found.");
            string status = Db.S(inv["Status"]);
            if (status == "Voided") throw new ValidationException("This invoice has been voided.");
            if (status == "Paid") throw new ValidationException("This invoice is already fully paid.");

            decimal total = Db.ToDec(inv["TotalDue"]);
            decimal paid = PaidAmount(s, p.InvoiceId);
            decimal balance = new Invoice { BaseCharge = total }.BalanceAfter(paid);
            Validate(p, balance);

            s.Exec("INSERT INTO Payments(InvoiceID, Amount, PaymentDate, Method, ReferenceNumber, ReceivedBy) VALUES (@p0,@p1,@p2,@p3,@p4,@p5)",
                p.InvoiceId, p.Amount, p.PaymentDate, p.Method,
                string.IsNullOrWhiteSpace(p.ReferenceNumber) ? null : p.ReferenceNumber.Trim(),
                Session.UserId == 0 ? (object)null : Session.UserId);

            decimal newPaid = paid + p.Amount;
            s.Exec("UPDATE Invoices SET Status = @p1 WHERE InvoiceID = @p0", p.InvoiceId, Invoice.StatusFor(total, newPaid));
            Audit.Log(s, "Payment recorded", Db.S(inv["InvoiceNo"]) + " amount " + p.Amount.ToString("N2") + " via " + p.Method);
            return new Invoice { BaseCharge = total }.BalanceAfter(newPaid);
        }
    }
}
