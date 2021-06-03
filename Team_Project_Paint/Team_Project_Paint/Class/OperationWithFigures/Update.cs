using System.Collections.Generic;
using Team_Project_Paint.Class.FigureDrawingClass;
using Team_Project_Paint.Interfaces;

namespace Team_Project_Paint.Class.OperationWithFigures
{
    public class Update
    {
        private PaintBitmap _currentBitmap;
        private List<IShape> _shapelist;


        public Update(List<IShape> shapelist, PaintBitmap bitmap)
        {
            _shapelist = shapelist;
            _currentBitmap = bitmap;;
        }

        public void UpdatePicture()
        {
            for (int i = 0; i < _shapelist.Count; i++)
            {
                if (_shapelist[i] != null)
                {
                    _shapelist[i].Draw(PaintGraphics.FromImage(_currentBitmap));
                }
            }
        }

        public void UpdatePictureJson()
        {
            for (int i = 0; i < _shapelist.Count; i++)
            {
                if (_shapelist[i] != null)
                {
                    _shapelist[i].EShapeStatus = EShapeStatus.DONE;
                    _shapelist[i].Draw(PaintGraphics.FromImage(_currentBitmap));
                }
            }
        }

    }
}
