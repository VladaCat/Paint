using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Team_Project_Paint.Class.OperationWithFigures
{
    public abstract class PaintImage : ICloneable
    {
        protected Image _image;

        public abstract object Clone();
        
        public Image ToImage()
        {
            return _image;
        }
        public void Save(string filename)
        {
            _image.Save(filename);
        }
        
        public void Save(Stream srcStream, ImageFormat format)
        {
            _image.Save(srcStream, format);
        }
        public static PaintImage FromFile(string filename)
        {
           return new PaintBitmap(Image.FromFile(filename));
        }
    }
}
