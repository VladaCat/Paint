using System.Collections.Generic;
using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.PaintEnum;

namespace Team_Project_Paint.Class
{
    public class Curve : AbstractShape
    {

        public Curve() : base(EShapeType.Curve) {
            ShapePoints = new List<ShapePoint>();
        }
        

        public override void Draw(PaintGraphics graphics)
        {
            if (ShapePoints.Count > 1)
            {
                for (int i = 0; i < ShapePoints.Count - 1; i++)
                {
                    graphics.DrawLine(new PaintPen(new PaintSolidBrush(Color), Thickness), ShapePoints[i], ShapePoints[i + 1]);
                }
                foreach (ShapePoint point in ShapePoints)
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
                ShapePoints.Add(new ShapePoint(point.ToPoint()));
                EShapeStatus = FigureDrawingClass.EShapeStatus.IN_PROGRESS;
            }
        }

        public override void MouseMove(ShapePoint point)
        {
            if (EShapeStatus == FigureDrawingClass.EShapeStatus.IN_PROGRESS)
            {
                ShapePoints.Add(new ShapePoint(point.ToPoint()));
            }
        }

        public override void MouseUp(ShapePoint point)
        {
            if (EShapeStatus == FigureDrawingClass.EShapeStatus.IN_PROGRESS)
            {
                ShapePoints.Add(new ShapePoint(point.ToPoint()));
                EShapeStatus = FigureDrawingClass.EShapeStatus.DONE;
            }
        }
    }
}
