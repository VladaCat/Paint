using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.PaintEnum;

namespace Team_Project_Paint.Class
{
    public class Dot : AbstractShape
    {
        public Dot() : base(EShapeType.Dot) { }

        public override void Draw(PaintGraphics graphics)
        {
            if (EShapeStatus == FigureDrawingClass.EShapeStatus.DONE)
            {
                graphics.MySmoothingMode = EPaintSmoothingMode.AntiAlias;
                graphics.FillEllipse(
                   new PaintSolidBrush(Color),
                   Location.X - Thickness / 2,
                   Location.Y - Thickness / 2,
                   Thickness,
                   Thickness);
            }
        }

        public override void MouseClick(ShapePoint point)
        {
            Location = new ShapePoint(point.ToPoint());
            EShapeStatus = FigureDrawingClass.EShapeStatus.DONE;
        }

        public override void MouseDown(ShapePoint point)
        {
            Location = new ShapePoint(point.ToPoint());
            EShapeStatus = FigureDrawingClass.EShapeStatus.DONE;
        }

        public override void MouseMove(ShapePoint point)
        {
            base.MouseMove(point);
        }

        public override void MouseUp(ShapePoint point)
        {
            Location = new ShapePoint(point.ToPoint());
            EShapeStatus = FigureDrawingClass.EShapeStatus.DONE;
        }



        //public override void MouseUp(ShapePoint point)
        //{
        //    //base.MouseUp(point);
        //    Location = new ShapePoint(point.ToPoint());
        //    EShapeStatus = FigureDrawingClass.EShapeStatus.DONE;
        //}

        //public override void MouseClick(ShapePoint point)
        //{
        //    if (EShapeStatus == FigureDrawingClass.EShapeStatus.NOT_STARTED)
        //    {
        //        Location = new ShapePoint(point.ToPoint());
        //        EShapeStatus = FigureDrawingClass.EShapeStatus.DONE;
        //    }
        //}
    }
}
