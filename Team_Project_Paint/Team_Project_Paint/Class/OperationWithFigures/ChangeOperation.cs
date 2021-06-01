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
        private Select _select;
        private PaintColor _color;
        private List<IShape> _shapelist;
        private int _thickness;


        public ChangeOperation(List<IShape> shapelist, Select select, PaintBitmap bitmap)
        {
            _select = select;
            _shapelist = shapelist;
            _currentBitmap = bitmap;
            Delete(_shapelist, _select);
            UpdatePicture(_shapelist, _currentBitmap);
        }

        public ChangeOperation(List<IShape> shapelist, Select select, PaintColor color, PaintBitmap bitmap)
        {
            _select = select;
            _shapelist = shapelist;
            _color = color;
            _currentBitmap = bitmap;
            ChangeColor(_shapelist, _select, _color);
            UpdatePicture(_shapelist, _currentBitmap);
        }

        public ChangeOperation(List<IShape> shapelist, Select select, int thickness, PaintBitmap bitmap)
        {
            _select = select;
            _shapelist = shapelist;
            _thickness = thickness;
            _currentBitmap = bitmap;
            ChangeThickness(_shapelist, _select, _thickness);
            UpdatePicture(_shapelist, _currentBitmap);
        }

        private void Delete(List<IShape> shapelist, Select select)
        {
            shapelist.RemoveAt(_select.Numb);
            select.IsSelected = false;
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

        private void UpdatePicture(List<IShape> shapelist, PaintBitmap paintBitmap)
        {
            for (int i = 0; i < shapelist.Count; i++)
            {
                if (shapelist[i] != null)
                {
                    shapelist[i].Draw(PaintGraphics.FromImage(_currentBitmap));
                }
            }
        }

    }
}
