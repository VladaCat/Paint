using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project_Paint.Class.OperationWithFigures
{
    public class ShapePointF
    {
        public ShapePointF()
        {

        }

        public ShapePointF(PointF point):this(point.X,point.Y)
        {
           
        }
        public ShapePointF(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float X { get; set; }
        public float Y { get; set; }
        public PointF ToPointF()
        {
            return new PointF(X, Y);
        }



    }
}
