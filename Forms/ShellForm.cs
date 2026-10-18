
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FitZoneGym.Services;

namespace FitZoneGym.Forms
{
    public partial class ShellForm : Form
    {
        public ShellForm()
        {
            InitializeComponent();

            WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.Sizable;
            Size = new Size(1280, 760);
        }

        [DefaultValue("")]
        public string PageTitle
        {
            get => titleLabel.Text;
            set
            {
                titleLabel.Text = value;
                Text = "FITZONE GYM - " + value;
            }
        }

        protected virtual string NavKey => "";

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (Ui.IsDesignTime || Session.Current == null)
                return;

            whoLabel.Text =
                Session.Current.FullName + "  (" +
                Session.Current.Role + ")   |   " +
                DateTime.Today.ToString("MMM d, yyyy");

            foreach (var item in Nav.Items.Where(i => i.Visible()))
            {
                var button = new Button
                {
                    Text = "   " + item.Text,
                    Width = 230,
                    Height = 42,
                    TextAlign = ContentAlignment.MiddleLeft,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10f),
                    BackColor = item.Key == NavKey ? Ui.Blue : Ui.Navy,
                    Margin = Padding.Empty,
                    Cursor = Cursors.Hand,
                    UseVisualStyleBackColor = false
                };

                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseOverBackColor = Ui.NavyLight;

                string key = item.Key;
                button.Click += (s, ev) =>
                {
                    if (key != NavKey)
                        Nav.Go(this, key);
                };

                navFlow.Controls.Add(button);
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
