using System.Data;
using FitZoneGym.Data;

namespace FitZoneGym.Services
{
    public class RenewalPreview
    {
        public DateTime PreviousExpiration, NewStart, NewExpiration;
        public decimal Fee;
        public bool ExtendsFromPrevious;
    }

    /// <summary>Registration, renewal, freeze, and reactivation rules.</summary>
    public static class MembershipService
    {
        // ---- lookups ------------------------------------------------------------------------
        public static Membership Latest(DbSession s, string memberId)
        {
            var r = s.Row("SELECT * FROM Memberships WHERE MemberID = @p0 AND Status <> 'Cancelled' ORDER BY ExpirationDate DESC, MembershipID DESC LIMIT 1", memberId);
            return r == null ? null : FromRow(r);
        }

        public static Membership Latest(string memberId) { using var s = new DbSession(); return Latest(s, memberId); }

        public static Membership FromRow(DataRow r) => new Membership
        {
            MembershipId = Db.I(r["MembershipID"]),
            MemberId = Db.S(r["MemberID"]),
            PlanId = Db.I(r["PlanID"]),
            StartDate = Db.ToDate(r["StartDate"]),
            ExpirationDate = Db.ToDate(r["ExpirationDate"]),
            StoredStatus = Db.S(r["Status"]),
        };

        private static void RequireActiveMember(DbSession s, string memberId)
        {
            var m = s.Row("SELECT AccountStatus FROM Members WHERE MemberID = @p0", memberId);
            if (m == null) throw new ValidationException("Member " + memberId + " was not found.");
            if (Db.S(m["AccountStatus"]) != "Active") throw new ValidationException("This member's account is inactive.");
        }

        private static MembershipPlan RequireActivePlan(DbSession s, int planId)
        {
            var r = s.Row("SELECT * FROM MembershipPlans WHERE PlanID = @p0", planId);
            if (r == null) throw new ValidationException("Select a membership plan.");
            var p = PlanService.FromRow(r);
            if (!p.IsActive) throw new ValidationException("Only active plans can be assigned to memberships.");
            return p;
        }

        // ---- registration -------------------------------------------------------------------
        /// <summary>
        /// Creates the first membership for a member, its invoice, and (optionally) an initial payment as ONE transaction.
        /// Returns the invoice number.
        /// </summary>
        public static string Register(string memberId, int planId, DateTime startDate, decimal discountPercent,
                                      decimal initialPayment, string method, string reference)
        {
            Session.Require(Perm.RegisterMembers);
            if (initialPayment > 0m) Session.Require(Perm.RecordPayments);
            BillingService.ValidateDiscount(discountPercent);

            using var s = new DbSession(true);
            RequireActiveMember(s, memberId);
            var plan = RequireActivePlan(s, planId);

            if (s.Scalar("SELECT 1 FROM Memberships WHERE MemberID = @p0 AND Status <> 'Cancelled'", memberId) != null)
                throw new ValidationException("This member already has a membership. Use Renew Membership instead.");
            if (startDate.Date < DateTime.Today.AddDays(-30))
                throw new ValidationException("Start date cannot be more than 30 days in the past.");

            DateTime exp = Membership.CalcExpiration(startDate, plan.DurationMonths);
            long msId = s.Insert("INSERT INTO Memberships(MemberID, PlanID, StartDate, ExpirationDate, Status) VALUES (@p0,@p1,@p2,@p3,'Active')",
                memberId, planId, startDate.Date, exp);

            decimal discount = BillingService.DiscountAmount(plan.Fee, discountPercent);
            int invId = BillingService.CreateInvoice(s, memberId, (int)msId, "Registration", startDate.Date, exp,
                plan.PlanName + " membership (" + startDate.ToString("MMM d, yyyy") + " - " + exp.ToString("MMM d, yyyy") + ")",
                plan.Fee, discount, 0m);

            if (initialPayment > 0m)
                PaymentService.ApplyPayment(s, new Payment { InvoiceId = invId, Amount = initialPayment, Method = method, ReferenceNumber = reference });

            string no = Db.S(s.Scalar("SELECT InvoiceNo FROM Invoices WHERE InvoiceID = @p0", invId));
            Audit.Log(s, "Membership registered", memberId + " " + plan.PlanName + " until " + exp.ToString("yyyy-MM-dd") + " (" + no + ")");
            s.Commit();
            return no;
        }

