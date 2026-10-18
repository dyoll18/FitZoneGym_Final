using System.Drawing.Drawing2D;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FitZoneGym.Controls;

namespace FitZoneGym
{
    /// <summary>
    /// Applies the dark FITZONE theme to a form and every control on it. Designers only describe structure; the look
    /// comes from here, driven by each control's Tag ("card", "primary", "h1", "caption", ...).
    /// </summary>
    public static class Theme
    {
        private static readonly ConditionalWeakTable<Control, object> Marked = new ConditionalWeakTable<Control, object>();
        private static readonly object Mark = new object();
        private static readonly PropertyInfo DoubleBufferedProp =
            typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
        private static Icon _icon;

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attribute, ref int value, int size);

        /// <summary>Window / taskbar icon, drawn from the logo.</summary>
        public static Icon AppIcon
        {
            get
            {
                if (_icon == null)
                {
                    try
                    {
                        using (var bmp = new Bitmap(64, 64))
                        {
                            using (var g = Graphics.FromImage(bmp))
                            {
                                g.Clear(Color.Transparent);
                                LogoMark.Draw(g, new Rectangle(0, 0, 64, 64));
                            }
                            _icon = Icon.FromHandle(bmp.GetHicon());
                        }
                    }
                    catch { }
                }
                return _icon;
            }
        }

        /// <summary>Themes <paramref name="form"/>. Dialogs get the lighter "surface" background.</summary>
        public static void Apply(Form form, bool dialog = false)
        {
            if (Ui.IsDesignTime) return;
            form.SuspendLayout();
            form.BackColor = dialog ? Ui.Surface : Ui.Bg;
            form.ForeColor = Ui.Text;
            var icon = AppIcon;
            if (icon != null) form.Icon = icon;
            DarkTitleBar(form);
            Walk(form);
            form.ResumeLayout(true);
        }

        /// <summary>Asks Windows 10/11 for a dark title bar so the window frame matches the app.</summary>
        public static void DarkTitleBar(Form f)
        {
            void Set()
            {
                try
                {
                    int on = 1;
                    if (DwmSetWindowAttribute(f.Handle, 20, ref on, sizeof(int)) != 0)
                        DwmSetWindowAttribute(f.Handle, 19, ref on, sizeof(int));
                }
                catch { }
            }
            if (f.IsHandleCreated) Set(); else f.HandleCreated += (s, e) => Set();
        }

        private static void Walk(Control c)
        {
            Style(c);
            foreach (Control child in c.Controls) Walk(child);
        }

        private static void Style(Control c)
        {
            string tag = c.Tag as string ?? "";

            // custom-painted controls style themselves
            if (c is NavButton || c is GradientPanel || c is LogoMark || c is DonutChart) return;

            if (c is DataGridView grid) { Ui.StyleGrid(grid); Buffer(grid); return; }
            if (c is Button button) { StyleButton(button, tag); return; }
            if (c is TextBox box)
            {
                box.BackColor = Ui.InputBg; box.ForeColor = Ui.Text; box.BorderStyle = BorderStyle.FixedSingle;
                return;
            }
            if (c is ComboBox combo)
            {
                combo.FlatStyle = FlatStyle.Flat; combo.BackColor = Ui.InputBg; combo.ForeColor = Ui.Text;
                return;
            }
            if (c is NumericUpDown num)
            {
                num.BackColor = Ui.InputBg; num.ForeColor = Ui.Text; num.BorderStyle = BorderStyle.FixedSingle;
                return;
            }
            if (c is DateTimePicker date)
            {
                date.CalendarMonthBackground = Ui.Surface2;
                date.CalendarForeColor = Ui.Text;
                date.CalendarTitleBackColor = Ui.Accent;
                date.CalendarTitleForeColor = Color.White;
                date.CalendarTrailingForeColor = Ui.Muted;
                return;
            }
            if (c is CheckBox || c is RadioButton) { c.ForeColor = Ui.Text; return; }
            if (c is LinkLabel link)
            {
                link.LinkColor = Ui.AccentSoft; link.ActiveLinkColor = Ui.Accent; link.VisitedLinkColor = Ui.AccentSoft;
                link.LinkBehavior = LinkBehavior.HoverUnderline;
                link.Font = Ui.Bold(9.5f);
                return;
            }
            if (c is Label label) { StyleLabel(label, tag); return; }
            if (c is Panel) StylePanel(c, tag);
        }

