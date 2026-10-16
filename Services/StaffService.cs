using System.Data;
using System.Text.RegularExpressions;
using FitZoneGym.Data;

namespace FitZoneGym.Services
{
    public static class StaffService
    {
        public static readonly string[] Roles = { "Administrator", "Staff", "Cashier" };

        public static DataTable List()
        {
            Session.Require(Perm.ManageStaff);
            return DbSession.Q("SELECT UserID, Username, FullName, Role, CASE IsActive WHEN 1 THEN 'Active' ELSE 'Inactive' END AS Status FROM Users ORDER BY UserID");
        }

        public static void ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
                throw new ValidationException("Password must be at least 8 characters long.");
            if (!password.Any(char.IsLetter) || !password.Any(char.IsDigit))
                throw new ValidationException("Password must contain both letters and numbers.");
        }

        public static void Add(string username, string fullName, string role, string password, bool active)
        {
            Session.Require(Perm.ManageStaff);
            if (string.IsNullOrWhiteSpace(username) || !Regex.IsMatch(username.Trim(), @"^[A-Za-z0-9_.]{3,30}$"))
                throw new ValidationException("Username must be 3-30 characters (letters, digits, _ or .).");
            if (string.IsNullOrWhiteSpace(fullName)) throw new ValidationException("Full name is required.");
            if (!Roles.Contains(role)) throw new ValidationException("Select a valid role.");
            ValidatePassword(password);

            using var s = new DbSession(true);
            if (s.Scalar("SELECT 1 FROM Users WHERE Username = @p0", username.Trim()) != null)
                throw new ValidationException("That username is already taken.");
            string salt = Security.NewSalt();
            s.Exec("INSERT INTO Users(Username, FullName, PasswordHash, Salt, Role, IsActive) VALUES (@p0,@p1,@p2,@p3,@p4,@p5)",
                username.Trim(), fullName.Trim(), Security.Hash(password, salt), salt, role, active);
            Audit.Log(s, "Staff account created", username.Trim() + " (" + role + ")");
            s.Commit();
        }

        public static void Update(int userId, string fullName, string role, bool active, string newPassword)
        {
            Session.Require(Perm.ManageStaff);
            if (string.IsNullOrWhiteSpace(fullName)) throw new ValidationException("Full name is required.");
            if (!Roles.Contains(role)) throw new ValidationException("Select a valid role.");

            using var s = new DbSession(true);
            var u = s.Row("SELECT Username, Role, IsActive FROM Users WHERE UserID = @p0", userId);
            if (u == null) throw new ValidationException("User not found.");

            bool wasActiveAdmin = Db.S(u["Role"]) == "Administrator" && Db.I(u["IsActive"]) == 1;
            bool staysActiveAdmin = role == "Administrator" && active;
            if (wasActiveAdmin && !staysActiveAdmin &&
                Convert.ToInt32(s.Scalar("SELECT COUNT(*) FROM Users WHERE Role='Administrator' AND IsActive=1 AND UserID <> @p0", userId)) == 0)
                throw new ValidationException("At least one active administrator account must remain.");
            if (userId == Session.UserId && !active) throw new ValidationException("You cannot deactivate your own account.");

            s.Exec("UPDATE Users SET FullName=@p1, Role=@p2, IsActive=@p3 WHERE UserID=@p0", userId, fullName.Trim(), role, active);
            if (!string.IsNullOrEmpty(newPassword))
            {
                ValidatePassword(newPassword);
                string salt = Security.NewSalt();
                s.Exec("UPDATE Users SET PasswordHash=@p1, Salt=@p2 WHERE UserID=@p0", userId, Security.Hash(newPassword, salt), salt);
            }
            Audit.Log(s, "Staff account updated", Db.S(u["Username"]));
            s.Commit();
        }

        public static HashSet<string> GetPermissions(string role)
        {
            var set = new HashSet<string>();
            foreach (DataRow r in DbSession.Q("SELECT PermissionName FROM RolesPermissions WHERE RoleName = @p0", role).Rows)
                set.Add(Db.S(r[0]));
            return set;
        }

        public static void SavePermissions(string role, IEnumerable<string> permissions)
        {
            Session.Require(Perm.ManageStaff);
            if (role == "Administrator") throw new ValidationException("Administrator permissions cannot be changed.");
            var allowed = Perm.Grantable.Select(g => g.Key).ToHashSet();
            using var s = new DbSession(true);
            s.Exec("DELETE FROM RolesPermissions WHERE RoleName = @p0", role);
            foreach (string p in permissions.Where(allowed.Contains))
                s.Exec("INSERT INTO RolesPermissions(RoleName, PermissionName) VALUES (@p0,@p1)", role, p);
            Audit.Log(s, "Permissions updated", role);
            s.Commit();
        }

        public static DataTable ActivityLog(int limit = 300)
        {
            Session.Require(Perm.ManageStaff);
            return DbSession.Q(@"SELECT a.Timestamp, IFNULL(u.Username,'system') AS [User], a.Action, a.Details
                                 FROM AuditLogs a LEFT JOIN Users u ON u.UserID = a.UserID ORDER BY a.LogID DESC LIMIT @p0", limit);
        }

        public static DataTable RecentActivity(int limit = 6) =>
            DbSession.Q(@"SELECT a.Timestamp, a.Action, a.Details FROM AuditLogs a WHERE a.Action NOT IN ('Login','Logout') ORDER BY a.LogID DESC LIMIT @p0", limit);
    }
}
