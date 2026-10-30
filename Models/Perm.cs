namespace FitZoneGym
{
    /// <summary>Permission names stored in RolesPermissions and checked in code.</summary>
    public static class Perm
    {
        public const string ViewMembers = "ViewMembers";
        public const string RegisterMembers = "RegisterMembers";   // add/edit members, register & renew
        public const string ManagePlans = "ManagePlans";
        public const string SubmitFreeze = "SubmitFreeze";
        public const string ApproveFreeze = "ApproveFreeze";
        public const string Reactivate = "Reactivate";
        public const string RecordPayments = "RecordPayments";     // payments + prorated billing
        public const string ViewInvoices = "ViewInvoices";
        public const string ViewReports = "ViewReports";
        // Administrator-only (cannot be granted to other roles)
        public const string ManageStaff = "ManageStaff";
        public const string ManageSettings = "ManageSettings";
        public const string Backup = "Backup";
        public const string Restore = "Restore";

        /// <summary>Permissions an administrator may grant to Staff or Cashier.</summary>
        public static readonly (string Key, string Label)[] Grantable =
        {
            (ViewMembers, "View members"),
            (RegisterMembers, "Register / edit members & memberships"),
            (ManagePlans, "Manage membership plans"),
            (SubmitFreeze, "Submit freeze requests"),
            (ApproveFreeze, "Approve / reject freeze requests"),
            (Reactivate, "Reactivate memberships"),
            (RecordPayments, "Record payments & prorated billing"),
            (ViewInvoices, "View / print invoices"),
            (ViewReports, "View financial reports"),
        };
    }
}