        // ---- buttons ------------------------------------------------------------------------
        public static void StyleButton(Button b, string kind)
        {
            Color back, fore = Color.White, border, hover, down;
            switch (kind)
            {
                case "primary":
                    back = Ui.Accent; border = Ui.Accent; hover = Ui.AccentSoft; down = Ui.AccentDark; break;
                case "success":
                    back = Color.FromArgb(22, 163, 74); border = back; hover = Color.FromArgb(34, 197, 94); down = Color.FromArgb(21, 128, 61); break;
                case "danger":
                    back = Color.FromArgb(200, 35, 45); border = back; hover = Color.FromArgb(226, 60, 70); down = Color.FromArgb(160, 25, 35); break;
                case "logout":
                    back = Ui.Navy; fore = Color.FromArgb(255, 124, 112); border = Color.FromArgb(92, 38, 38);
                    hover = Color.FromArgb(58, 24, 26); down = Color.FromArgb(44, 18, 20); break;
                default:
                    back = Ui.Surface2; fore = Ui.Text; border = Ui.Border; hover = Color.FromArgb(50, 50, 59); down = Color.FromArgb(28, 28, 34); break;
            }

            b.FlatStyle = FlatStyle.Flat;
            b.UseVisualStyleBackColor = false;
            b.Cursor = Cursors.Hand;
            b.BackColor = back;
            b.ForeColor = fore;
            b.FlatAppearance.BorderSize = 1;
            b.FlatAppearance.BorderColor = border;
            b.FlatAppearance.MouseOverBackColor = hover;
            b.FlatAppearance.MouseDownBackColor = down;
            if (!b.Font.Bold) b.Font = Ui.Bold(9.5f);

            if (!b.Enabled)
            {
                b.BackColor = Ui.Surface2;
                b.ForeColor = Ui.Muted;
                b.FlatAppearance.BorderColor = Ui.Border;
                b.Cursor = Cursors.Default;
            }

            if (!Marked.TryGetValue(b, out _))
            {
                Marked.Add(b, Mark);
                b.EnabledChanged += (s, e) => StyleButton((Button)s, kind);
            }
        }

        // ---- labels -------------------------------------------------------------------------
        private static void StyleLabel(Label l, string tag)
        {
            switch (tag)
            {
                case "h1": l.Font = Ui.Display(22f); l.ForeColor = Ui.Text; break;
                case "h2": l.Font = Ui.Display(12.5f); l.ForeColor = Ui.Text; break;
                case "value": l.Font = Ui.Display(30f); l.ForeColor = Ui.Text; break;
                case "money": l.Font = Ui.Display(14f); l.ForeColor = Ui.Text; break;
                case "caption": l.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold); l.ForeColor = Ui.Muted; break;
                case "muted": l.ForeColor = Ui.Muted; break;
                case "accent": l.Font = Ui.Bold(9.5f); l.ForeColor = Ui.Accent; break;
                case "error": l.ForeColor = Color.FromArgb(255, 107, 107); break;
                case "summary": l.Font = Ui.Bold(10f); l.ForeColor = Ui.Text; break;
                case "brand": l.Font = Ui.Display(40f); l.ForeColor = Color.White; break;
                case "brandsub": l.Font = Ui.Display(16f); l.ForeColor = Ui.Accent; break;
                case "tagline": l.Font = Ui.Bold(10.5f); l.ForeColor = Color.FromArgb(214, 214, 222); break;
                case "navbrand": l.Font = Ui.Display(18f); l.ForeColor = Color.White; break;
                case "navsub": l.Font = Ui.Bold(7.5f); l.ForeColor = Ui.Accent; break;
                case "who": l.Font = Ui.Bold(9.5f); l.ForeColor = Color.White; break;
                case "role": l.Font = new Font("Segoe UI", 8.5f); l.ForeColor = Ui.Muted; break;
                case "date": l.Font = new Font("Segoe UI", 9f); l.ForeColor = Ui.Muted; break;
                case "avatar":
                    l.Font = Ui.Bold(10f); l.ForeColor = Color.White; l.BackColor = Ui.Accent;
                    using (var gp = new GraphicsPath())
                    {
                        gp.AddEllipse(0, 0, Math.Max(2, l.Width - 1), Math.Max(2, l.Height - 1));
                        l.Region = new Region(gp);
                    }
                    break;
            }
        }

        // ---- panels -------------------------------------------------------------------------
        private static void StylePanel(Control p, string tag)
        {
            switch (tag)
            {
                case "stripe": return;                       // colour is set in code (e.g. dashboard stat cards)
                case "card":
                case "stat":
                    p.BackColor = Ui.Surface;
                    if (!(p is CardPanel) && !Marked.TryGetValue(p, out _))
                    {
                        Marked.Add(p, Mark);
                        p.Paint += CardPaint;
                        p.SizeChanged += (s, e) => ((Control)s).Invalidate();
                    }
                    break;
                case "surface": p.BackColor = Ui.Surface; break;
                case "sidebar": p.BackColor = Ui.Navy; break;
                case "page": p.BackColor = Ui.Bg; break;
                case "line": p.BackColor = Ui.Border; break;
                case "accentline": p.BackColor = Ui.Accent; break;
                default: p.BackColor = Color.Transparent; break;
            }
        }

        private static void CardPaint(object sender, PaintEventArgs e)
        {
            var c = (Control)sender;
            using (var pen = new Pen(Ui.Border))
                e.Graphics.DrawRectangle(pen, 0, 0, c.Width - 1, c.Height - 1);
        }

        private static void Buffer(Control c)
        {
            try { if (DoubleBufferedProp != null) DoubleBufferedProp.SetValue(c, true); } catch { }
        }
    }
}
