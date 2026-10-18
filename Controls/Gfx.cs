using System.Drawing.Drawing2D;

namespace FitZoneGym.Controls
{
    /// <summary>Small GDI+ helpers shared by the custom-painted controls.</summary>
    internal static class Gfx
    {
        public static GraphicsPath RoundRect(RectangleF r, float radius)
        {
            var p = new GraphicsPath();
            float d = Math.Max(1f, Math.Min(radius * 2f, Math.Min(r.Width, r.Height)));
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }

        public static void FillRound(Graphics g, Brush brush, RectangleF r, float radius)
        {
            using (var p = RoundRect(r, radius)) g.FillPath(brush, p);
        }
    }
}
