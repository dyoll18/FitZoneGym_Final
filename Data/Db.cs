using System.Data;
using System.Globalization;
using Microsoft.Data.Sqlite;

namespace FitZoneGym.Data
{
    /// <summary>Database location and helpers.</summary>
    public static class Db
    {
        public static string FilePath
        {
            get
            {
                string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FitZoneGym");
                Directory.CreateDirectory(dir);
                return Path.Combine(dir, "fitzone.db");
            }
        }

        public static string ConnectionString => $"Data Source={FilePath};Pooling=False";

        public const string DateFormat = "yyyy-MM-dd";

        public static string D(DateTime d) => d.ToString(DateFormat, CultureInfo.InvariantCulture);

        public static DateTime ToDate(object v) =>
            DateTime.ParseExact(Convert.ToString(v, CultureInfo.InvariantCulture).Substring(0, 10), DateFormat, CultureInfo.InvariantCulture);

        public static decimal ToDec(object v) =>
            v == null || v == DBNull.Value ? 0m : Math.Round(Convert.ToDecimal(v, CultureInfo.InvariantCulture), 2);

        public static string S(object v) => v == null || v == DBNull.Value ? "" : Convert.ToString(v, CultureInfo.InvariantCulture);

        public static int I(object v) => v == null || v == DBNull.Value ? 0 : Convert.ToInt32(v, CultureInfo.InvariantCulture);
    }

    /// <summary>
    /// A short-lived connection, optionally wrapped in a transaction.
    /// All SQL is parameterised: use @p0, @p1 ... in the SQL text and pass values positionally.
    /// </summary>
    public sealed class DbSession : IDisposable
    {
        private readonly SqliteConnection _conn;
        private SqliteTransaction _tx;

        public DbSession(bool transaction = false)
        {
            _conn = new SqliteConnection(Db.ConnectionString);
            _conn.Open();
            using (var pragma = _conn.CreateCommand())
            {
                pragma.CommandText = "PRAGMA foreign_keys = ON;";
                pragma.ExecuteNonQuery();
            }
            if (transaction) _tx = _conn.BeginTransaction();
        }

        public SqliteConnection Connection => _conn;

        private SqliteCommand Cmd(string sql, object[] args)
        {
            var cmd = _conn.CreateCommand();
            cmd.Transaction = _tx;
            cmd.CommandText = sql;
            for (int i = 0; i < args.Length; i++)
            {
                object v = args[i];
                if (v == null) v = DBNull.Value;
                else if (v is DateTime dt) v = Db.D(dt);
                else if (v is decimal m) v = (double)Math.Round(m, 2);
                else if (v is bool b) v = b ? 1 : 0;
                cmd.Parameters.AddWithValue("@p" + i, v);
            }
            return cmd;
        }

        public int Exec(string sql, params object[] args)
        {
            using var cmd = Cmd(sql, args);
            return cmd.ExecuteNonQuery();
        }

        /// <summary>Runs an INSERT and returns the new row id.</summary>
        public long Insert(string sql, params object[] args)
        {
            Exec(sql, args);
            using var cmd = Cmd("SELECT last_insert_rowid();", Array.Empty<object>());
            return Convert.ToInt64(cmd.ExecuteScalar());
        }

        public object Scalar(string sql, params object[] args)
        {
            using var cmd = Cmd(sql, args);
            object v = cmd.ExecuteScalar();
            return v == DBNull.Value ? null : v;
        }

        public DataTable Query(string sql, params object[] args)
        {
            using var cmd = Cmd(sql, args);
            using var reader = cmd.ExecuteReader();
            var table = new DataTable();
            table.Load(reader);
            return table;
        }

        public DataRow Row(string sql, params object[] args)
        {
            var t = Query(sql, args);
            return t.Rows.Count == 0 ? null : t.Rows[0];
        }

        public void Commit() { _tx?.Commit(); _tx = null; }

        public void Dispose()
        {
            try { _tx?.Rollback(); } catch { }
            _tx?.Dispose();
            _conn.Dispose();
        }

        // ---- one-shot conveniences -----------------------------------------------------------
        public static DataTable Q(string sql, params object[] args) { using var s = new DbSession(); return s.Query(sql, args); }
        public static DataRow R(string sql, params object[] args) { using var s = new DbSession(); return s.Row(sql, args); }
        public static object V(string sql, params object[] args) { using var s = new DbSession(); return s.Scalar(sql, args); }
        public static int X(string sql, params object[] args) { using var s = new DbSession(); return s.Exec(sql, args); }
    }
}
