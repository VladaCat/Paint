using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team_Project_Paint.Interfaces;

namespace Team_Project_Paint.Class
{
   public class ShapeFactory
    {
        public static IShape CreateShape(string shapename)
        {
            switch (shapename)
            {
                case "Dot":
                return new Dot();
                case "Rect":
                    return new Rect();
                case "Ellipse":
                    return new Ellipse();
                case "Curve":
                    return new Curve();
                case "Line":
                    return new Line();
                default:
                    throw new ArgumentException("Incorrect figure name" + shapename);
            }
        }
    }
}