        // ---- renewal ------------------------------------------------------------------------
        /// <summary>
        /// Gym policy: if the renewal date is on or before (previous expiration + grace period) the new term continues from the
        /// day after the previous expiration (no lost days). Otherwise the new term starts on the renewal date.
        /// </summary>
        public static RenewalPreview PreviewRenewal(string memberId, int planId, DateTime renewalDate)
        {
            using var s = new DbSession();
            var cur = Latest(s, memberId);
            if (cur == null) throw new ValidationException("This member has no membership to renew. Use New Registration.");
            var plan = RequireActivePlan(s, planId);

            int grace = Settings.GetInt("GracePeriodDays", 3);
            bool continuous = renewalDate.Date <= cur.ExpirationDate.Date.AddDays(grace);
            DateTime start = continuous ? cur.ExpirationDate.Date.AddDays(1) : renewalDate.Date;
            return new RenewalPreview
            {
                PreviousExpiration = cur.ExpirationDate,
                NewStart = start,
                NewExpiration = Membership.CalcExpiration(start, plan.DurationMonths),
                Fee = plan.Fee,
                ExtendsFromPrevious = continuous,
            };
        }

        public static string Renew(string memberId, int planId, DateTime renewalDate, decimal discountPercent,
                                  decimal initialPayment, string method, string reference)
        {
            Session.Require(Perm.RegisterMembers);
            if (initialPayment > 0m) Session.Require(Perm.RecordPayments);
            BillingService.ValidateDiscount(discountPercent);
            if (renewalDate.Date > DateTime.Today.AddDays(60)) throw new ValidationException("Renewal date is too far in the future.");

            using var s = new DbSession(true);
            RequireActiveMember(s, memberId);
            var plan = RequireActivePlan(s, planId);
            var cur = Latest(s, memberId);
            if (cur == null) throw new ValidationException("This member has no membership to renew. Use New Registration.");
            if (cur.StoredStatus == "Frozen") throw new ValidationException("This membership is frozen. Reactivate it before renewing.");

            int grace = Settings.GetInt("GracePeriodDays", 3);
            bool continuous = renewalDate.Date <= cur.ExpirationDate.Date.AddDays(grace);
            DateTime start = continuous ? cur.ExpirationDate.Date.AddDays(1) : renewalDate.Date;
            DateTime newExp = Membership.CalcExpiration(start, plan.DurationMonths);

            // One continuous membership row is extended; if there was a gap the row restarts on the new start date.
            s.Exec("UPDATE Memberships SET PlanID=@p1, ExpirationDate=@p2, StartDate=@p3 WHERE MembershipID=@p0",
                cur.MembershipId, planId, newExp, continuous ? cur.StartDate : start);

            decimal discount = BillingService.DiscountAmount(plan.Fee, discountPercent);
            int invId = BillingService.CreateInvoice(s, memberId, cur.MembershipId, "Renewal", start, newExp,
                plan.PlanName + " renewal (" + start.ToString("MMM d, yyyy") + " - " + newExp.ToString("MMM d, yyyy") + ")",
                plan.Fee, discount, 0m);

            s.Exec(@"INSERT INTO Renewals(MembershipID, TransactionDate, PlanID, PreviousExpiration, NewExpiration, InvoiceID, ProcessedBy)
                     VALUES (@p0,@p1,@p2,@p3,@p4,@p5,@p6)",
                cur.MembershipId, DateTime.Today, planId, cur.ExpirationDate, newExp, invId, Session.UserId == 0 ? (object)null : Session.UserId);

            if (initialPayment > 0m)
                PaymentService.ApplyPayment(s, new Payment { InvoiceId = invId, Amount = initialPayment, Method = method, ReferenceNumber = reference });

            string no = Db.S(s.Scalar("SELECT InvoiceNo FROM Invoices WHERE InvoiceID = @p0", invId));
            Audit.Log(s, "Membership renewed", memberId + " " + plan.PlanName + " until " + newExp.ToString("yyyy-MM-dd") + " (" + no + ")");
            s.Commit();
            return no;
        }

