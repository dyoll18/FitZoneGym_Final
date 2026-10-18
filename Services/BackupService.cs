using System.Data;
using System.Globalization;
using Microsoft.Data.Sqlite;
using FitZoneGym.Data;

namespace FitZoneGym.Services
{
    public static class BackupService
    {
        public static string DefaultFolder
        {
            get
            {
                string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FitZoneGym", "Backups");
                Directory.CreateDirectory(dir);
                return dir;
            }
        }

        public static string SuggestFileName() => "fitzone_backup_" + DateTime.Now.ToString("yyyy_MM_dd_HHmm", CultureInfo.InvariantCulture) + ".db";

        private static void Log(string action, string path, string result)
        {
            try
            {
                DbSession.X("INSERT INTO BackupLogs(Timestamp, Action, FilePath, Result, UserID) VALUES (@p0,@p1,@p2,@p3,@p4)",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), action, path, result,
                    Session.UserId == 0 ? (object)null : Session.UserId);
            }
            catch { }
        }

        public static void Backup(string targetPath)
        {
            Session.Require(Perm.Backup);
            if (string.IsNullOrWhiteSpace(targetPath)) throw new ValidationException("Choose a backup file name and location.");
            try
            {
                string full = Path.GetFullPath(targetPath);
                if (string.Equals(full, Path.GetFullPath(Db.FilePath), StringComparison.OrdinalIgnoreCase))
                    throw new ValidationException("The backup file cannot be the live database file.");
                Directory.CreateDirectory(Path.GetDirectoryName(full));
                if (File.Exists(full)) File.Delete(full);

                using (var src = new SqliteConnection(Db.ConnectionString))
                using (var dst = new SqliteConnection("Data Source=" + full + ";Pooling=False"))
                {
                    src.Open(); dst.Open();
                    src.BackupDatabase(dst);
                }
                Log("Backup", full, "Success");
                Audit.Log("Database backup", full);
            }
            catch (ValidationException) { throw; }
            catch (Exception ex)
            {
                Log("Backup", targetPath, "Failed: " + ex.Message);
                throw new ValidationException("Backup failed: " + ex.Message);
            }
        }

        /// <summary>Checks that a file is a readable SQLite database that contains the FITZONE tables.</summary>
        public static void ValidateBackup(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
                throw new ValidationException("The selected backup file does not exist.");
            try
            {
                using var c = new SqliteConnection("Data Source=" + path + ";Mode=ReadOnly;Pooling=False");
                c.Open();
                using var integrity = c.CreateCommand();
                integrity.CommandText = "PRAGMA integrity_check;";
                if (!string.Equals(Convert.ToString(integrity.ExecuteScalar()), "ok", StringComparison.OrdinalIgnoreCase))
                    throw new ValidationException("The backup file failed the integrity check.");

                foreach (string table in new[] { "Members", "Users", "Invoices", "Payments", "Memberships" })
                {
                    using var cmd = c.CreateCommand();
                    cmd.CommandText = "SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name=@n";
                    cmd.Parameters.AddWithValue("@n", table);
                    if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                        throw new ValidationException("This is not a FITZONE GYM backup (missing table '" + table + "').");
                }
            }
            catch (ValidationException) { throw; }
            catch (Exception ex) { throw new ValidationException("The selected file is not a valid backup: " + ex.Message); }
        }

        /// <summary>Restores a validated backup. A safety copy of the current database is made first.</summary>
        public static void Restore(string path)
        {
            Session.Require(Perm.Restore);
            ValidateBackup(path);

            string safety = Path.Combine(DefaultFolder, "pre_restore_" + SuggestFileName());
            Backup(safety);

            SqliteConnection.ClearAllPools();
            File.Copy(path, Db.FilePath, true);
            Schema.EnsureCreated(); // adds any tables an older backup lacks
            Log("Restore", path, "Success (safety copy: " + safety + ")");
        }

        public static DataTable BackupLog() =>
            DbSession.Q("SELECT Timestamp, Action, FilePath, Result FROM BackupLogs ORDER BY BackupID DESC LIMIT 200");

        public static DataTable ErrorLog(string kind) =>
            DbSession.Q("SELECT Timestamp, Kind, Message FROM ErrorLogs WHERE (@p0 = 'Validation') = (Kind = 'Validation') ORDER BY ErrorID DESC LIMIT 200", kind);
    }
}
