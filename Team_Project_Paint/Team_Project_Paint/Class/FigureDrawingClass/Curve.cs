using System.Collections.Generic;
using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.PaintEnum;

namespace Team_Project_Paint.Class
{
    public class Curve : AbstractShape
    {
        private List<ShapePoint> _points = new List<ShapePoint>();

        public Curve() : base(EShapeType.Curve) { }

        public override void Draw(PaintGraphics graphics)
        {
            if (_points.Count > 1)
            {
                for (int i = 0; i < _points.Count - 1; i++)
                {
                    graphics.DrawLine(new PaintPen(new PaintSolidBrush(Color), Thickness), _points[i], _points[i + 1]);
                }
                foreach (ShapePoint point in _points)
                {
                    graphics.MySmoothingMode = EPaintSmoothingMode.AntiAlias;
                    graphics.FillEllipse(new PaintSolidBrush(Color),
                    point.X - Thickness / 2,
                    point.Y - Thickness / 2,
                    Thickness,
                    Thickness);
                }
            }
        }

        public override void MouseDown(ShapePoint point)
        {
            if (EShapeStatus == FigureDrawingClass.EShapeStatus.NOT_STARTED)
            {
                _points.Add(new ShapePoint(point.ToPoint()));
                EShapeStatus = FigureDrawingClass.EShapeStatus.IN_PROGRESS;
            }
        }

        public override void MouseMove(ShapePoint point)
        {
            if (EShapeStatus == FigureDrawingClass.EShapeStatus.IN_PROGRESS)
            {
                _points.Add(new ShapePoint(point.ToPoint()));
            }
        }

        public override void MouseUp(ShapePoint point)
        {
            if (EShapeStatus == FigureDrawingClass.EShapeStatus.IN_PROGRESS)
            {
                _points.Add(new ShapePoint(point.ToPoint()));
                EShapeStatus = FigureDrawingClass.EShapeStatus.DONE;
            }
        }
    }
}
