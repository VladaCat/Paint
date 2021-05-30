using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project_Paint.Class.OperationWithFigures
{
    public abstract class PaintImage : ICloneable
    {
        protected Image _image;

        public abstract object Clone();
        //{
        //    return _image.Clone();
        //}
        
        public Image ToImage()
        {
            return _image;
        }
        public void Save(string filename)
        {
            _image.Save(filename);
        }
        public static PaintImage FromFile(string filename)
        {
           return new PaintBitmap(Image.FromFile(filename));
        }
    }
}
