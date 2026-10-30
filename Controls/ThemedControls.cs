using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace FitZoneGym.Controls
{
    public enum ButtonKind { Secondary, Primary, Success, Danger }

    /// <summary>Rounded flat button in the FitFlow style. Pick the look with <see cref="Kind"/> in the Designer.</summary>
    public class ThemedButton : Button
    {
        private ButtonKind _kind = ButtonKind.Secondary;

        public ThemedButton()
        {
            FlatStyle = FlatStyle.Flat;
            UseVisualStyleBackColor = false;
            Cursor = Cursors.Hand;
            ApplyKind();
        }

        [DefaultValue(ButtonKind.Secondary), Category("Appearance"), Description("Primary = orange, Success = green, Danger = red, Secondary = dark grey.")]
        public ButtonKind Kind { get => _kind; set { _kind = value; ApplyKind(); } }

        private int _radius = Theme.ButtonRadius;
        [DefaultValue(Theme.ButtonRadius), Category("Appearance")]
        public int CornerRadius { get => _radius; set { _radius = value; UpdateRegion(); } }

        private void ApplyKind()
        {
            Color fill, hover, border; Color fore = Color.White;
            switch (_kind)
            {
                case ButtonKind.Primary: fill = Ui.Accent; hover = Ui.AccentHover; border = Ui.Accent; break;
                case ButtonKind.Success: fill = Ui.Green; hover = Color.FromArgb(74, 222, 128); border = Ui.Green; break;
                case ButtonKind.Danger: fill = Ui.Red; hover = Color.FromArgb(248, 113, 113); border = Ui.Red; break;
                default: fill = Ui.InputBg; hover = Ui.NavyLight; border = Ui.Border; fore = Ui.Text; break;
            }
            BackColor = fill;
            ForeColor = fore;
            FlatAppearance.BorderSize = _kind == ButtonKind.Secondary ? 1 : 0;
            FlatAppearance.BorderColor = border;
            FlatAppearance.MouseOverBackColor = hover;
            FlatAppearance.MouseDownBackColor = fill;
        }

        protected override void OnResize(EventArgs e) { base.OnResize(e); UpdateRegion(); }
        protected override void OnHandleCreated(EventArgs e) { base.OnHandleCreated(e); UpdateRegion(); }

        private void UpdateRegion()
        {
            if (Width < 4 || Height < 4) return;
            using (var path = Theme.RoundRect(new Rectangle(0, 0, Width, Height), _radius))
            {
                var old = Region;
                Region = new Region(path);
                old?.Dispose();
            }
        }
    }

    /// <summary>Panel with optional rounded corners and an optional coloured accent bar on its left edge.</summary>
    public class ThemedPanel : Panel
    {
        private int _radius;
        private Color _accent = Color.Empty;

        public ThemedPanel() { DoubleBuffered = true; }

        [DefaultValue(0), Category("Appearance")]
        public int CornerRadius { get => _radius; set { _radius = value; UpdateRegion(); } }

        [Category("Appearance"), Description("Colour of the vertical bar drawn on the left edge (Empty = none).")]
        public Color AccentBar { get => _accent; set { _accent = value; Invalidate(); } }
        private bool ShouldSerializeAccentBar() => !_accent.IsEmpty;
        private void ResetAccentBar() => AccentBar = Color.Empty;

        protected override void OnResize(EventArgs eventargs) { base.OnResize(eventargs); UpdateRegion(); }
        protected override void OnHandleCreated(EventArgs e) { base.OnHandleCreated(e); UpdateRegion(); }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (_accent.IsEmpty) return;
            using (var br = new SolidBrush(_accent))
                e.Graphics.FillRectangle(br, 0, 20, 5, Math.Max(10, Height - 40));
        }

        private void UpdateRegion()
        {
            if (_radius <= 0)
            {
                if (Region != null) { Region.Dispose(); Region = null; }
                return;
            }
            if (Width < 4 || Height < 4) return;
            using (var path = Theme.RoundRect(new Rectangle(0, 0, Width, Height), _radius))
            {
                var old = Region;
                Region = new Region(path);
                old?.Dispose();
            }
        }
    }

    /// <summary>DataGridView that already has the FitFlow dark table look (also in the Designer).</summary>
    public class ThemedGrid : DataGridView
    {
        public ThemedGrid() { Ui.InitGrid(this); }
    }

    /// <summary>Tab control with FitFlow pill-style tabs.</summary>
    public class ThemedTabControl : TabControl
    {
        public ThemedTabControl()
        {
            DrawMode = TabDrawMode.OwnerDrawFixed;
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(170, 38);
            Padding = new Point(14, 6);
            BackColor = Ui.Bg;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            bool selected = e.Index == SelectedIndex;
            var r = e.Bounds;
            using (var bg = new SolidBrush(Ui.Bg)) e.Graphics.FillRectangle(bg, r);
            var pill = new Rectangle(r.X + 2, r.Y + 3, r.Width - 6, r.Height - 6);
            if (selected)
                using (var path = Theme.RoundRect(pill, Theme.ButtonRadius))
                using (var br = new SolidBrush(Ui.Accent))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.FillPath(br, path);
                }
            TextRenderer.DrawText(e.Graphics, TabPages[e.Index].Text, Ui.Bold(9.5f), pill,
                selected ? Color.White : Ui.Muted, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x000F && TabCount > 0 && IsHandleCreated)   // WM_PAINT
            {
                using (var g = Graphics.FromHwnd(Handle))
                using (var br = new SolidBrush(Ui.Bg))
                {
                    for (int i = 0; i < TabCount; i++) g.ExcludeClip(GetTabRect(i));
                    g.ExcludeClip(DisplayRectangle);
                    g.FillRectangle(br, 0, 0, Width, Height);
                }
            }
        }
    }
    
}
