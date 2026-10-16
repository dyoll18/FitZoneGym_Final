using System.Globalization;
using FitZoneGym.Data;

namespace FitZoneGym.Services
{
    /// <summary>System settings (policies) stored in the SystemSettings table.</summary>
    public static class Settings
    {
        public static string Get(string key, string fallback = "")
        {
            object v = DbSession.V("SELECT SettingValue FROM SystemSettings WHERE SettingKey = @p0", key);
            return v == null ? fallback : Convert.ToString(v);
        }

        public static int GetInt(string key, int fallback) =>
            int.TryParse(Get(key), NumberStyles.Integer, CultureInfo.InvariantCulture, out int n) ? n : fallback;

        public static decimal GetDecimal(string key, decimal fallback) =>
            decimal.TryParse(Get(key), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal n) ? n : fallback;

        public static bool GetBool(string key, bool fallback) =>
            bool.TryParse(Get(key), out bool b) ? b : fallback;

        public static void Set(DbSession s, string key, string value) =>
            s.Exec("INSERT INTO SystemSettings(SettingKey, SettingValue) VALUES (@p0,@p1) " +
                   "ON CONFLICT(SettingKey) DO UPDATE SET SettingValue = excluded.SettingValue", key, value);
    }

    /// <summary>Audit trail and error logging.</summary>
    public static class Audit
    {
        public static void Log(string action, string details = "")
        {
            try
            {
                DbSession.X("INSERT INTO AuditLogs(UserID, Action, Timestamp, Details) VALUES (@p0,@p1,@p2,@p3)",
                    Session.UserId == 0 ? (object)null : Session.UserId, action,
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), details);
            }
            catch { /* logging must never break the operation being logged */ }
        }

        /// <summary>Same as Log but joins an existing transaction so the audit row commits atomically with the change.</summary>
        public static void Log(DbSession s, string action, string details = "") =>
            s.Exec("INSERT INTO AuditLogs(UserID, Action, Timestamp, Details) VALUES (@p0,@p1,@p2,@p3)",
                Session.UserId == 0 ? (object)null : Session.UserId, action,
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), details);

        public static void Error(string kind, string message)
        {
            try
            {
                DbSession.X("INSERT INTO ErrorLogs(Timestamp, Kind, Message, UserID) VALUES (@p0,@p1,@p2,@p3)",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), kind, message,
                    Session.UserId == 0 ? (object)null : Session.UserId);
            }
            catch { }
        }
    }

    /// <summary>Login / logout.</summary>
    public static class AuthService
    {
        public static AppUser Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username)) throw new ValidationException("Username is required.");
            if (string.IsNullOrEmpty(password)) throw new ValidationException("Password is required.");

            var row = DbSession.R("SELECT * FROM Users WHERE Username = @p0", username.Trim());
            if (row == null || !Security.Verify(password, Db.S(row["Salt"]), Db.S(row["PasswordHash"])))
            {
                Audit.Error("Login", "Failed login for username '" + username.Trim() + "'.");
                throw new ValidationException("Invalid username or password.");
            }
            if (Db.I(row["IsActive"]) == 0)
                throw new ValidationException("This account is inactive. Contact an administrator.");

            var user = AppUser.FromRow(row);
            Session.Current = user;
            Audit.Log("Login", user.Username + " signed in.");
            return user;
        }

        public static void Logout()
        {
            if (Session.Current != null) Audit.Log("Logout", Session.Current.Username + " signed out.");
            Session.Current = null;
        }
    }
}
