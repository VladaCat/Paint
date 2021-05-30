using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project_Paint.Class.OperationWithFigures
{
    public class ShapePoint
    {
        public ShapePoint()
        {

        }

        public ShapePoint(Point point):this(point.X,point.Y)
        {
           
        }
        public ShapePoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public Point ToPoint()
        {
            return new Point(X, Y);
        }



    }
}
