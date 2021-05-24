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
            else if (currentMode == NameForShapeFactory.Line)
            {
                return new Line();
            }
            else if (currentMode == NameForShapeFactory.Select)
            {
                return new Select();
            }
            else if (currentMode == NameForShapeFactory.Triangle) 
            {
                return new Triangle();
            }else if(currentMode == NameForShapeFactory.Hexagon)
            {
                return new Hexagon();
            }else if(currentMode== NameForShapeFactory.RoundingRect)
            {
                return new RoundingRect();
            }
            else
            {
                throw new Exception("This figure doesn't exist");
            }
        }
    }
}
