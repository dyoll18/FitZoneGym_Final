using System.Data;
using FitZoneGym.Controls;
using FitZoneGym.Data;
using FitZoneGym.Services;

namespace FitZoneGym.Forms
{
    /// <summary>Screen 2 - Dashboard (main form).</summary>
    public partial class DashboardForm : ShellForm
    {
        protected override string NavKey { get { return "dash"; } }

        public DashboardForm()
        {
            InitializeComponent();
            Ui.StyleGrid(dgvExpiring);
            Ui.StyleGrid(dgvActivity);

            if (Ui.IsDesignTime) return;
            StyleStat(pnlTotal, lblTotalValue, lblTotalCaption, Ui.Accent);
            StyleStat(pnlActive, lblActiveValue, lblActiveCaption, Ui.Green);
            StyleStat(pnlFrozen, lblFrozenValue, lblFrozenCaption, Ui.Orange);
            StyleStat(pnlExpired, lblExpiredValue, lblExpiredCaption, Ui.Red);
        }

        /// <summary>FitFlow-style stat card: dark surface, white number, muted caption and a coloured accent bar.</summary>
        private static void StyleStat(Panel card, Label value, Label caption, Color accent)
        {
            card.BackColor = Ui.Surface;
            card.Padding = new Padding(22, 14, 10, 10);
            value.ForeColor = Ui.Text;
            caption.ForeColor = Ui.Muted;
            caption.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
            card.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (var br = new SolidBrush(accent))
                    e.Graphics.FillRectangle(br, 0, 20, 5, Math.Max(10, card.Height - 40));
            };
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (Ui.IsDesignTime) return;
            Ui.Run(LoadData);
        }

        private void LoadData()
        {
            var members = MemberService.Lookup("");
            int total = 0, active = 0, frozen = 0, expired = 0;
            foreach (DataRow r in members.Rows)
            {
                if (Db.S(r["AccountStatus"]) != "Active") continue;
                total++;
                switch (Db.S(r["MembershipStatus"]))
                {
                    case "Active": active++; break;
                    case "Frozen": frozen++; break;
                    case "Expired": expired++; break;
                }
            }
            lblTotalValue.Text = total.ToString();
            lblActiveValue.Text = active.ToString();
            lblFrozenValue.Text = frozen.ToString();
            lblExpiredValue.Text = expired.ToString();

            donutChart.Total = total;
            donutChart.Slices = new[] { ("Active", active, Ui.Green), ("Frozen", frozen, Ui.Orange), ("Expired", expired, Ui.Red) };
            donutChart.Invalidate();

            int window = Settings.GetInt("RenewalNoticeDays", 7);
            lblExpiringTitle.Text = "Upcoming Expirations (next " + window + " days)";
            var upcoming = new DataTable();
            upcoming.Columns.Add("Member ID"); upcoming.Columns.Add("Name"); upcoming.Columns.Add("Plan");
            upcoming.Columns.Add("Expires"); upcoming.Columns.Add("Days Left", typeof(int));
            foreach (DataRow r in members.Rows)
            {
                if (Db.S(r["MembershipStatus"]) != "Active") continue;
                var exp = Db.ToDate(r["ExpirationDate"]);
                int left = (exp - DateTime.Today).Days;
                if (left < 0 || left > window) continue;
                upcoming.Rows.Add(r["MemberID"], r["FullName"], r["PlanName"], Ui.Date(exp), left);
            }
            var view = upcoming.DefaultView;
            view.Sort = "[Days Left] ASC";
            dgvExpiring.DataSource = view;
            lnkViewAll.Visible = Session.Current.Can(Perm.ViewMembers);

            Ui.Bind(dgvActivity, StaffService.RecentActivity(8));
        }

        private void lnkViewAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Nav.Go(this, "members");
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void donutChart_Click(object sender, EventArgs e)
        {

        }
    }
}
