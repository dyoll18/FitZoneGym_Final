using System.Data;
using FitZoneGym.Data;

namespace FitZoneGym.Services
{
    public class ReportResult
    {
        public DataTable Data;
        public string Summary;
    }

    /// <summary>
    /// Report definitions.  Revenue is defined as payments RECEIVED in the period (cash basis);
    /// invoices that are unpaid are never counted as money received.
    /// </summary>
    public static class ReportService
    {
        public static readonly string[] Types =
        {
            "Revenue Report", "Payment Report", "Membership Report", "Renewal Report",
            "Freeze Report", "Unpaid Balances", "Reactivation Report", "Prorated Billing Report",
        };

        public static ReportResult Generate(string type, DateTime from, DateTime to)
        {
            Session.Require(Perm.ViewReports);
            if (to.Date < from.Date) throw new ValidationException("The report end date is earlier than the start date. Please correct the date range.");

            string f = Db.D(from), t = Db.D(to);
            DataTable d; string summary;
            switch (type)
            {
                case "Revenue Report":
                    d = DbSession.Q(@"
SELECT p.PaymentDate AS [Date], COUNT(*) AS Payments, SUM(p.Amount) AS Amount
FROM Payments p JOIN Invoices i ON i.InvoiceID = p.InvoiceID
WHERE p.PaymentDate BETWEEN @p0 AND @p1 AND i.Status <> 'Voided'
GROUP BY p.PaymentDate ORDER BY p.PaymentDate", f, t);
                    summary = "Revenue received: " + Money(Sum(d, "Amount")) + "  |  Payments: " + SumInt(d, "Payments") +
                              "  |  Invoiced in period: " + Money(Db.ToDec(DbSession.V("SELECT IFNULL(SUM(TotalDue),0) FROM Invoices WHERE Status <> 'Voided' AND InvoiceDate BETWEEN @p0 AND @p1", f, t)));
                    break;

                case "Payment Report":
                    d = DbSession.Q(@"
SELECT p.PaymentDate AS [Date], i.InvoiceNo AS Invoice, m.FullName AS Member, p.Method, p.ReferenceNumber AS Reference, p.Amount
FROM Payments p JOIN Invoices i ON i.InvoiceID = p.InvoiceID JOIN Members m ON m.MemberID = i.MemberID
WHERE p.PaymentDate BETWEEN @p0 AND @p1 ORDER BY p.PaymentDate, p.PaymentID", f, t);
                    summary = "Payments: " + d.Rows.Count + "  |  Total received: " + Money(Sum(d, "Amount"));
                    break;

                case "Membership Report":
                    d = DbSession.Q(@"
SELECT m.MemberID AS [Member ID], m.FullName AS Member, p.PlanName AS [Plan], ms.StartDate AS [Start], ms.ExpirationDate AS Expiration, ms.Status AS Stored
FROM Memberships ms JOIN Members m ON m.MemberID = ms.MemberID JOIN MembershipPlans p ON p.PlanID = ms.PlanID
WHERE ms.StartDate <= @p1 AND ms.ExpirationDate >= @p0 ORDER BY m.MemberID", f, t);
                    d.Columns.Add("Status", typeof(string));
                    foreach (DataRow r in d.Rows)
                        r["Status"] = Membership.ComputeState(Db.S(r["Stored"]), Db.ToDate(r["Start"]), Db.ToDate(r["Expiration"])).ToString();
                    d.Columns.Remove("Stored");
                    summary = "Memberships overlapping the period: " + d.Rows.Count;
                    break;

                case "Renewal Report":
                    d = DbSession.Q(@"
SELECT r.TransactionDate AS [Date], m.FullName AS Member, p.PlanName AS [Plan], r.PreviousExpiration AS [Previous Expiry],
       r.NewExpiration AS [New Expiry], i.TotalDue AS Charged,
       IFNULL((SELECT SUM(Amount) FROM Payments WHERE InvoiceID = i.InvoiceID),0) AS Paid, i.Status
FROM Renewals r JOIN Memberships ms ON ms.MembershipID = r.MembershipID JOIN Members m ON m.MemberID = ms.MemberID
JOIN MembershipPlans p ON p.PlanID = r.PlanID LEFT JOIN Invoices i ON i.InvoiceID = r.InvoiceID
WHERE r.TransactionDate BETWEEN @p0 AND @p1 ORDER BY r.TransactionDate", f, t);
                    summary = "Renewals: " + d.Rows.Count + "  |  Charged: " + Money(Sum(d, "Charged")) + "  |  Paid: " + Money(Sum(d, "Paid"));
                    break;

                case "Freeze Report":
                    d = DbSession.Q(@"
SELECT fr.RequestDate AS [Requested], m.FullName AS Member, fr.StartDate AS [From], fr.EndDate AS [To], fr.Reason, fr.Status,
       fr.ExtensionDays AS [Extension Days]
FROM FreezeRequests fr JOIN Memberships ms ON ms.MembershipID = fr.MembershipID JOIN Members m ON m.MemberID = ms.MemberID
WHERE fr.RequestDate BETWEEN @p0 AND @p1 ORDER BY fr.FreezeID", f, t);
                    summary = "Requests: " + d.Rows.Count + "  |  Approved: " + Count(d, "Status", "Approved", "Completed") + "  |  Rejected: " + Count(d, "Status", "Rejected") + "  |  Pending: " + Count(d, "Status", "Pending");
                    break;

                case "Unpaid Balances":
                    d = DbSession.Q(@"
SELECT i.InvoiceNo AS Invoice, i.InvoiceDate AS [Date], m.MemberID AS [Member ID], m.FullName AS Member, i.TotalDue AS [Total Due],
       IFNULL((SELECT SUM(Amount) FROM Payments WHERE InvoiceID = i.InvoiceID),0) AS Paid, i.Status
FROM Invoices i JOIN Members m ON m.MemberID = i.MemberID
WHERE i.Status IN ('Unpaid','Partially Paid') AND i.InvoiceDate BETWEEN @p0 AND @p1 ORDER BY i.InvoiceDate", f, t);
                    d.Columns.Add("Balance", typeof(decimal));
                    foreach (DataRow r in d.Rows) r["Balance"] = Db.ToDec(r["Total Due"]) - Db.ToDec(r["Paid"]);
                    summary = "Open invoices: " + d.Rows.Count + "  |  Outstanding balance: " + Money(Sum(d, "Balance"));
                    break;

                case "Reactivation Report":
                    d = DbSession.Q(@"
SELECT ra.ReactivationDate AS [Date], m.FullName AS Member, ra.NewExpiration AS [New Expiry], ra.Fee, ra.Notes
FROM Reactivations ra JOIN Memberships ms ON ms.MembershipID = ra.MembershipID JOIN Members m ON m.MemberID = ms.MemberID
WHERE ra.ReactivationDate BETWEEN @p0 AND @p1 ORDER BY ra.ReactivationID", f, t);
                    summary = "Reactivations: " + d.Rows.Count + "  |  Fees charged: " + Money(Sum(d, "Fee"));
                    break;

                case "Prorated Billing Report":
                    d = DbSession.Q(@"
SELECT i.InvoiceDate AS [Date], i.InvoiceNo AS Invoice, m.FullName AS Member, i.BillingStart AS [From], i.BillingEnd AS [To],
       i.BaseCharge AS Prorated, i.Discount, i.AdditionalFees AS Fees, i.TotalDue AS Total, i.Status
FROM Invoices i JOIN Members m ON m.MemberID = i.MemberID
WHERE i.Kind = 'Prorated' AND i.InvoiceDate BETWEEN @p0 AND @p1 ORDER BY i.InvoiceID", f, t);
                    summary = "Prorated invoices: " + d.Rows.Count + "  |  Total billed: " + Money(Sum(d, "Total"));
                    break;

                default:
                    throw new ValidationException("Select a report type.");
            }
            return new ReportResult { Data = d, Summary = summary };
        }

        public static string Money(decimal v) => "₱" + v.ToString("N2");

        private static decimal Sum(DataTable d, string col)
        {
            decimal total = 0m;
            foreach (DataRow r in d.Rows) total += Db.ToDec(r[col]);
            return total;
        }

        private static int SumInt(DataTable d, string col)
        {
            int total = 0;
            foreach (DataRow r in d.Rows) total += Db.I(r[col]);
            return total;
        }

        private static int Count(DataTable d, string col, params string[] values)
        {
            int n = 0;
            foreach (DataRow r in d.Rows) if (values.Contains(Db.S(r[col]))) n++;
            return n;
        }
    }
}
