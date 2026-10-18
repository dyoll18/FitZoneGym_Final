using System.Drawing.Drawing2D;

namespace FitZoneGym.Controls
{
    /// <summary>
    /// The FITZONE logo: an orange badge with a tilted dumbbell. Drawn with GDI+ so no image file is needed
    /// (it is also used to build the application/window icon).
    /// </summary>
    public class LogoMark : Control
    {
        public LogoMark()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw, true);
            BackColor = Color.Transparent;
            TabStop = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Draw(e.Graphics, ClientRectangle);
        }

        /// <summary>Paints the logo centred in <paramref name="bounds"/>.</summary>
        public static void Draw(Graphics g, Rectangle bounds)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            float d = Math.Min(bounds.Width, bounds.Height) - 2f;
            if (d < 8f) return;
            float cx = bounds.X + bounds.Width / 2f, cy = bounds.Y + bounds.Height / 2f;
            var disc = new RectangleF(cx - d / 2f, cy - d / 2f, d, d);

            using (var br = new LinearGradientBrush(disc, Ui.AccentSoft, Ui.AccentDark, 55f))
                g.FillEllipse(br, disc);
            using (var ring = new Pen(Color.FromArgb(70, 255, 255, 255), Math.Max(1f, d / 36f)))
                g.DrawEllipse(ring, RectangleF.Inflate(disc, -d * 0.06f, -d * 0.06f));

            var state = g.Save();
            g.TranslateTransform(cx, cy);
            g.RotateTransform(-38f);
            using (var white = new SolidBrush(Color.White))
            {
                float r = d * 0.03f;
                Gfx.FillRound(g, white, new RectangleF(-d * 0.30f, -d * 0.045f, d * 0.60f, d * 0.09f), r); // bar
                Gfx.FillRound(g, white, new RectangleF(-d * 0.23f, -d * 0.20f, d * 0.10f, d * 0.40f), r);  // inner plate L
                Gfx.FillRound(g, white, new RectangleF(d * 0.13f, -d * 0.20f, d * 0.10f, d * 0.40f), r);   // inner plate R
                Gfx.FillRound(g, white, new RectangleF(-d * 0.33f, -d * 0.14f, d * 0.08f, d * 0.28f), r);  // outer plate L
                Gfx.FillRound(g, white, new RectangleF(d * 0.25f, -d * 0.14f, d * 0.08f, d * 0.28f), r);   // outer plate R
            }
            g.Restore(state);
        }
    }
}
