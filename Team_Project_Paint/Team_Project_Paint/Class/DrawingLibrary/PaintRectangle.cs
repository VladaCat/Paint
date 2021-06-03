using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project_Paint.Class.OperationWithFigures
{
    public class PaintRectangle
    {
        private Rectangle _rectangle;
        public PaintRectangle()
        {
            _rectangle = new Rectangle();
        }
        public PaintRectangle(Rectangle rectangle)
        {
            _rectangle = rectangle;
        }
        public PaintRectangle(ShapePoint location, ShapeSize size)
        {
            _rectangle.Location = location.ToPoint();
            _rectangle.Size = size.ToSize();
        }

        public PaintRectangle(int x, int y, int width, int height)
        {
            _rectangle = new Rectangle(x, y, width, height);
        }

        public ShapeSize Size { get; set; }

        public ShapePoint Location { get; set; }
        public int Height
        {
            get { return _rectangle.Height; }
            set { _rectangle.Height = value; }
        }
        public int Width
        {
            get { return _rectangle.Width; }
            set { _rectangle.Width = value; }
        }
        public int Y
        {
            get { return _rectangle.Y; }
            set { _rectangle.Y = value; }
        }
        public int X
        {
            get { return _rectangle.X; }
            set { _rectangle.X = value; }
        }

        public void Inflate(int width, int height)
        {
            _rectangle.Inflate(width, height);
        }

        public static PaintRectangle Intersect(PaintRectangle a, PaintRectangle b)
        {
            return new PaintRectangle(Rectangle.Intersect(a.ToRectangle(), b.ToRectangle()));
        }
        public Rectangle ToRectangle()
        {
            return _rectangle;
        }
    }
}
