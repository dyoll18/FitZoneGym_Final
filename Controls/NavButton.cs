using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace FitZoneGym.Controls
{
    /// <summary>Sidebar item: icon glyph + label. Active item is a solid orange block like the FitFlow dashboard.</summary>
    public class NavButton : Button
    {
        private bool _hover;
        public string Glyph { get; set; } = "";
        public bool Active { get; set; }
        public bool Danger { get; set; }

        private static readonly bool HasIcons = DetectIcons();
        private static bool DetectIcons()
        {
            try
            {
                using var fc = new InstalledFontCollection();
                return fc.Families.Any(f => f.Name == "Segoe MDL2 Assets" || f.Name == "Segoe Fluent Icons");
            }
            catch { return false; }
        }
        private static string IconFont()
        {
            using var fc = new InstalledFontCollection();
            return fc.Families.Any(f => f.Name == "Segoe Fluent Icons") ? "Segoe Fluent Icons" : "Segoe MDL2 Assets";
        }

        public NavButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            Cursor = Cursors.Hand;
            Height = 46;
            Margin = Padding.Empty;
            TabStop = false;
        }

        protected override void OnMouseEnter(EventArgs e) { _hover = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _hover = false; Invalidate(); base.OnMouseLeave(e); }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            Color bg = Active ? Ui.Accent : _hover ? (Danger ? Color.FromArgb(60, 239, 68, 68).Blend(Ui.Navy) : Ui.NavyLight) : Ui.Navy;
            Color fg = Active ? Color.White : Danger && _hover ? Ui.Red : _hover ? Ui.Text : Ui.Muted;
            using (var br = new SolidBrush(bg)) g.FillRectangle(br, ClientRectangle);

            int x = 22;
            if (HasIcons && Glyph.Length > 0)
            {
                using var f = new Font(IconFont(), 13f);
                TextRenderer.DrawText(g, Glyph, f, new Rectangle(x - 4, 0, 28, Height), fg, TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
                x += 34;
            }
            using (var f = new Font("Segoe UI", 10f, Active ? FontStyle.Bold : FontStyle.Regular))
                TextRenderer.DrawText(g, Text.Trim(), f, new Rectangle(x, 0, Width - x, Height), fg, TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding | TextFormatFlags.EndEllipsis);
        }
    }
}
