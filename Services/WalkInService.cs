using System.Data;
using System.Globalization;
using FitZoneGym.Data;

namespace FitZoneGym.Services
{
    public class WalkInBill
    {
        public DateTime TimeIn, TimeOut;
        public int Hours;
        public decimal Rate, Amount;
        public TimeSpan Elapsed => TimeOut - TimeIn;
    }

    public static class WalkInService
    {
        public const string StampFormat = "yyyy-MM-dd HH:mm:ss";
        public static readonly string[] Methods = { "Cash", "GCash", "Card", "Other" };

        private static string Stamp(DateTime d) => d.ToString(StampFormat, CultureInfo.InvariantCulture);
        private static DateTime Parse(object v) => DateTime.ParseExact(Db.S(v), StampFormat, CultureInfo.InvariantCulture);

        public static decimal Rate => Settings.GetDecimal("WalkInRatePerHour", 50m);
        public static int GraceMinutes => Settings.GetInt("WalkInGraceMinutes", 0);

        public static int BillableHours(DateTime timeIn, DateTime timeOut, int graceMinutes)
        {
            double minutes = (timeOut - timeIn).TotalMinutes - graceMinutes;
            return Math.Max(1, (int)Math.Ceiling(minutes / 60.0));
        }

        public static WalkInBill Compute(DateTime timeIn, DateTime timeOut, decimal rate)
        {
            int hours = BillableHours(timeIn, timeOut, GraceMinutes);
            return new WalkInBill
            {
                TimeIn = timeIn, TimeOut = timeOut, Hours = hours, Rate = rate,
                Amount = Math.Round(hours * rate, 2, MidpointRounding.AwayFromZero),
            };
        }

        public static void CheckIn(string name, string contact)
        {
            Session.Require(Perm.ManageWalkIns);
            if (string.IsNullOrWhiteSpace(name)) throw new ValidationException("Client name is required.");
            name = name.Trim();
            if (name.Length > 100) throw new ValidationException("Client name is too long.");

            using var s = new DbSession(true);
            if (Convert.ToInt32(s.Scalar("SELECT COUNT(*) FROM WalkInVisits WHERE Status = 'Inside' AND ClientName = @p0 COLLATE NOCASE", name)) > 0)
                throw new ValidationException(name + " is already checked in.");

            decimal rate = Rate;
            if (rate <= 0m) throw new ValidationException("The walk-in hourly rate is not configured.");

            s.Exec(@"INSERT INTO WalkInVisits(ClientName, ContactNumber, TimeIn, RatePerHour, Status, CheckedInBy)
                     VALUES (@p0,@p1,@p2,@p3,'Inside',@p4)",
                name, string.IsNullOrWhiteSpace(contact) ? null : contact.Trim(), Stamp(DateTime.Now), rate,
                Session.UserId == 0 ? (object)null : Session.UserId);
            Audit.Log(s, "Walk-in check-in", name);
            s.Commit();
        }

        public static DataTable Inside()
        {
            Session.Require(Perm.ManageWalkIns);
            return DbSession.Q("SELECT VisitID, ClientName, ContactNumber, TimeIn, RatePerHour FROM WalkInVisits WHERE Status = 'Inside' ORDER BY VisitID");
        }

        public static DataTable Today()
        {
            Session.Require(Perm.ManageWalkIns);
            return DbSession.Q(@"SELECT VisitID, ClientName, TimeIn, TimeOut, HoursCharged, Amount, PaymentMethod, Status
                                 FROM WalkInVisits WHERE Status <> 'Inside' AND SUBSTR(TimeIn,1,10) = @p0 ORDER BY VisitID DESC", Db.D(DateTime.Today));
        }

        public static decimal TodayTotal() =>
            Db.ToDec(DbSession.V("SELECT IFNULL(SUM(Amount),0) FROM WalkInVisits WHERE Status = 'Completed' AND SUBSTR(TimeIn,1,10) = @p0", Db.D(DateTime.Today)));

        public static WalkInBill Preview(int visitId)
        {
            Session.Require(Perm.ManageWalkIns);
            var v = DbSession.R("SELECT TimeIn, RatePerHour, Status FROM WalkInVisits WHERE VisitID = @p0", visitId);
            if (v == null) throw new ValidationException("Visit not found.");
            if (Db.S(v["Status"]) != "Inside") throw new ValidationException("This client is not currently checked in.");
            return Compute(Parse(v["TimeIn"]), DateTime.Now, Db.ToDec(v["RatePerHour"]));
        }

        public static void CheckOut(int visitId, string method, string reference)
        {
            Session.Require(Perm.ManageWalkIns);
            if (string.IsNullOrWhiteSpace(method)) throw new ValidationException("Select a payment method.");
            if (method != "Cash" && Settings.GetBool("RequireReferenceForNonCash", true) && string.IsNullOrWhiteSpace(reference))
                throw new ValidationException("A reference number is required for " + method + " payments.");

            using var s = new DbSession(true);
            var v = s.Row("SELECT * FROM WalkInVisits WHERE VisitID = @p0", visitId);
            if (v == null) throw new ValidationException("Visit not found.");
            if (Db.S(v["Status"]) != "Inside") throw new ValidationException("This client is not currently checked in.");

            var bill = Compute(Parse(v["TimeIn"]), DateTime.Now, Db.ToDec(v["RatePerHour"]));
            s.Exec(@"UPDATE WalkInVisits SET TimeOut = @p1, HoursCharged = @p2, Amount = @p3, PaymentMethod = @p4, ReferenceNumber = @p5,
                            Status = 'Completed', CheckedOutBy = @p6 WHERE VisitID = @p0",
                visitId, Stamp(bill.TimeOut), bill.Hours, bill.Amount, method,
                string.IsNullOrWhiteSpace(reference) ? null : reference.Trim(),
                Session.UserId == 0 ? (object)null : Session.UserId);
            string name = Db.S(v["ClientName"]);
            Audit.Log(s, "Walk-in check-out", name + ": " + bill.Hours + " hr x " + bill.Rate.ToString("N2") + " = " + bill.Amount.ToString("N2") + " via " + method);
            s.Commit();
        }

        public static void Void(int visitId, string reason)
        {
            Session.Require(Perm.ManageSettings);
            if (string.IsNullOrWhiteSpace(reason)) throw new ValidationException("A reason is required to void a visit.");
            using var s = new DbSession(true);
            var v = s.Row("SELECT ClientName, Status FROM WalkInVisits WHERE VisitID = @p0", visitId);
            if (v == null) throw new ValidationException("Visit not found.");
            if (Db.S(v["Status"]) == "Voided") throw new ValidationException("This visit is already voided.");
            s.Exec("UPDATE WalkInVisits SET Status = 'Voided', VoidReason = @p1 WHERE VisitID = @p0", visitId, reason.Trim());
            Audit.Log(s, "Walk-in voided", Db.S(v["ClientName"]) + ": " + reason.Trim());
            s.Commit();
        }
    }
}
