using System.ComponentModel;
using FitZoneGym.Controls;
using FitZoneGym.Services;

namespace FitZoneGym.Forms
{
    /// <summary>
    /// Base form for every main screen: dark sidebar with logo + navigation, header with page title and actions,
    /// and a content area. Defined once in ShellForm.Designer.cs; each screen inherits it (visual inheritance)
    /// and puts its own controls into contentPanel.
    /// </summary>
    public partial class ShellForm : Form
    {
        public ShellForm()
        {
            InitializeComponent();
        }

        [DefaultValue("")]
        public string PageTitle
        {
            get { return titleLabel.Text; }
            set { titleLabel.Text = (value ?? "").ToUpperInvariant(); Text = "FITZONE GYM - " + value; }
        }

        /// <summary>Key of the sidebar entry to highlight (see Nav.Items).</summary>
        protected virtual string NavKey { get { return ""; } }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (Ui.IsDesignTime) return;

            Theme.Apply(this);
            if (Session.Current == null) return;

            string name = Session.Current.FullName ?? "";
            whoLabel.Text = name;
            roleLabel.Text = Session.Current.Role;
            avatar.Text = Initials(name);
            dateLabel.Text = DateTime.Today.ToString("dddd, MMMM d, yyyy");

            int height = LogicalToDeviceUnits(44);
            int gap = LogicalToDeviceUnits(6);
            foreach (var item in Nav.Items.Where(i => i.Visible()))
            {
                var b = new NavButton
                {
                    Text = item.Text,
                    Active = item.Key == NavKey,
                    Height = height,
                    Margin = new Padding(0, 0, 0, gap),
                };
                string key = item.Key;
                b.Click += (s, ev) => { if (key != NavKey) Nav.Go(this, key); };
                navFlow.Controls.Add(b);
            }
            navFlow.SizeChanged += (s, ev) => FitNav();
            FitNav();
        }

        /// <summary>Keeps every sidebar button exactly as wide as the sidebar (no clipping, no overlap).</summary>
        private void FitNav()
        {
            int w = navFlow.ClientSize.Width - navFlow.Padding.Horizontal;
            if (w <= 0) return;
            foreach (Control c in navFlow.Controls) c.Width = w;
        }

        private static string Initials(string fullName)
        {
            var parts = fullName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 0) return "FZ";
            if (parts.Length == 1) return parts[0].Substring(0, 1).ToUpperInvariant();
            return (parts[0].Substring(0, 1) + parts[parts.Length - 1].Substring(0, 1)).ToUpperInvariant();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Nav.Logout(this);
        }
    }
}
