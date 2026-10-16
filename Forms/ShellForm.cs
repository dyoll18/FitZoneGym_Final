using System.ComponentModel;
using FitZoneGym.Services;

namespace FitZoneGym.Forms
{
    /// <summary>
    /// Base form for screens 2-15: dark sidebar, user strip and title bar are defined once in ShellForm.Designer.cs.
    /// Each screen inherits it (visual inheritance) and puts its own controls into contentPanel.
    /// </summary>
    public partial class ShellForm : Form
    {
        public ShellForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Size = new Size(1280, 760);
        }

        [DefaultValue("")]
        public string PageTitle
        {
            get { return titleLabel.Text; }
            set { titleLabel.Text = value; Text = "FITZONE GYM - " + value; }
        }

        /// <summary>Key of the sidebar entry to highlight (see Nav.Items).</summary>
        protected virtual string NavKey { get { return ""; } }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (Ui.IsDesignTime || Session.Current == null) return;

            whoLabel.Text = Session.Current.FullName + "  (" + Session.Current.Role + ")   |   " + DateTime.Today.ToString("MMM d, yyyy");
            foreach (var item in Nav.Items.Where(i => i.Visible()))
            {
                var b = new Button
                {
                    Text = "   " + item.Text,
                    Width = 230,
                    Height = 42,
                    TextAlign = ContentAlignment.MiddleLeft,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10f),
                    BackColor = item.Key == NavKey ? Ui.Blue : Ui.Navy,
                    Margin = new Padding(0),
                    Cursor = Cursors.Hand,
                    UseVisualStyleBackColor = false,
                };
                b.FlatAppearance.BorderSize = 0;
                b.FlatAppearance.MouseOverBackColor = Ui.NavyLight;
                string key = item.Key;
                b.Click += (s, ev) => { if (key != NavKey) Nav.Go(this, key); };
                navFlow.Controls.Add(b);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Nav.Logout(this);
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
