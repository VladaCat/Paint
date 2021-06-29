using System.Drawing.Drawing2D;

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
        public void AddRectangle(PaintRectangleF rect)
        {
            _graphicsPath.AddRectangle(rect.ToRectangleF());
        }

        public void CloseFigure()
        {
            _graphicsPath.CloseFigure();
        }
        public void AddArc(PaintRectangleF rect, float startAngle, float sweepAngle)
        {
            _graphicsPath.AddArc(rect.ToRectangleF(), startAngle, sweepAngle);
        }

        public void AddEllipse(PaintRectangleF rect)
        {
            _graphicsPath.AddEllipse(rect.ToRectangleF());
        }

    }
}
