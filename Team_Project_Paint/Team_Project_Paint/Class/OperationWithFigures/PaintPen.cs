using System.Drawing;
using System.Drawing.Drawing2D;

namespace Team_Project_Paint.Class.OperationWithFigures
{
    public class PaintPen
    {
        private Pen _pen;

        public PaintPen(Pen pen)
        {
            _pen = pen;
        }
        public PaintPen(PaintColor color)
        {
            _pen = new Pen(color.ToColor());
        }
        public PaintPen(PaintColor color, float width)
        {
            _pen = new Pen(color.ToColor(), width);
        }
        public PaintPen(PaintSolidBrush brush)
        {
            _pen = new Pen(brush.toBrush());
        }
        public PaintPen(PaintSolidBrush brush, float width)
        {
            _pen = new Pen(brush.toBrush(), width);
        }
        public LineJoin LineJoin
        {
            get { return _pen.LineJoin; }
            set { _pen.LineJoin = value; }
        }
        public LineCap StartCap
        {
            get { return _pen.StartCap; }
            set { _pen.StartCap = value; }
        }
        public LineCap EndCap
        {
            get { return _pen.EndCap; }
            set { _pen.EndCap = value; }
        }
        public Pen ToPen()
        {
            return _pen;
        }
    }
}
