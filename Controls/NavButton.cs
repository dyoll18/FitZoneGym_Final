using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace FitZoneGym.Controls
{
    /// <summary>Sidebar navigation entry: rounded highlight, orange marker for the current page, hover state.</summary>
    public class NavButton : Button
    {
        private bool _hover;

        [DefaultValue(false)]
        public bool Active { get; set; }

        public NavButton()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
            UseVisualStyleBackColor = false;
        }

        protected override void OnMouseEnter(EventArgs e) { _hover = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _hover = false; Invalidate(); base.OnMouseLeave(e); }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            float s = DeviceDpi / 96f;
            g.Clear(Ui.Navy);

            var body = new RectangleF(0, 0, Width - 1, Height - 1);
            Color fore;
            if (Active)
            {
                using (var br = new SolidBrush(Color.FromArgb(52, 27, 16))) Gfx.FillRound(g, br, body, 9f * s);
                using (var bar = new SolidBrush(Ui.Accent))
                    Gfx.FillRound(g, bar, new RectangleF(0, Height * 0.2f, 4f * s, Height * 0.6f), 2f * s);
                fore = Color.White;
            }
            else if (_hover)
            {
                using (var br = new SolidBrush(Ui.NavyLight)) Gfx.FillRound(g, br, body, 9f * s);
                fore = Ui.Text;
            }
            else
            {
                fore = Color.FromArgb(178, 178, 190);
            }

            using (var f = new Font(Font.FontFamily, Font.Size, Active ? FontStyle.Bold : FontStyle.Regular))
            {
                var textRect = new Rectangle((int)(20 * s), 0, Math.Max(10, Width - (int)(30 * s)), Height);
                TextRenderer.DrawText(g, Text, f, textRect, fore,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix);
            }
        }
    }
}
