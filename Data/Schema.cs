namespace FitZoneGym.Data
{
    /// <summary>Creates the SQLite schema and seeds default plans, users, permissions and settings.</summary>
    public static class Schema
    {
        private const string Sql = @"
CREATE TABLE IF NOT EXISTS Users (
    UserID        INTEGER PRIMARY KEY AUTOINCREMENT,
    Username      TEXT NOT NULL UNIQUE COLLATE NOCASE,
    FullName      TEXT NOT NULL,
    PasswordHash  TEXT NOT NULL,
    Salt          TEXT NOT NULL,
    Role          TEXT NOT NULL CHECK (Role IN ('Administrator','Staff','Cashier')),
    IsActive      INTEGER NOT NULL DEFAULT 1
);
CREATE TABLE IF NOT EXISTS RolesPermissions (
    RoleName       TEXT NOT NULL,
    PermissionName TEXT NOT NULL,
    PRIMARY KEY (RoleName, PermissionName)
);
CREATE TABLE IF NOT EXISTS Members (
    MemberID         TEXT PRIMARY KEY,
    FullName         TEXT NOT NULL,
    ContactNumber    TEXT NOT NULL,
    Email            TEXT,
    Gender           TEXT,
    BirthDate        TEXT,
    Address          TEXT,
    RegistrationDate TEXT NOT NULL,
    AccountStatus    TEXT NOT NULL DEFAULT 'Active' CHECK (AccountStatus IN ('Active','Inactive')),
    Notes            TEXT
);
CREATE TABLE IF NOT EXISTS MembershipPlans (
    PlanID         INTEGER PRIMARY KEY AUTOINCREMENT,
    PlanName       TEXT NOT NULL UNIQUE COLLATE NOCASE,
    DurationMonths INTEGER NOT NULL CHECK (DurationMonths > 0),
    Fee            REAL NOT NULL CHECK (Fee >= 0),
    Description    TEXT,
    IsActive       INTEGER NOT NULL DEFAULT 1
);
CREATE TABLE IF NOT EXISTS Memberships (
    MembershipID   INTEGER PRIMARY KEY AUTOINCREMENT,
    MemberID       TEXT NOT NULL REFERENCES Members(MemberID),
    PlanID         INTEGER NOT NULL REFERENCES MembershipPlans(PlanID),
    StartDate      TEXT NOT NULL,
    ExpirationDate TEXT NOT NULL,
    Status         TEXT NOT NULL DEFAULT 'Active' CHECK (Status IN ('Active','Frozen','Cancelled')),
    CHECK (ExpirationDate >= StartDate)
);
CREATE TABLE IF NOT EXISTS FreezeRequests (
    FreezeID      INTEGER PRIMARY KEY AUTOINCREMENT,
    MembershipID  INTEGER NOT NULL REFERENCES Memberships(MembershipID),
    RequestDate   TEXT NOT NULL,
    Reason        TEXT NOT NULL,
    StartDate     TEXT NOT NULL,
    EndDate       TEXT NOT NULL,
    Status        TEXT NOT NULL DEFAULT 'Pending' CHECK (Status IN ('Pending','Approved','Rejected','Completed')),
    ExtensionDays INTEGER NOT NULL DEFAULT 0,
    RequestedBy   INTEGER REFERENCES Users(UserID),
    ApprovedBy    INTEGER REFERENCES Users(UserID),
    DecisionDate  TEXT,
    Notes         TEXT,
    CHECK (EndDate >= StartDate)
);
CREATE TABLE IF NOT EXISTS Reactivations (
    ReactivationID  INTEGER PRIMARY KEY AUTOINCREMENT,
    MembershipID    INTEGER NOT NULL REFERENCES Memberships(MembershipID),
    FreezeID        INTEGER REFERENCES FreezeRequests(FreezeID),
    ReactivationDate TEXT NOT NULL,
    Fee             REAL NOT NULL DEFAULT 0,
    NewExpiration   TEXT NOT NULL,
    ProcessedBy     INTEGER REFERENCES Users(UserID),
    InvoiceID       INTEGER,
    Notes           TEXT
);
CREATE TABLE IF NOT EXISTS Renewals (
    RenewalID          INTEGER PRIMARY KEY AUTOINCREMENT,
    MembershipID       INTEGER NOT NULL REFERENCES Memberships(MembershipID),
    TransactionDate    TEXT NOT NULL,
    PlanID             INTEGER NOT NULL REFERENCES MembershipPlans(PlanID),
    PreviousExpiration TEXT NOT NULL,
    NewExpiration      TEXT NOT NULL,
    InvoiceID          INTEGER,
    ProcessedBy        INTEGER REFERENCES Users(UserID)
);
CREATE TABLE IF NOT EXISTS Invoices (
    InvoiceID      INTEGER PRIMARY KEY AUTOINCREMENT,
    InvoiceNo      TEXT NOT NULL UNIQUE,
    MembershipID   INTEGER REFERENCES Memberships(MembershipID),
    MemberID       TEXT NOT NULL REFERENCES Members(MemberID),
    Kind           TEXT NOT NULL DEFAULT 'Registration' CHECK (Kind IN ('Registration','Renewal','Prorated','Reactivation')),
    InvoiceDate    TEXT NOT NULL,
    BillingStart   TEXT,
    BillingEnd     TEXT,
    BaseCharge     REAL NOT NULL CHECK (BaseCharge >= 0),
    Discount       REAL NOT NULL DEFAULT 0 CHECK (Discount >= 0),
    AdditionalFees REAL NOT NULL DEFAULT 0 CHECK (AdditionalFees >= 0),
    TotalDue       REAL NOT NULL CHECK (TotalDue >= 0),
    Status         TEXT NOT NULL DEFAULT 'Unpaid' CHECK (Status IN ('Unpaid','Partially Paid','Paid','Voided')),
    VoidReason     TEXT,
    CreatedBy      INTEGER REFERENCES Users(UserID)
);
CREATE TABLE IF NOT EXISTS InvoiceItems (
    ItemID      INTEGER PRIMARY KEY AUTOINCREMENT,
    InvoiceID   INTEGER NOT NULL REFERENCES Invoices(InvoiceID),
    Description TEXT NOT NULL,
    Quantity    INTEGER NOT NULL DEFAULT 1,
    UnitPrice   REAL NOT NULL,
    Discount    REAL NOT NULL DEFAULT 0
);
CREATE TABLE IF NOT EXISTS Payments (
    PaymentID       INTEGER PRIMARY KEY AUTOINCREMENT,
    InvoiceID       INTEGER NOT NULL REFERENCES Invoices(InvoiceID),
    Amount          REAL NOT NULL CHECK (Amount > 0),
    PaymentDate     TEXT NOT NULL,
    Method          TEXT NOT NULL,
    ReferenceNumber TEXT,
    ReceivedBy      INTEGER REFERENCES Users(UserID)
);
CREATE TABLE IF NOT EXISTS AuditLogs (
    LogID     INTEGER PRIMARY KEY AUTOINCREMENT,
    UserID    INTEGER,
    Action    TEXT NOT NULL,
    Timestamp TEXT NOT NULL,
    Details   TEXT
);
CREATE TABLE IF NOT EXISTS SystemSettings (
    SettingKey   TEXT PRIMARY KEY,
    SettingValue TEXT NOT NULL
);
CREATE TABLE IF NOT EXISTS BackupLogs (
    BackupID  INTEGER PRIMARY KEY AUTOINCREMENT,
    Timestamp TEXT NOT NULL,
    Action    TEXT NOT NULL,
    FilePath  TEXT,
    Result    TEXT,
    UserID    INTEGER
);
CREATE TABLE IF NOT EXISTS ErrorLogs (
    ErrorID   INTEGER PRIMARY KEY AUTOINCREMENT,
    Timestamp TEXT NOT NULL,
    Kind      TEXT NOT NULL,
    Message   TEXT NOT NULL,
    UserID    INTEGER
);
CREATE INDEX IF NOT EXISTS IX_Memberships_Member ON Memberships(MemberID);
CREATE INDEX IF NOT EXISTS IX_Payments_Invoice  ON Payments(InvoiceID);
CREATE INDEX IF NOT EXISTS IX_Invoices_Member   ON Invoices(MemberID);
CREATE INDEX IF NOT EXISTS IX_Freeze_Membership ON FreezeRequests(MembershipID);
";

        public static void EnsureCreated()
        {
            using var s = new DbSession(true);
            foreach (var stmt in Sql.Split(new[] { ";\r\n", ";\n" }, StringSplitOptions.RemoveEmptyEntries))
            {
                string t = stmt.Trim();
                if (t.Length > 0) s.Exec(t);
            }
            Seed(s);
            s.Commit();
        }

        private static void Seed(DbSession s)
        {
            // Settings (INSERT OR IGNORE keeps any value the admin already changed).
            var defaults = new (string, string)[]
            {
                ("GymName", "FITZONE GYM"),
                ("GymAddress", "123 Wellness St., Manila"),
                ("GymContact", "09171234567"),
                ("GymEmail", "info@fitzonegym.com"),
                ("MaxFreezeDays", "30"),
                ("MinFreezeDays", "1"),
                ("RenewalNoticeDays", "7"),
                ("GracePeriodDays", "3"),
                ("ReactivationFee", "0"),
                ("FullFreezeExtension", "true"),
                ("RequireReferenceForNonCash", "true"),
            };
            foreach (var (k, v) in defaults)
                s.Exec("INSERT OR IGNORE INTO SystemSettings(SettingKey, SettingValue) VALUES (@p0, @p1)", k, v);

            // Default role permissions (Administrator always has every permission in code).
            var perms = new Dictionary<string, string[]>
            {
                ["Staff"] = new[] { Perm.ViewMembers, Perm.RegisterMembers, Perm.SubmitFreeze, Perm.Reactivate, Perm.ViewInvoices },
                ["Cashier"] = new[] { Perm.ViewMembers, Perm.RecordPayments, Perm.ViewInvoices },
            };
            if (Convert.ToInt32(s.Scalar("SELECT COUNT(*) FROM RolesPermissions")) == 0)
                foreach (var kv in perms)
                    foreach (var p in kv.Value)
                        s.Exec("INSERT INTO RolesPermissions(RoleName, PermissionName) VALUES (@p0, @p1)", kv.Key, p);

            if (Convert.ToInt32(s.Scalar("SELECT COUNT(*) FROM MembershipPlans")) == 0)
            {
                s.Exec("INSERT INTO MembershipPlans(PlanName, DurationMonths, Fee, Description) VALUES ('Monthly',1,1500,'1 month access')");
                s.Exec("INSERT INTO MembershipPlans(PlanName, DurationMonths, Fee, Description) VALUES ('Quarterly',3,4000,'3 months access')");
                s.Exec("INSERT INTO MembershipPlans(PlanName, DurationMonths, Fee, Description) VALUES ('Annual',12,12000,'12 months access')");
                s.Exec("INSERT INTO MembershipPlans(PlanName, DurationMonths, Fee, Description) VALUES ('Student',6,7500,'6 months access for students')");
            }

            if (Convert.ToInt32(s.Scalar("SELECT COUNT(*) FROM Users")) == 0)
            {
                AddUser(s, "admin", "System Administrator", "Admin@123", "Administrator");
                AddUser(s, "staff1", "Juan Santos", "Staff@123", "Staff");
                AddUser(s, "cashier1", "Maria Lopez", "Cashier@123", "Cashier");
            }
        }

        private static void AddUser(DbSession s, string username, string fullName, string password, string role)
        {
            string salt = Security.NewSalt();
            s.Exec("INSERT INTO Users(Username, FullName, PasswordHash, Salt, Role, IsActive) VALUES (@p0,@p1,@p2,@p3,@p4,1)",
                username, fullName, Security.Hash(password, salt), salt, role);
        }
    }
}
