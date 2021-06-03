using System;
using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.PaintEnum;


namespace Team_Project_Paint.Class
{
    public class Rect : AbstractShape
    {
        public Rect() : base(EShapeType.Rect) { }

        public override void Draw(PaintGraphics graphics)
        {
            (int x, int y, int width, int height) = CalculateRect();
            graphics.DrawRectangle(
               new PaintPen(Color, Thickness),
                x,
                y,
                width,
                height);
        }
        private (int, int, int, int) CalculateRect()
        {
            int x = Location.X;
            int y = Location.Y;
            int width = FinishLocation.X - Location.X;
            int height = FinishLocation.Y - Location.Y;
            if (x > FinishLocation.X)
            {
                width = Math.Abs(FinishLocation.X - Location.X);
                x = FinishLocation.X;
            }
            if (y > FinishLocation.Y)
            {
                height = Math.Abs(FinishLocation.Y - Location.Y);
                y = FinishLocation.Y;
            }
            return (x, y, width, height);
        }
    }
}
