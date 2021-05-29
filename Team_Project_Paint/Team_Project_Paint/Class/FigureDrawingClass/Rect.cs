using System;
using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.PaintEnum;


namespace Team_Project_Paint.Class
{
    public class Rect : AbstractRectangleStyle
    {
        public Rect() : base(EShapeType.Rect) { }


        public override void Draw(PaintGraphics graphics)
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

            graphics.DrawRectangle(
               new PaintPen(Color, Thickness),
                x,
                y,
                width,
                height);
        }
    }
}
