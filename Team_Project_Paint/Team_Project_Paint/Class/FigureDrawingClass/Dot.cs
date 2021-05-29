using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.PaintEnum;

namespace Team_Project_Paint.Class
{
    public class Dot : AbstractShape
    {

        private bool _isFinished = false;

        public Dot() : base(EShapeType.Dot) { }
        public override bool IsFinished()
        {
            return _isFinished;
        }

        public override void Draw(PaintGraphics graphics)
        {
            if (_isFinished)
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
            if (!_isFinished)
            {
                Location =new ShapePoint(point.ToPoint());
                _isFinished = true;
            }
        }

        public override void DrawTemp(PaintGraphics graphics)
        {
        }
    }
}
