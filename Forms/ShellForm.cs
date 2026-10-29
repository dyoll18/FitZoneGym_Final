
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
            Size = new Size(1340, 800);

            logoLabel.Text = "";
            logoLabel.Paint += LogoLabel_Paint;
            logoutButton.Glyph = "\uE7E8";
            logoutButton.Danger = true;
            userStrip.Paint += UserStrip_Paint;
            userStrip.Resize += (s, e) => userStrip.Invalidate();
        }

        [DefaultValue("")]
        public string PageTitle
        {
            get => titleLabel.Text;
            set
            {
                titleLabel.Text = value;
                Text = "FITZONE GYM - " + value;
                headerPanel.Invalidate();
            }
        }

        protected virtual string NavKey => "";

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (Ui.IsDesignTime || Session.Current == null)
                return;

            foreach (var item in Nav.Items.Where(i => i.Visible()))
            {
                var button = new FitZoneGym.Controls.NavButton
                {
                    Text = item.Text,
                    Glyph = item.Glyph,
                    Active = item.Key == NavKey,
                    Width = navFlow.ClientSize.Width,
                    Height = 46,
                };

                string key = item.Key;
                button.Click += (s, ev) =>
                {
                    if (key != NavKey)
                        Nav.Go(this, key);
                };

                navFlow.Controls.Add(button);
            }

            // Re-colour every control of this screen (and its dynamically created children) with the FitFlow theme.
            Theme.Apply(this);
            logoutButton.BackColor = Ui.Navy;
            userStrip.Invalidate();
        }

        // ---- sidebar logo -------------------------------------------------------------------
        private void LogoLabel_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            var icon = new Rectangle(22, 24, 38, 38);
            using (var path = Theme.RoundRect(icon, 10))
            using (var br = new SolidBrush(Ui.Accent))
                g.FillPath(br, path);

            // little dumbbell glyph
            using (var white = new SolidBrush(Color.White))
            {
                g.FillRectangle(white, icon.X + 8, icon.Y + 17, 22, 4);
                g.FillRectangle(white, icon.X + 6, icon.Y + 11, 4, 16);
                g.FillRectangle(white, icon.X + 28, icon.Y + 11, 4, 16);
            }

            using (var f = new Font("Segoe UI", 17f, FontStyle.Bold))
                TextRenderer.DrawText(g, "GYMORA", f, new Point(68, 26), Color.White, TextFormatFlags.NoPadding);
        }

        // ---- top bar: date on the left, user chip on the right ------------------------------
        private void UserStrip_Paint(object sender, PaintEventArgs e)
        {
            if (Ui.IsDesignTime) return;
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            var bar = new Rectangle(18, 10, userStrip.Width - 36, userStrip.Height - 16);
            using (var path = Theme.RoundRect(bar, 14))
            using (var br = new SolidBrush(Ui.Surface))
                g.FillPath(br, path);

            using (var f = new Font("Segoe UI", 10f))
                TextRenderer.DrawText(g, DateTime.Today.ToString("dddd, MMMM d, yyyy"), f,
                    new Rectangle(bar.X + 20, bar.Y, 400, bar.Height), Ui.Muted, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

            var s = Session.Current;
            if (s == null) return;

            string name = s.FullName ?? "";
            string role = Convert.ToString(s.Role) ?? "";
            int right = bar.Right - 18;

            using (var fn = new Font("Segoe UI", 10f, FontStyle.Bold))
            using (var fr = new Font("Segoe UI", 8.5f))
            {
                int w = Math.Max(TextRenderer.MeasureText(name, fn).Width, TextRenderer.MeasureText(role, fr).Width) + 6;
                var textRect = new Rectangle(right - w, bar.Y + 6, w, bar.Height - 12);
                TextRenderer.DrawText(g, name, fn, new Rectangle(textRect.X, textRect.Y, w, textRect.Height / 2 + 5), Ui.Text, TextFormatFlags.Left | TextFormatFlags.Bottom | TextFormatFlags.NoPadding);
                TextRenderer.DrawText(g, role, fr, new Rectangle(textRect.X, textRect.Y + textRect.Height / 2 + 2, w, textRect.Height / 2), Ui.Muted, TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.NoPadding);

                int d = 38;
                var avatar = new Rectangle(textRect.X - d - 12, bar.Y + (bar.Height - d) / 2, d, d);
                using (var br = new System.Drawing.Drawing2D.LinearGradientBrush(avatar, Color.FromArgb(255, 150, 60), Ui.Accent, 45f))
                    g.FillEllipse(br, avatar);
                string initial = name.Length > 0 ? name.Substring(0, 1).ToUpperInvariant() : "?";
                using (var fi = new Font("Segoe UI", 12f, FontStyle.Bold))
                    TextRenderer.DrawText(g, initial, fi, avatar, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
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
