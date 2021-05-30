using System;
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
        public EPainLinejoin LineJoin
        {
            get
            {
                string name = Enum.GetName(typeof(LineJoin), _pen.LineJoin);
                return (EPainLinejoin)Enum.Parse(typeof(EPainLinejoin), name);
            }
            set
            {
                string name = Enum.GetName(typeof(EPainLinejoin), value);
                _pen.LineJoin =
                    (LineJoin)Enum.Parse(typeof(LineJoin), name);

            }

        }

        public EPaintLineCap StartCap
        {
            get
            {
                string name = Enum.GetName(typeof(LineCap), _pen.StartCap);
                return (EPaintLineCap)Enum.Parse(typeof(EPaintLineCap), name);
            }
            set
            {
                string name = Enum.GetName(typeof(EPaintLineCap), value);
                _pen.StartCap =
                    (LineCap)Enum.Parse(typeof(LineCap), name);

            }
        }
        public EPaintLineCap EndCap
        {
            get
            {
                string name = Enum.GetName(typeof(LineCap), _pen.EndCap);
                return (EPaintLineCap)Enum.Parse(typeof(EPaintLineCap), name);
            }
            set
            {
                string name = Enum.GetName(typeof(EPaintLineCap), value);
                _pen.EndCap =
                    (LineCap)Enum.Parse(typeof(LineCap), name);
            }
        }
        public Pen ToPen()
        {
            return _pen;
        }
    }
}
