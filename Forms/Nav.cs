using FitZoneGym.Services;

namespace FitZoneGym.Forms
{
    public sealed class NavItem
    {
        public string Key { get; set; }
        public string Text { get; set; }
        public Func<bool> Visible { get; set; }
        public Func<Form> Create { get; set; }
    }

    /// <summary>Moves between the screens (each screen is its own Form) while keeping one application message loop.</summary>
    public static class Nav
    {
        public static ApplicationContext Context { get; private set; }
        public static bool LoggedOut { get; private set; }

        // Basic edition: only the five core screens are available in navigation.
        public static readonly List<NavItem> Items = new List<NavItem>
        {
            new NavItem { Key = "dash", Text = "Dashboard", Visible = () => true, Create = () => new DashboardForm() },
            new NavItem { Key = "members", Text = "Members", Visible = () => Session.Current.Can(Perm.ViewMembers), Create = () => new MembersForm() },
            new NavItem { Key = "plans", Text = "Membership Plans", Visible = () => Session.Current.Can(Perm.ManagePlans) || Session.Current.Can(Perm.ViewMembers), Create = () => new PlansForm() },
            new NavItem { Key = "reg", Text = "Registration & Renewal", Visible = () => Session.Current.Can(Perm.RegisterMembers), Create = () => new RegistrationForm() },
            new NavItem { Key = "pay", Text = "Payments", Visible = () => Session.Current.Can(Perm.RecordPayments), Create = () => new PaymentsForm() },
            new NavItem { Key = "reports", Text = "Reports Generation", Visible = () => Session.Current.Can(Perm.ViewReports), Create = () => new ReportsForm() },
            new NavItem { Key = "staff", Text = "User Management", Visible = () => Session.Current.Can(Perm.ManageStaff), Create = () => new StaffForm() },
        };

        /// <summary>Runs the main window loop until the user logs out or closes the application.</summary>
        public static void Run(Form first)
        {
            LoggedOut = false;
            var area = Screen.PrimaryScreen.WorkingArea;
            first.WindowState = FormWindowState.Normal;
            first.StartPosition = FormStartPosition.CenterScreen;
            first.FormBorderStyle = FormBorderStyle.Sizable;
            // Not full screen: 1180x720 at 100% scaling (scaled with the display DPI), at most ~80% of the usable screen
            first.Size = new Size(Math.Min(first.LogicalToDeviceUnits(1180), (int)(area.Width * 0.80)),
                                  Math.Min(first.LogicalToDeviceUnits(720), (int)(area.Height * 0.82)));

            Context = new ApplicationContext(first);
            Application.Run(Context);
        }

        public static void Go(Form current, string key)
        {
            var item = Items.FirstOrDefault(i => i.Key == key && i.Visible());
            if (item == null) return;
            Form next = null;
            if (!Ui.Run(() => next = item.Create())) return;

            next.StartPosition = FormStartPosition.Manual;
            next.Bounds = current.Bounds;
            next.WindowState = current.WindowState;
            next.Show();
            Context.MainForm = next;   // set before closing so the loop keeps running
            current.Close();
        }

        public static void Logout(Form current)
        {
            using (var dlg = new LogoutDialog())
                if (dlg.ShowDialog(current) != DialogResult.Yes) return;
            ForceLogout(current);
        }

        public static void ForceLogout(Form current)
        {
            AuthService.Logout();
            LoggedOut = true;
            Context.MainForm = current;
            current.Close();
        }
    }
}
