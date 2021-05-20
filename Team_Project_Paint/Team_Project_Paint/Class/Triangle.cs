using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team_Project_Paint.Enum;

namespace Team_Project_Paint.Class
{
    class Triangle:AbstractRectangleStyle
    {
        public Triangle() : base(NameForShapeFactory.Triangle) { }
        public override void Draw(Graphics graphics)
        {

            List<Point> Triangle = new List<Point>();

            Triangle.Add(new Point(FinishLocation.X, FinishLocation.Y));
            Triangle.Add(new Point(Location.X, FinishLocation.Y));
            Triangle.Add(new Point((Location.X + FinishLocation.X) / 2, Location.Y));

            graphics.DrawPolygon(new Pen(new SolidBrush(Color), Thickness), Triangle.ToArray());
        }
    }
}
