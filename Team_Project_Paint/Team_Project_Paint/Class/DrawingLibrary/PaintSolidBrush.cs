using System.Drawing;

namespace Team_Project_Paint.Class.OperationWithFigures
{
    public class PaintSolidBrush
    {
        private Brush _brush;

        public PaintSolidBrush(PaintColor color)
        {
            _brush = new SolidBrush(color.ToColor());
        }
        public Brush toBrush()
        {
            return _brush;
        }
    }
}
