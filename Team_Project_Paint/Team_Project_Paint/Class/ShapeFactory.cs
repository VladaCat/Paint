using System;
using Team_Project_Paint.PaintEnum;
using Team_Project_Paint.Interfaces;

namespace Team_Project_Paint.Class
{
   public class ShapeFactory : IShapeFactory
    {
        public IShape CreateShape(EShapeType currentMode)
        {
            switch (currentMode)
            {
                case EShapeType.Dot:
                    return new Dot();
                case EShapeType.Line:
                    return new Line();
                case EShapeType.Curve:
                    return new Curve();
                case EShapeType.Rect:
                    return new Rect();
                case EShapeType.Ellipse:
                    return new Ellipse();
                case EShapeType.Triangle:
                    return new Triangle();
                case EShapeType.Hexagon:
                    return new Hexagon();
                case EShapeType.RoundingRect:
                    return new RoundingRect();
                default: throw new Exception("This figure doesn't exist");
            }
        }
    }
}
