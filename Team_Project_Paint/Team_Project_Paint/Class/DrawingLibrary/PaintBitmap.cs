using System.Drawing;

namespace Team_Project_Paint.Class.OperationWithFigures
{
    public class PaintBitmap : PaintImage
    {
        public PaintBitmap(Image image)
        {
            this._image = image;
        }
        public PaintBitmap(int width, int height)
        {
            this._image = new Bitmap(width, height);
        }

        public override object Clone()
        {
            return new PaintBitmap(_image.Clone() as Bitmap);
        }
    }
}
