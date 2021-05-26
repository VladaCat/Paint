using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team_Project_Paint.Enum;
using Team_Project_Paint.Interfaces;

namespace Team_Project_Paint.Class
{
    public class GraphicServise
    {
        public Graphics graphics;
        private Storage _storage;
        public Bitmap _currentBitmap;
        public IShape _currentShape;
        public EShapeType _currentMode;
        public Bitmap _tempBitmap;


        public void Rendering(List<IShape> shapeList)// отрисовка
        {
            foreach (IShape shape in shapeList)
            {
                shape.Draw(graphics);
            }
        }


        public Bitmap rePaintTemp(IShape _currentShape,
            EShapeType _currentMode,
            Bitmap _currentBitmap,
            Bitmap _tempBitmap,
            Graphics graphics)
        {
            if (_currentMode == EShapeType.Curve)
            {

            }
            else
            {
                graphics.Clear(Color.White);
                graphics.DrawImage(_currentBitmap, 0, 0);
            }
            _currentShape.DrawTemp(graphics);
            return _tempBitmap;
        }

    }

}
