﻿using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.Enum;

namespace Team_Project_Paint.Class
{
    public class Line : AbstractRectangleStyle
    {
        public Line() : base(EShapeType.Line) { }  
        public override void Draw(PaintGraphics graphics)
        {
            graphics.DrawLine(
                new PaintPen(new PaintSolidBrush(Color), Thickness),
                Location.X,
                Location.Y,
                FinishLocation.X,
                FinishLocation.Y);
        }
    }
}
