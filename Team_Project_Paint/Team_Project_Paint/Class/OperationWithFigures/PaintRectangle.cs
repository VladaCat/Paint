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

        }
        public PaintRectangle(ShapePoint location, ShapeSize size)
        {
            Location = location;
            Size = size;
        }

        public PaintRectangle(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public ShapeSize Size { get; set; }

        public ShapePoint Location { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public int Y { get; set; }
        public int X { get; set; }
        public void Inflate(int width, int height)
        {
            _rectangle.Inflate(width, height);
        }
        public Rectangle ToRectangle()
        {
            return new Rectangle(Location.ToPoint(), Size.ToSize());
        }
    }
}
