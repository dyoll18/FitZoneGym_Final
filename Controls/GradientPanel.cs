using System.Drawing.Drawing2D;

namespace FitZoneGym.Controls
{
    /// <summary>Dark brand panel with a fiery gradient and diagonal "speed" stripes (used on the login screen).</summary>
    public class GradientPanel : Panel
    {
        public GradientPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            var r = ClientRectangle;
            if (r.Width < 2 || r.Height < 2) return;
            float s = DeviceDpi / 96f;

            using (var br = new LinearGradientBrush(r, Color.FromArgb(46, 18, 6), Color.FromArgb(9, 9, 11), 70f))
                g.FillRectangle(br, r);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var pen = new Pen(Color.FromArgb(16, 255, 94, 26), 28f * s))
            {
                int step = (int)(86 * s);
                for (int x = -r.Height; x < r.Width; x += step)
                    g.DrawLine(pen, x, r.Height, x + r.Height, 0);
            }
            using (var br = new SolidBrush(Ui.Accent))
                g.FillRectangle(br, 0, r.Height - (int)(6 * s), r.Width, (int)(6 * s));
        }
    }
}
