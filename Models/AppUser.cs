using System.Data;
using FitZoneGym.Data;

namespace FitZoneGym
{
    public class ValidationException : Exception { public ValidationException(string m) : base(m) { } }
    public class PermissionException : Exception { public PermissionException(string m) : base(m) { } }

    /// <summary>A signed-in staff account with its permissions loaded.</summary>
    public class AppUser
    {
        private readonly HashSet<string> _perms = new HashSet<string>();

        public int UserId { get; private set; }
        public string Username { get; private set; }
        public string FullName { get; private set; }
        public string Role { get; private set; }
        public bool IsAdmin => Role == "Administrator";

        public static AppUser FromRow(DataRow r)
        {
            var u = new AppUser
            {
                UserId = Db.I(r["UserID"]),
                Username = Db.S(r["Username"]),
                FullName = Db.S(r["FullName"]),
                Role = Db.S(r["Role"]),
            };
            if (!u.IsAdmin)
                foreach (DataRow p in DbSession.Q("SELECT PermissionName FROM RolesPermissions WHERE RoleName = @p0", u.Role).Rows)
                    u._perms.Add(Db.S(p[0]));
            return u;
        }

        public bool Can(string permission) => IsAdmin || _perms.Contains(permission);
    }

    /// <summary>Holds the currently signed-in user and enforces permissions in code (not just by hiding buttons).</summary>
    public static class Session
    {
        public static AppUser Current { get; set; }

        public static void Require(string permission)
        {
            if (Current == null || !Current.Can(permission))
                throw new PermissionException("You do not have permission to perform this action.");
        }

        public static int UserId => Current?.UserId ?? 0;
    }
}
