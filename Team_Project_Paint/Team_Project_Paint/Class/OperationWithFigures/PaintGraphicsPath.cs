using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project_Paint.Class.OperationWithFigures
{
   public class PaintGraphicsPath
    {
        private GraphicsPath _graphicsPath;

        public PaintGraphicsPath(GraphicsPath graphicsPath)
        {
            _graphicsPath = graphicsPath;
        }
        public GraphicsPath ToGraphicsPath()
        {
            return _graphicsPath;
        }
        public void AddRectangle(RectangleF rect)
        {
            _graphicsPath.AddRectangle(rect);
        }

        public void CloseFigure()
        {
            _graphicsPath.CloseFigure();
        }
        public void AddArc(RectangleF rect, float startAngle, float sweepAngle)
        {
            _graphicsPath.AddArc(rect, startAngle, sweepAngle);
        }

        public void AddEllipse(RectangleF rect)
        {
            _graphicsPath.AddEllipse(rect);
        }

    }
}
