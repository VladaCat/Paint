using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team_Project_Paint.Enum;
using Team_Project_Paint.Interfaces;

namespace Team_Project_Paint.Class
{
   public class ShapeFactory
    {
        public static IShape CreateShape(NameForShapeFactory currentMode)
        {
            if (currentMode == NameForShapeFactory.Dot)
            {
                return new Dot();
            }
            else if (currentMode == NameForShapeFactory.Rect)
            {
                return new Rect();
            }
            else if (currentMode == NameForShapeFactory.Ellipse)
            {
                return new Ellipse();
            }
            else if (currentMode == NameForShapeFactory.Curve)
            {
                return new Curve();
            }
            else if (currentMode == NameForShapeFactory.Select)
            {
                return new Select();
            }
            else
            {
                return new Line();
            }
        }
    }
}
