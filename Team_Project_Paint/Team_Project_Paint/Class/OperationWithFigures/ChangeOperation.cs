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
        public void ChangeColor(List<IShape> shapelist, Select select, PaintColor color)
        {
            IShape currentShape = shapelist[select.Numb];
            shapelist.RemoveAt(select.Numb);
            currentShape.Color = color;
            shapelist.Add(currentShape);
            select.Numb = shapelist.Count - 1;

        }

        public void ChangeThickness(List<IShape> shapelist, Select select, int thickness)
        {
            IShape currentShape = shapelist[select.Numb];
            shapelist.RemoveAt(select.Numb);
            currentShape.Thickness = thickness;
            shapelist.Add(currentShape);
            select.Numb = shapelist.Count - 1;

        }
    }
}
