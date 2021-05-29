using System.Drawing.Drawing2D;
using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.Enum;

namespace Team_Project_Paint.Class
{
    public class Ellipse : AbstractRectangleStyle
    {
        public Ellipse() : base(EShapeType.Ellipse) { }
        public override void Draw(PaintGraphics graphics)
        {
            graphics.MySmoothingMode = SmoothingMode.AntiAlias;
            graphics.DrawEllipse(
                new PaintPen(new PaintSolidBrush(Color), Thickness),
                Location.X,
                Location.Y,
                FinishLocation.X - Location.X,
                FinishLocation.Y - Location.Y);
        }
    }
}
