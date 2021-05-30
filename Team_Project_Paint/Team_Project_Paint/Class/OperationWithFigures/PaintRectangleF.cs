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
            Location = location;
            Size = size;
        }

        public PaintRectangleF(float x, float y, float width, float height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public float Height { get; set; }
        public float Width { get; set; }
        public float Y { get; set; }
        public float X { get; set; }
        public float Right { get; }
        public float Top { get; }
        public float Left { get; }
        public float Bottom { get; }
        public ShaipSizeF Size { get; set; }

        public ShapePointF Location { get; set; }

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
            return new RectangleF(X, Y, Width, Height);
        }
    }
}
