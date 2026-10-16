using FitZoneGym.Data;

namespace FitZoneGym
{
    /// <summary>Membership state derived from dates and freeze records (kept separate from account status).</summary>
    public enum MembershipState { Pending, Active, Frozen, Expired, Inactive }

    public class Member
    {
        public string MemberId { get; set; }
        public string FullName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Address { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Today;
        public string AccountStatus { get; set; } = "Active";
        public string Notes { get; set; }
    }

    public class MembershipPlan
    {
        public int PlanId { get; set; }
        public string PlanName { get; set; }
        public int DurationMonths { get; set; }
        public decimal Fee { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;

        /// <summary>Fee for one month of this plan (used as the base for prorating).</summary>
        public decimal MonthlyEquivalent => Math.Round(Fee / DurationMonths, 2, MidpointRounding.AwayFromZero);
        public override string ToString() => PlanName;
    }

    public class Membership
    {
        public int MembershipId { get; set; }
        public string MemberId { get; set; }
        public int PlanId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string StoredStatus { get; set; }

        public MembershipState State => ComputeState(StoredStatus, StartDate, ExpirationDate);

        public static MembershipState ComputeState(string stored, DateTime start, DateTime exp)
        {
            if (stored == "Cancelled") return MembershipState.Inactive;
            if (stored == "Frozen") return MembershipState.Frozen;
            if (exp.Date < DateTime.Today) return MembershipState.Expired;
            if (start.Date > DateTime.Today) return MembershipState.Pending;
            return MembershipState.Active;
        }

        /// <summary>
        /// Gym policy: a membership starting on S for N months ends on S + N months - 1 day (inclusive end date).
        /// Example: 2025-04-01 + 1 month => 2025-04-30.
        /// </summary>
        public static DateTime CalcExpiration(DateTime start, int durationMonths) =>
            start.Date.AddMonths(durationMonths).AddDays(-1);
    }

    public class FreezeRequest
    {
        public int FreezeId { get; set; }
        public int MembershipId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; }
        /// <summary>Inclusive number of calendar days in the requested freeze.</summary>
        public int Days => (EndDate.Date - StartDate.Date).Days + 1;
    }

    /// <summary>An invoice owns its arithmetic (encapsulation): total and balance are always derived.</summary>
    public class Invoice
    {
        public decimal BaseCharge { get; set; }
        public decimal Discount { get; set; }
        public decimal AdditionalFees { get; set; }
        public decimal TotalDue => Math.Round(BaseCharge - Discount + AdditionalFees, 2, MidpointRounding.AwayFromZero);

        public decimal BalanceAfter(decimal paymentsApplied) => Math.Round(TotalDue - paymentsApplied, 2, MidpointRounding.AwayFromZero);

        public static string StatusFor(decimal totalDue, decimal paid)
        {
            if (paid <= 0m) return "Unpaid";
            return paid >= totalDue ? "Paid" : "Partially Paid";
        }
    }

    public class Payment
    {
        public int InvoiceId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Today;
        public string Method { get; set; } = "Cash";
        public string ReferenceNumber { get; set; }
    }
}
