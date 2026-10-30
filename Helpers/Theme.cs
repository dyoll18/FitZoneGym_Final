using System.Drawing.Drawing2D;

namespace FitZoneGym
{
    /// <summary>
    /// FitFlow dark / orange look. <see cref="Apply"/> walks a form's controls and re-colours everything that the
    /// Designer files still paint in the old navy/blue/white palette, so every screen (except Login) matches.
    /// </summary>
    public static class Theme
    {
        // Old palette literals still found in the Designer files.
        private static readonly Color OldText = Color.FromArgb(31, 41, 55);
        private static readonly Color OldNavy = Color.FromArgb(15, 35, 66);
        private static readonly Color OldBlue = Color.FromArgb(30, 111, 240);
        private static readonly Color OldBg = Color.FromArgb(243, 246, 251);
        private static readonly Color OldMuted = Color.FromArgb(107, 114, 128);
        private static readonly Color OldBorder = Color.FromArgb(214, 221, 232);
        private static readonly Color OldGreen = Color.FromArgb(22, 163, 74);
        private static readonly Color OldAmber = Color.FromArgb(245, 158, 11);
        private static readonly Color OldRed = Color.FromArgb(220, 38, 38);

        private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<Control, object> _rounded = new();

        public const int CardRadius = 14;
        public const int ButtonRadius = 8;

        public static void Apply(Control root)
        {
            if (root == null) return;
            if (root is Form f)
            {
                f.BackgroundImage = null;
                f.BackColor = Ui.Bg;
                f.ForeColor = Ui.Text;
            }
            Walk(root);
        }

        private static void Walk(Control c)
        {
            Style(c);
            foreach (Control child in c.Controls) Walk(child);
        }

        private static bool Same(Color a, Color b) => a.ToArgb() == b.ToArgb();

        private static Color MapFore(Color c)
        {
            if (Same(c, OldText) || Same(c, OldNavy) || Same(c, Color.Black) || Same(c, Color.Transparent) || Same(c, SystemColors.ControlText) || Same(c, SystemColors.WindowText)) return Ui.Text;
            if (Same(c, OldMuted)) return Ui.Muted;
            if (Same(c, OldBlue)) return Ui.Accent;
            if (Same(c, OldGreen)) return Ui.Green;
            if (Same(c, OldAmber)) return Ui.Orange;
            if (Same(c, OldRed)) return Ui.Red;
            return c;
        }

        private static Color MapBack(Color c)
        {
            if (Same(c, Color.White) || Same(c, SystemColors.Window) || Same(c, SystemColors.Control)) return Ui.Surface;
            if (Same(c, OldBg)) return Ui.Bg;
            if (Same(c, OldNavy)) return Ui.Navy;
            if (Same(c, OldBlue) || Same(c, Color.FromArgb(255, 128, 0))) return Ui.Accent;
            if (Same(c, OldGreen)) return Ui.Green;
            if (Same(c, OldAmber)) return Ui.Orange;
            if (Same(c, OldRed)) return Ui.Red;
            if (Same(c, Color.Black)) return Ui.Surface;
            return c;
        }

        private static void Style(Control c)
        {
            switch (c)
            {
                case TextBoxBase tb:
                    tb.BackColor = Ui.InputBg; tb.ForeColor = Ui.Text;
                    return;
                case ComboBox cb:
                    cb.BackColor = Ui.InputBg; cb.ForeColor = Ui.Text; cb.FlatStyle = FlatStyle.Flat;
                    return;
                case NumericUpDown nu:
                    nu.BackColor = Ui.InputBg; nu.ForeColor = Ui.Text;
                    return;
                case DateTimePicker dp:
                    dp.CalendarMonthBackground = Ui.InputBg; dp.CalendarForeColor = Ui.Text;
                    dp.CalendarTitleBackColor = Ui.Accent; dp.CalendarTitleForeColor = Color.White;
                    dp.CalendarTrailingForeColor = Ui.Muted;
                    return;
                case DataGridView g:
                    Ui.ThemeGrid(g);
                    return;
                case TabControl tc:
                    StyleTabs(tc);
                    return;
                case Button b:
                    StyleButton(b);
                    return;
                case LinkLabel ll:
                    ll.LinkColor = Ui.Accent; ll.ActiveLinkColor = Ui.AccentHover; ll.VisitedLinkColor = Ui.Accent;
                    ll.BackColor = Color.Transparent;
                    return;
                case RadioButton rb:
                    rb.ForeColor = Ui.Text;
                    if (rb.Appearance == Appearance.Button) { rb.FlatAppearance.BorderColor = Ui.Border; Round(rb, ButtonRadius); }
                    return;
                case CheckBox _:
                    c.ForeColor = Ui.Text;
                    return;
                case Label l:
                    l.ForeColor = MapFore(l.ForeColor);
                    if (!Same(l.BackColor, Color.Transparent)) l.BackColor = MapBack(l.BackColor);
                    return;
            }

            if (c is PictureBox) return;
            if (c.GetType().FullName == "FitZoneGym.Controls.DonutChart") { c.BackColor = Ui.Surface; return; }

            // Containers: panels, flow/table layouts, tab pages, group boxes, user controls.
            Color back = c.BackColor;
            if (!Same(back, Color.Transparent))
            {
                if (c.Name == "contentPanel" || c.Name == "rightPanel") c.BackColor = Ui.Bg;
                else c.BackColor = MapBack(back);
            }
            c.ForeColor = MapFore(c.ForeColor);

            if (c.GetType() == typeof(Panel) && c.Parent != null && IsCard(c)) Round(c, CardRadius);
        }

