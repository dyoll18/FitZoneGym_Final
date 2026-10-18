namespace FitZoneGym.Controls
{
    /// <summary>Dark card surface with a 1px border; paints itself so it also shows in the Visual Studio designer.</summary>
    public class CardPanel : Panel
    {
        public CardPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Ui.Surface;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var pen = new Pen(Ui.Border))
                e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
        }
    }
}
