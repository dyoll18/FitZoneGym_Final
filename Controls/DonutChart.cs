namespace FitZoneGym.Controls
{
    /// <summary>
    /// Simple GDI+ donut chart (no external chart library needed). The legend sits to the right of the ring when
    /// there is room and drops underneath it when the card is narrow, so nothing is ever clipped or overlapped.
    /// </summary>
    public class DonutChart : Control
    {
        [System.ComponentModel.Browsable(false), System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int Total { get; set; }
        [System.ComponentModel.Browsable(false), System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public (string Label, int Value, Color Color)[] Slices { get; set; } = Array.Empty<(string, int, Color)>();

        public DonutChart()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Ui.Surface;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            float s = DeviceDpi / 96f;

            var labels = new string[Slices.Length];
            float legendW = 0f;
            for (int i = 0; i < Slices.Length; i++)
            {
                var sl = Slices[i];
                labels[i] = sl.Label + "   " + sl.Value + (Total > 0 ? "  (" + (100 * sl.Value / Total) + "%)" : "");
                legendW = Math.Max(legendW, g.MeasureString(labels[i], Font).Width);
            }
            legendW += 24f * s;
            float lineH = 26f * s;
            float legendH = Slices.Length * lineH;
            float gap = 18f * s;
            float avail = Width - legendW - gap - 8f * s;

            float size, ringX, ringY, lx, ly;
            if (avail >= 96f * s)
            {
                size = Math.Min(Height - 16f * s, avail);
                ringX = 8f * s;
                ringY = (Height - size) / 2f;
                lx = ringX + size + gap;
                ly = (Height - legendH) / 2f;
            }
            else
            {
                size = Math.Min(Width - 16f * s, Height - legendH - 20f * s);
                ringX = (Width - size) / 2f;
                ringY = 8f * s;
                lx = Math.Max(8f * s, (Width - legendW) / 2f);
                ly = ringY + size + 10f * s;
            }
            if (size < 48f * s) return;

            float thick = Math.Max(10f, size * 0.13f);
            var rect = new RectangleF(ringX + thick / 2f, ringY + thick / 2f, size - thick, size - thick);
            int sum = Slices.Sum(x => x.Value);
            float start = -90f;

            using (var track = new Pen(Ui.Surface2, thick))
                g.DrawEllipse(track, rect);
            if (sum > 0)
                foreach (var sl in Slices)
                {
                    if (sl.Value <= 0) continue;
                    float sweep = 360f * sl.Value / sum;
                    using (var pen = new Pen(sl.Color, thick))
                        g.DrawArc(pen, rect, start, Math.Max(sweep - 1.5f, 0.5f));
                    start += sweep;
                }

            var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            using (var big = Ui.Display(Math.Min(30f, Math.Max(16f, size / (7f * s)))))
            using (var small = new Font("Segoe UI", 8.5f))
            using (var white = new SolidBrush(Ui.Text))
            using (var muted = new SolidBrush(Ui.Muted))
            {
                float cy = ringY + size / 2f;
                g.DrawString(Total.ToString(), big, white, new RectangleF(ringX, cy - 26f * s, size, 36f * s), sf);
                g.DrawString("MEMBERS", small, muted, new RectangleF(ringX, cy + 8f * s, size, 20f * s), sf);
            }
            sf.Dispose();

            using (var txt = new SolidBrush(Ui.Text))
                for (int i = 0; i < Slices.Length; i++)
                {
                    float y = ly + i * lineH;
                    using (var br = new SolidBrush(Slices[i].Color))
                        g.FillEllipse(br, lx, y + 5f * s, 11f * s, 11f * s);
                    g.DrawString(labels[i], Font, txt, lx + 19f * s, y);
                }
        }
    }
}