        /// <summary>A "card" is a surface/accent coloured panel that sits directly on the page background.</summary>
        private static bool IsCard(Control p)
        {
            if (p.Name == "sidebarPanel" || p.Name == "headerPanel" || p.Name == "userStrip" || p.Name == "rightPanel" || p.Name == "contentPanel") return false;
            if (p.Parent is TabPage) return false;
            bool onPage = Same(p.Parent.BackColor, Ui.Bg);
            bool filled = Same(p.BackColor, Ui.Surface) || Same(p.BackColor, Ui.Accent) || Same(p.BackColor, Ui.Green)
                          || Same(p.BackColor, Ui.Orange) || Same(p.BackColor, Ui.Red);
            return onPage && filled && p.Width > 60;
        }

        private static void StyleButton(Button b)
        {
            if (b is Controls.NavButton) return;
            Color back = b.BackColor;
            bool accent = Same(back, OldBlue) || Same(back, Ui.Accent) || Same(back, Color.FromArgb(255, 128, 0));
            bool danger = Same(back, OldRed) || Same(back, Ui.Red) || Same(back, Color.FromArgb(140, 30, 40));
            bool success = Same(back, OldGreen) || Same(back, Ui.Green);
            bool secondary = !accent && !danger && !success;

            Color fill = accent ? Ui.Accent : danger ? Ui.Red : success ? Ui.Green : Ui.InputBg;
            b.UseVisualStyleBackColor = false;
            b.FlatStyle = FlatStyle.Flat;
            b.BackColor = fill;
            b.ForeColor = secondary ? Ui.Text : Color.White;
            b.FlatAppearance.BorderSize = secondary ? 1 : 0;
            b.FlatAppearance.BorderColor = secondary ? Ui.Border : fill;
            b.FlatAppearance.MouseOverBackColor = accent ? Ui.AccentHover : secondary ? Ui.NavyLight : Lighten(fill);
            b.FlatAppearance.MouseDownBackColor = fill;
            b.Cursor = Cursors.Hand;
            Round(b, ButtonRadius);
        }

        private static Color Lighten(Color c) => Color.FromArgb(Math.Min(255, c.R + 28), Math.Min(255, c.G + 28), Math.Min(255, c.B + 28));

        // ---- tabs ---------------------------------------------------------------------------
        private static void StyleTabs(TabControl tc)
        {
            tc.DrawMode = TabDrawMode.OwnerDrawFixed;
            tc.SizeMode = TabSizeMode.Fixed;
            tc.ItemSize = new Size(150, 36);
            tc.Padding = new Point(14, 6);
            tc.BackColor = Ui.Bg;
            tc.DrawItem -= DrawTab;
            tc.DrawItem += DrawTab;
            foreach (TabPage page in tc.TabPages)
            {
                page.UseVisualStyleBackColor = false;
                page.BackColor = Ui.Bg;
                page.ForeColor = Ui.Text;
            }
        }

        private static void DrawTab(object sender, DrawItemEventArgs e)
        {
            var tc = (TabControl)sender;
            bool selected = e.Index == tc.SelectedIndex;
            var r = e.Bounds;
            using (var bg = new SolidBrush(Ui.Bg)) e.Graphics.FillRectangle(bg, r);
            var pill = new Rectangle(r.X + 2, r.Y + 3, r.Width - 6, r.Height - 6);
            if (selected)
                using (var path = RoundRect(pill, ButtonRadius))
                using (var br = new SolidBrush(Ui.Accent))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.FillPath(br, path);
                }
            TextRenderer.DrawText(e.Graphics, tc.TabPages[e.Index].Text, Ui.Bold(9.5f), pill,
                selected ? Color.White : Ui.Muted, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        // ---- rounded corners ----------------------------------------------------------------
        public static GraphicsPath RoundRect(Rectangle r, int radius)
        {
            int d = radius * 2;
            var p = new GraphicsPath();
            if (r.Width <= d || r.Height <= d) { p.AddRectangle(r); return p; }
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }

        /// <summary>Clips a control to a rounded rectangle and keeps it rounded when resized.</summary>
        public static void Round(Control c, int radius)
        {
            if (!_rounded.TryGetValue(c, out _))
            {
                _rounded.Add(c, new object());
                c.Resize += (s, e) => Refresh(c, radius);
            }
            Refresh(c, radius);
        }

        private static void Refresh(Control c, int radius)
        {
            if (c.Width < 4 || c.Height < 4) return;
            using (var path = RoundRect(new Rectangle(0, 0, c.Width, c.Height), radius))
            {
                var old = c.Region;
                c.Region = new Region(path);
                old?.Dispose();
            }
        }
    }
}
