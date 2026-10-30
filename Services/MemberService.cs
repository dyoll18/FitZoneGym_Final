using System.Data;
using System.Text.RegularExpressions;
using FitZoneGym.Data;

namespace FitZoneGym.Services
{
    public static class MemberService
    {
        // ---- validation ---------------------------------------------------------------------
        public static void Validate(Member m)
        {
            if (string.IsNullOrWhiteSpace(m.FullName)) throw new ValidationException("Full name is required.");
            if (m.FullName.Trim().Length > 100) throw new ValidationException("Full name is too long (max 100 characters).");
            if (string.IsNullOrWhiteSpace(m.ContactNumber)) throw new ValidationException("Contact number is required.");

            int digits = m.ContactNumber.Count(char.IsDigit);
            if (digits < 7 || digits > 15 || !Regex.IsMatch(m.ContactNumber.Trim(), @"^[0-9+\-\s()]+$"))
                throw new ValidationException("Contact number must contain 7 to 15 digits (digits, spaces, +, -, ( ) only).");

            if (!string.IsNullOrWhiteSpace(m.Email) &&
                !Regex.IsMatch(m.Email.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ValidationException("Email address is not valid.");

            if (m.BirthDate.HasValue)
            {
                if (m.BirthDate.Value.Date > DateTime.Today) throw new ValidationException("Birth date cannot be in the future.");
                if (m.BirthDate.Value.Date < DateTime.Today.AddYears(-110)) throw new ValidationException("Birth date is not realistic.");
            }
        }

        // ---- queries ------------------------------------------------------------------------
        private const string ListSql = @"
SELECT m.MemberID, m.FullName, m.ContactNumber, m.Email, m.AccountStatus,
       ms.MembershipID, p.PlanName, ms.StartDate, ms.ExpirationDate, ms.Status AS StoredStatus
FROM Members m
LEFT JOIN Memberships ms ON ms.MembershipID =
     (SELECT MembershipID FROM Memberships WHERE MemberID = m.MemberID
      ORDER BY ExpirationDate DESC, MembershipID DESC LIMIT 1)
LEFT JOIN MembershipPlans p ON p.PlanID = ms.PlanID
WHERE (@p0 = '' OR m.FullName LIKE '%' || @p0 || '%' OR m.MemberID LIKE '%' || @p0 || '%'
       OR m.ContactNumber LIKE '%' || @p0 || '%')
ORDER BY m.MemberID";

        /// <summary>Members with their latest membership and a derived MembershipStatus column.</summary>
        public static DataTable Search(string text = "", string statusFilter = "All")
        {
            Session.Require(Perm.ViewMembers);
            var t = DbSession.Q(ListSql, (text ?? "").Trim());
            AddStatusColumn(t);

            if (statusFilter != null && statusFilter != "All")
            {
                for (int i = t.Rows.Count - 1; i >= 0; i--)
                {
                    var r = t.Rows[i];
                    string ms = Db.S(r["MembershipStatus"]);
                    bool keep = statusFilter switch
                    {
                        "Inactive Accounts" => Db.S(r["AccountStatus"]) == "Inactive",
                        "No Membership" => ms == "None",
                        _ => ms == statusFilter,
                    };
                    if (!keep) t.Rows.RemoveAt(i);
                }
            }
            return t;
        }

        /// <summary>Lookup used by registration / payments / reactivation screens (needs any member-facing permission).</summary>
        public static DataTable Lookup(string text)
        {
            var t = DbSession.Q(ListSql, (text ?? "").Trim());
            AddStatusColumn(t);
            return t;
        }

        public static void AddStatusColumn(DataTable t)
        {
            t.Columns.Add("MembershipStatus", typeof(string));
            foreach (DataRow r in t.Rows)
            {
                if (r["MembershipID"] == DBNull.Value) { r["MembershipStatus"] = "None"; continue; }
                var state = Membership.ComputeState(Db.S(r["StoredStatus"]), Db.ToDate(r["StartDate"]), Db.ToDate(r["ExpirationDate"]));
                r["MembershipStatus"] = state.ToString();
            }
        }

        public static Member Get(string memberId)
        {
            var r = DbSession.R("SELECT * FROM Members WHERE MemberID = @p0", memberId);
            if (r == null) return null;
            return new Member
            {
                MemberId = Db.S(r["MemberID"]),
                FullName = Db.S(r["FullName"]),
                ContactNumber = Db.S(r["ContactNumber"]),
                Email = Db.S(r["Email"]),
                Gender = Db.S(r["Gender"]),
                BirthDate = r["BirthDate"] == DBNull.Value || Db.S(r["BirthDate"]) == "" ? (DateTime?)null : Db.ToDate(r["BirthDate"]),
                Address = Db.S(r["Address"]),
                RegistrationDate = Db.ToDate(r["RegistrationDate"]),
                AccountStatus = Db.S(r["AccountStatus"]),
                Notes = Db.S(r["Notes"]),
            };
        }

        // ---- commands -----------------------------------------------------------------------
        public static string Add(Member m)
        {
            Session.Require(Perm.RegisterMembers);
            Validate(m);
            using var s = new DbSession(true);
            CheckDuplicate(s, m, null);

            object max = s.Scalar("SELECT MAX(CAST(SUBSTR(MemberID, 3) AS INTEGER)) FROM Members");
            int next = (max == null ? 0 : Convert.ToInt32(max)) + 1;
            m.MemberId = "M-" + next.ToString("000");

            s.Exec(@"INSERT INTO Members(MemberID, FullName, ContactNumber, Email, Gender, BirthDate, Address, RegistrationDate, AccountStatus, Notes)
                     VALUES (@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,'Active',@p8)",
                m.MemberId, m.FullName.Trim(), m.ContactNumber.Trim(), Nz(m.Email), Nz(m.Gender), m.BirthDate, Nz(m.Address),
                m.RegistrationDate, Nz(m.Notes));
            Audit.Log(s, "Member added", m.MemberId + " " + m.FullName.Trim());
            s.Commit();
            return m.MemberId;
        }

        public static void Update(Member m)
        {
            Session.Require(Perm.RegisterMembers);
            Validate(m);
            using var s = new DbSession(true);
            if (s.Scalar("SELECT 1 FROM Members WHERE MemberID = @p0", m.MemberId) == null)
                throw new ValidationException("Member " + m.MemberId + " no longer exists.");
            CheckDuplicate(s, m, m.MemberId);
            s.Exec(@"UPDATE Members SET FullName=@p1, ContactNumber=@p2, Email=@p3, Gender=@p4, BirthDate=@p5,
                     Address=@p6, Notes=@p7, AccountStatus=@p8 WHERE MemberID=@p0",
                m.MemberId, m.FullName.Trim(), m.ContactNumber.Trim(), Nz(m.Email), Nz(m.Gender), m.BirthDate,
                Nz(m.Address), Nz(m.Notes), m.AccountStatus);
            Audit.Log(s, "Member updated", m.MemberId + " " + m.FullName.Trim());
            s.Commit();
        }

        public static void SetAccountStatus(string memberId, bool active)
        {
            Session.Require(Perm.RegisterMembers);
            using var s = new DbSession(true);
            int n = s.Exec("UPDATE Members SET AccountStatus = @p1 WHERE MemberID = @p0", memberId, active ? "Active" : "Inactive");
            if (n == 0) throw new ValidationException("Member not found.");
            Audit.Log(s, active ? "Member activated" : "Member deactivated", memberId);
            s.Commit();
        }

        private static void CheckDuplicate(DbSession s, Member m, string excludeId)
        {
            string ex = excludeId ?? "";
            if (s.Scalar("SELECT 1 FROM Members WHERE LOWER(FullName) = LOWER(@p0) AND ContactNumber = @p1 AND MemberID <> @p2",
                    m.FullName.Trim(), m.ContactNumber.Trim(), ex) != null)
                throw new ValidationException("A member with the same name and contact number already exists.");
            if (!string.IsNullOrWhiteSpace(m.Email) &&
                s.Scalar("SELECT 1 FROM Members WHERE LOWER(Email) = LOWER(@p0) AND MemberID <> @p1", m.Email.Trim(), ex) != null)
                throw new ValidationException("Another member already uses this email address.");
        }

        private static object Nz(string v) => string.IsNullOrWhiteSpace(v) ? null : v.Trim();
    }

    public static class PlanService
    {
        public static DataTable List(bool activeOnly = false) =>
            DbSession.Q("SELECT PlanID, PlanName, DurationMonths, Fee, Description, IsActive FROM MembershipPlans " +
                        (activeOnly ? "WHERE IsActive = 1 " : "") + "ORDER BY DurationMonths, PlanName");

        public static MembershipPlan Get(int planId)
        {
            var r = DbSession.R("SELECT * FROM MembershipPlans WHERE PlanID = @p0", planId);
            return r == null ? null : FromRow(r);
        }

        public static MembershipPlan FromRow(DataRow r) => new MembershipPlan
        {
            PlanId = Db.I(r["PlanID"]),
            PlanName = Db.S(r["PlanName"]),
            DurationMonths = Db.I(r["DurationMonths"]),
            Fee = Db.ToDec(r["Fee"]),
            Description = Db.S(r["Description"]),
            IsActive = Db.I(r["IsActive"]) == 1,
        };

        public static void Validate(MembershipPlan p)
        {
            if (string.IsNullOrWhiteSpace(p.PlanName)) throw new ValidationException("Plan name is required.");
            if (p.DurationMonths <= 0 || p.DurationMonths > 60) throw new ValidationException("Duration must be between 1 and 60 months.");
            if (p.Fee < 0) throw new ValidationException("Fee cannot be negative.");
            if (p.Fee == 0) throw new ValidationException("Fee must be greater than zero.");
        }

        public static void Save(MembershipPlan p)
        {
            Session.Require(Perm.ManagePlans);
            Validate(p);
            using var s = new DbSession(true);
            if (s.Scalar("SELECT 1 FROM MembershipPlans WHERE PlanName = @p0 AND PlanID <> @p1", p.PlanName.Trim(), p.PlanId) != null)
                throw new ValidationException("A plan named '" + p.PlanName.Trim() + "' already exists.");

            if (p.PlanId == 0)
            {
                s.Exec("INSERT INTO MembershipPlans(PlanName, DurationMonths, Fee, Description, IsActive) VALUES (@p0,@p1,@p2,@p3,1)",
                    p.PlanName.Trim(), p.DurationMonths, p.Fee, p.Description);
                Audit.Log(s, "Plan added", p.PlanName.Trim());
            }
            else
            {
                // Existing memberships keep their invoices, so changing a fee never rewrites history.
                s.Exec("UPDATE MembershipPlans SET PlanName=@p1, DurationMonths=@p2, Fee=@p3, Description=@p4 WHERE PlanID=@p0",
                    p.PlanId, p.PlanName.Trim(), p.DurationMonths, p.Fee, p.Description);
                Audit.Log(s, "Plan updated", p.PlanName.Trim());
            }
            s.Commit();
        }

        /// <summary>Plans are deactivated, never deleted, because historical memberships reference them.</summary>
        public static void SetActive(int planId, bool active)
        {
            Session.Require(Perm.ManagePlans);
            DbSession.X("UPDATE MembershipPlans SET IsActive = @p1 WHERE PlanID = @p0", planId, active);
            Audit.Log(active ? "Plan activated" : "Plan deactivated", "PlanID " + planId);
        }
    }
}
