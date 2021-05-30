using System.Drawing;

namespace Team_Project_Paint.Class.OperationWithFigures
{
    public class ShapeSize
    {
        public ShapeSize()
        {

        }

        public ShapeSize(Size size)
        {
            this.Width = size.Width;
            this.Height = size.Height;
        }
        public ShapeSize(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public ShapeSize(Point pt)
        {
            Width = pt.X;
            Height = pt.Y;
        }
        public int Width { get; set; }

        public int Height { get; set; }

        public Size ToSize()
        {
            return new Size(Width, Height);
        }
    }
}