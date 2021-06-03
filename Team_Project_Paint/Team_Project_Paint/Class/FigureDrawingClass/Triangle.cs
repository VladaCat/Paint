using System.Collections.Generic;
using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.PaintEnum;

namespace Team_Project_Paint.Class
{
    class Triangle:AbstractShape
    {
        public Triangle() : base(EShapeType.Triangle) { }
        public override void Draw(PaintGraphics graphics)
        {

            List<ShapePoint> Triangle = new List<ShapePoint>();

            Triangle.Add(new ShapePoint(FinishLocation.X, FinishLocation.Y));
            Triangle.Add(new ShapePoint(Location.X, FinishLocation.Y));
            Triangle.Add(new ShapePoint((Location.X + FinishLocation.X) / 2, Location.Y));

            graphics.DrawPolygon(new PaintPen(new PaintSolidBrush(Color), Thickness), Triangle.ToArray());
        }
    }
}
