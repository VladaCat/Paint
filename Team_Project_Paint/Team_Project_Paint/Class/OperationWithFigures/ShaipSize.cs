using System.Drawing;

namespace Team_Project_Paint.Class.OperationWithFigures
{
    public class ShaipSize
    {
        public ShaipSize()
        {

        }
        public ShaipSize(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public ShaipSize(Point pt)
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