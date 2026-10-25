namespace FitZoneGym.Controls
{
    /// <summary>Simple GDI+ donut chart (no external chart library needed).</summary>
    public class DonutChart : Control
    {
        [System.ComponentModel.Browsable(false), System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int Total { get; set; }
        [System.ComponentModel.Browsable(false), System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public (string Label, int Value, Color Color)[] Slices { get; set; } = Array.Empty<(string, int, Color)>();

        public DonutChart() { DoubleBuffered = true; BackColor = Color.White; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int size = Math.Min(Width, Height) - 20;
            if (size < 40) return;
            var rect = new Rectangle(10, (Height - size) / 2, size, size);
            int sum = Slices.Sum(s => s.Value);
            float start = -90f;
            using (var track = new Pen(Color.FromArgb(230, 234, 242), 22))
                g.DrawEllipse(track, rect.X + 11, rect.Y + 11, rect.Width - 22, rect.Height - 22);
            if (sum > 0)
                foreach (var s in Slices)
                {
                    if (s.Value <= 0) continue;
                    float sweep = 360f * s.Value / sum;
                    using var pen = new Pen(s.Color, 22);
                    g.DrawArc(pen, rect.X + 11, rect.Y + 11, rect.Width - 22, rect.Height - 22, start, Math.Max(sweep - 1.5f, 0.5f));
                    start += sweep;
                }
            using var big = new Font("Segoe UI", 20f, FontStyle.Bold);
            using var small = new Font("Segoe UI", 8.5f);
            var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            g.DrawString(Total.ToString(), big, new SolidBrush(Ui.Navy), new RectangleF(rect.X, rect.Y + rect.Height / 2f - 20, rect.Width, 30), sf);
            g.DrawString("Total Members", small, new SolidBrush(Ui.Muted), new RectangleF(rect.X, rect.Y + rect.Height / 2f + 8, rect.Width, 20), sf);

            // legend
            int lx = rect.Right + 6, ly = rect.Y + 67;
            foreach (var s in Slices)
            {
                using (var br = new SolidBrush(s.Color)) g.FillEllipse(br, lx, ly + 3, 10, 10);
                g.DrawString(s.Label + ": " + s.Value + (Total > 0 ? " (" + (100 * s.Value / Total) + "%)" : ""), Font, new SolidBrush(Ui.Text), lx + 16, ly);
                ly += 26;
            }
        }
    }
}
