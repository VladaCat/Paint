using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team_Project_Paint.Interfaces;

namespace Team_Project_Paint.Class.OperationWithFigures
{
    public class ChangeOperation
    {
        private PaintBitmap _currentBitmap;
        private List<IShape> _shapelist;


        public ChangeOperation(List<IShape> shapelist, PaintBitmap bitmap)
        {
            _shapelist = shapelist;
            _currentBitmap = bitmap;;
        }

        private void Delete(List<IShape> shapelist, Select select)
        {
            //shapelist.RemoveAt(_select.Numb);
            //select.IsSelected = false;
        }

        private void ChangeColor(List<IShape> shapelist, Select select, PaintColor color)
        {
            IShape currentShape = shapelist[select.Numb];
            shapelist.RemoveAt(select.Numb);
            currentShape.Color = color;
            shapelist.Add(currentShape);
            select.Numb = shapelist.Count - 1;

        }

        private void ChangeThickness(List<IShape> shapelist, Select select, int thickness)
        {
            IShape currentShape = shapelist[select.Numb];
            shapelist.RemoveAt(select.Numb);
            currentShape.Thickness = thickness;
            shapelist.Add(currentShape);
            select.Numb = shapelist.Count - 1;
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

    }
}
