using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project_Paint.Class.OperationWithFigures
{
    public class PaintRectangleF
    {
        private RectangleF _rectangleF;
        public PaintRectangleF(RectangleF rectangleF)
        {
            _rectangleF = rectangleF;
        }
        public PaintRectangleF(ShapePointF location, ShaipSizeF size)
        {
            _rectangleF.Location = location.ToPointF();
            _rectangleF.Size = size.ToSizeF();
        }

        public PaintRectangleF(float x, float y, float width, float height)
        {
            _rectangleF.Location = new PointF(x, y);
            _rectangleF.Size = new SizeF(width, height);
        }

        public float Height
        {
            get { return _rectangleF.Height; }
            set { _rectangleF.Height = value; }
        }
        public float Width
        {
            get { return _rectangleF.Width; }
            set { _rectangleF.Width = value; }
        }
        public float Y
        {
            get { return _rectangleF.Y; }
            set { _rectangleF.Y = value; }
        }
        public float X
        {
            get { return _rectangleF.X; }
            set { _rectangleF.X = value; }
        }
        public float Right
        {
            get { return _rectangleF.Right; }
        }
        public float Top { get { return _rectangleF.Top; } }
        public float Left { get { return _rectangleF.Left; } }
        public float Bottom
        {
            get { return _rectangleF.Bottom; }
        }

        public ShaipSizeF Size
        {
            get { return new ShaipSizeF(_rectangleF.Size); }
            set { _rectangleF.Size = value.ToSizeF(); }
        }

        public ShapePointF Location
        {
            get { return new ShapePointF(_rectangleF.Location); }
            set { _rectangleF.Location = value.ToPointF(); }
        }

        public void Inflate(float x, float y)
        {
            _rectangleF.Inflate(x, y);
        }
        public void Inflate(ShaipSizeF size)
        {
            _rectangleF.Inflate(size.ToSizeF());
        }

        public RectangleF ToRectangleF()
        {
            return new RectangleF(Location.ToPointF(), Size.ToSizeF());
        }
    }
}