        public static DataTable RenewalHistory(string memberId) => DbSession.Q(@"
SELECT r.TransactionDate, p.PlanName, r.PreviousExpiration, r.NewExpiration,
       i.TotalDue AS Charged, IFNULL((SELECT SUM(Amount) FROM Payments WHERE InvoiceID = i.InvoiceID),0) AS Paid, i.Status
FROM Renewals r JOIN Memberships ms ON ms.MembershipID = r.MembershipID
JOIN MembershipPlans p ON p.PlanID = r.PlanID LEFT JOIN Invoices i ON i.InvoiceID = r.InvoiceID
WHERE ms.MemberID = @p0 ORDER BY r.RenewalID DESC", memberId);

        // ---- freeze -------------------------------------------------------------------------
        public static int RequestFreeze(int membershipId, DateTime start, DateTime end, string reason)
        {
            Session.Require(Perm.SubmitFreeze);
            if (string.IsNullOrWhiteSpace(reason)) throw new ValidationException("A reason for the freeze is required.");
            if (end.Date < start.Date) throw new ValidationException("End date cannot be earlier than the start date.");
            if (start.Date < DateTime.Today) throw new ValidationException("A freeze cannot start in the past.");

            int days = (end.Date - start.Date).Days + 1;
            int min = Settings.GetInt("MinFreezeDays", 1), max = Settings.GetInt("MaxFreezeDays", 30);
            if (days < min) throw new ValidationException("A freeze must be at least " + min + " day(s).");
            if (days > max) throw new ValidationException("A freeze cannot exceed " + max + " days (requested " + days + ").");

            using var s = new DbSession(true);
            var r = s.Row("SELECT * FROM Memberships WHERE MembershipID = @p0", membershipId);
            if (r == null) throw new ValidationException("Membership not found.");
            var ms = FromRow(r);
            if (ms.State != MembershipState.Active)
                throw new ValidationException("Only an active membership can be frozen (current status: " + ms.State + ").");
            if (start.Date > ms.ExpirationDate.Date) throw new ValidationException("The freeze must start before the membership expires.");

            if (s.Scalar(@"SELECT 1 FROM FreezeRequests WHERE MembershipID = @p0 AND Status IN ('Pending','Approved')
                           AND StartDate <= @p2 AND EndDate >= @p1", membershipId, start.Date, end.Date) != null)
                throw new ValidationException("This freeze overlaps an existing pending or approved freeze for the membership.");

            long id = s.Insert(@"INSERT INTO FreezeRequests(MembershipID, RequestDate, Reason, StartDate, EndDate, Status, RequestedBy)
                                 VALUES (@p0,@p1,@p2,@p3,@p4,'Pending',@p5)",
                membershipId, DateTime.Today, reason.Trim(), start.Date, end.Date, Session.UserId == 0 ? (object)null : Session.UserId);
            Audit.Log(s, "Freeze requested", "Membership " + membershipId + " " + start.ToString("yyyy-MM-dd") + " to " + end.ToString("yyyy-MM-dd"));
            s.Commit();
            return (int)id;
        }

        /// <summary>
        /// Approval takes effect immediately: the membership becomes Frozen and, when the policy grants a full extension,
        /// the expiration date moves forward by the requested days (an early reactivation gives unused days back).
        /// </summary>
        public static void ApproveFreeze(int freezeId, string notes)
        {
            Session.Require(Perm.ApproveFreeze);
            using var s = new DbSession(true);
            var f = s.Row("SELECT * FROM FreezeRequests WHERE FreezeID = @p0", freezeId);
            if (f == null) throw new ValidationException("Freeze request not found.");
            if (Db.S(f["Status"]) != "Pending") throw new ValidationException("Only pending requests can be approved.");

            int msId = Db.I(f["MembershipID"]);
            var ms = FromRow(s.Row("SELECT * FROM Memberships WHERE MembershipID = @p0", msId));
            if (ms.State != MembershipState.Active)
                throw new ValidationException("The membership is no longer active (status: " + ms.State + "), so the freeze cannot be approved.");

            int days = (Db.ToDate(f["EndDate"]) - Db.ToDate(f["StartDate"])).Days + 1;
            int ext = Settings.GetBool("FullFreezeExtension", true) ? days : 0;

            s.Exec("UPDATE FreezeRequests SET Status='Approved', ExtensionDays=@p1, ApprovedBy=@p2, DecisionDate=@p3, Notes=@p4 WHERE FreezeID=@p0",
                freezeId, ext, Session.UserId, DateTime.Today, string.IsNullOrWhiteSpace(notes) ? null : notes.Trim());
            s.Exec("UPDATE Memberships SET Status='Frozen', ExpirationDate=@p1 WHERE MembershipID=@p0", msId, ms.ExpirationDate.AddDays(ext));
            Audit.Log(s, "Freeze approved", "FreezeID " + freezeId + ", +" + ext + " day(s) extension");
            s.Commit();
        }

        public static void RejectFreeze(int freezeId, string notes)
        {
            Session.Require(Perm.ApproveFreeze);
            if (string.IsNullOrWhiteSpace(notes)) throw new ValidationException("Enter a reason for rejecting the request.");
            using var s = new DbSession(true);
            var f = s.Row("SELECT Status FROM FreezeRequests WHERE FreezeID = @p0", freezeId);
            if (f == null) throw new ValidationException("Freeze request not found.");
            if (Db.S(f["Status"]) != "Pending") throw new ValidationException("Only pending requests can be rejected.");
            s.Exec("UPDATE FreezeRequests SET Status='Rejected', ApprovedBy=@p1, DecisionDate=@p2, Notes=@p3 WHERE FreezeID=@p0",
                freezeId, Session.UserId, DateTime.Today, notes.Trim());
            Audit.Log(s, "Freeze rejected", "FreezeID " + freezeId);
            s.Commit(); // membership dates are intentionally untouched
        }

        public static DataTable FreezeList(string status)
        {
            if (!(Session.Current.Can(Perm.ApproveFreeze) || Session.Current.Can(Perm.SubmitFreeze)))
                throw new PermissionException("You do not have permission to view freeze requests.");
            return DbSession.Q(@"
SELECT f.FreezeID, m.MemberID, m.FullName, f.RequestDate, f.StartDate, f.EndDate, f.Reason, f.Status
FROM FreezeRequests f JOIN Memberships ms ON ms.MembershipID = f.MembershipID JOIN Members m ON m.MemberID = ms.MemberID
WHERE f.Status = @p0 ORDER BY f.FreezeID DESC", status);
        }

        // ---- reactivation -------------------------------------------------------------------
        public class ReactivationInfo
        {
            public Membership Membership;
            public int FreezeId;
            public DateTime FreezeStart, FreezeEnd;
            public int ExtensionDays;
            public decimal SuggestedFee;
        }

        /// <summary>Returns the frozen membership and its approved freeze, or throws if the member is not eligible.</summary>
        public static ReactivationInfo FindReactivatable(string memberId)
        {
            using var s = new DbSession();
            var ms = Latest(s, memberId);
            if (ms == null) throw new ValidationException("This member has no membership.");
            if (ms.StoredStatus != "Frozen") throw new ValidationException("Only frozen memberships can be reactivated (status: " + ms.State + ").");
            var f = s.Row("SELECT * FROM FreezeRequests WHERE MembershipID = @p0 AND Status = 'Approved' ORDER BY FreezeID DESC LIMIT 1", ms.MembershipId);
            if (f == null) throw new ValidationException("No approved freeze was found for this membership.");
            return new ReactivationInfo
            {
                Membership = ms,
                FreezeId = Db.I(f["FreezeID"]),
                FreezeStart = Db.ToDate(f["StartDate"]),
                FreezeEnd = Db.ToDate(f["EndDate"]),
                ExtensionDays = Db.I(f["ExtensionDays"]),
                SuggestedFee = Settings.GetDecimal("ReactivationFee", 0m),
            };
        }

        /// <summary>New expiration = current expiration - unused extension days (days granted but not actually frozen).</summary>
        public static DateTime NewExpirationOnReactivation(ReactivationInfo info, DateTime reactivationDate)
        {
            int used = Math.Max(0, Math.Min(info.ExtensionDays, (reactivationDate.Date - info.FreezeStart.Date).Days));
            return info.Membership.ExpirationDate.AddDays(-(info.ExtensionDays - used));
        }

        public static void Reactivate(string memberId, DateTime reactivationDate, decimal fee, string notes)
        {
            Session.Require(Perm.Reactivate);
            if (fee < 0m) throw new ValidationException("Reactivation fee cannot be negative.");
            if (reactivationDate.Date > DateTime.Today) throw new ValidationException("Reactivation date cannot be in the future.");

            using var s = new DbSession(true);
            RequireActiveMember(s, memberId);
            var ms = Latest(s, memberId);
            if (ms == null || ms.StoredStatus != "Frozen") throw new ValidationException("Only frozen memberships can be reactivated.");
            var f = s.Row("SELECT * FROM FreezeRequests WHERE MembershipID = @p0 AND Status = 'Approved' ORDER BY FreezeID DESC LIMIT 1", ms.MembershipId);
            if (f == null) throw new ValidationException("No approved freeze was found for this membership.");

            var info = new ReactivationInfo
            {
                Membership = ms, FreezeId = Db.I(f["FreezeID"]), FreezeStart = Db.ToDate(f["StartDate"]),
                FreezeEnd = Db.ToDate(f["EndDate"]), ExtensionDays = Db.I(f["ExtensionDays"]),
            };
            DateTime newExp = NewExpirationOnReactivation(info, reactivationDate);

            s.Exec("UPDATE Memberships SET Status='Active', ExpirationDate=@p1 WHERE MembershipID=@p0", ms.MembershipId, newExp);
            s.Exec("UPDATE FreezeRequests SET Status='Completed' WHERE FreezeID=@p0", info.FreezeId);

            object invoiceId = null;
            if (fee > 0m)
                invoiceId = BillingService.CreateInvoice(s, memberId, ms.MembershipId, "Reactivation", reactivationDate.Date, null,
                    "Membership reactivation fee", fee, 0m, 0m);

            s.Exec(@"INSERT INTO Reactivations(MembershipID, FreezeID, ReactivationDate, Fee, NewExpiration, ProcessedBy, InvoiceID, Notes)
                     VALUES (@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7)",
                ms.MembershipId, info.FreezeId, reactivationDate.Date, fee, newExp, Session.UserId == 0 ? (object)null : Session.UserId,
                invoiceId, string.IsNullOrWhiteSpace(notes) ? null : notes.Trim());
            Audit.Log(s, "Membership reactivated", memberId + " new expiration " + newExp.ToString("yyyy-MM-dd"));
            s.Commit();
        }
    }
}
