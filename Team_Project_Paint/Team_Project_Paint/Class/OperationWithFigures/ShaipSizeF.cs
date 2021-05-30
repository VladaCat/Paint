using System.Drawing;

namespace Team_Project_Paint.Class.OperationWithFigures
{
    public class ShaipSizeF
    {
        public ShaipSizeF()
        {

        }
        public ShaipSizeF(float width, float height)
        {
            Width = width;
            Height = height;
        }
        public ShaipSizeF(Point pt)
        {
            Width = pt.X;
            Height = pt.Y;
        }
        public float Width { get; set; }

        public float Height { get; set; }

        public SizeF ToSizeF()
        {
            return new SizeF(Width, Height);
        }
    }
}