using System;
using Team_Project_Paint.Class;
using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.PaintEnum;

namespace Team_Project_Paint
{
    public class Hexagon : AbstractShape
    {
        private int _cornes = 3;
       
        public Hexagon() : base(EShapeType.Hexagon) { }

        public int Cornes
        {
            get
            {
                return _cornes;
            }
            set
            {
                if (EShapeStatus == Class.FigureDrawingClass.EShapeStatus.IN_PROGRESS)
                {
                    _cornes = value;
                }
            }
        }

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
            if (width == 0 || height == 0)
            {
                return;
            }
            if (Cornes == 0)
            {
                Cornes = _cornes;
            }
            width += Thickness;
            height += Thickness;
            int Radius = (int)((double)Math.Min(width, height) / (double)2.0 * (double)0.8);
            ShapePointF Center = new ShapePointF((int)((double)width / (double)2.0), (int)((double)height / (double)2.0));
            PaintRectangleF rectangle = new PaintRectangleF(Center, new ShaipSizeF(1, 1));
            rectangle.Inflate(Radius, Radius);
           
            PaintImage img = new PaintBitmap(Size.Width, Size.Height);
            PaintGraphics tmpGraphics = PaintGraphics.FromImage(img);
            InscribePolygon(tmpGraphics, rectangle, _cornes);
            graphics.DrawImage(img, x, y);
        }

        private void InscribePolygon(PaintGraphics graphics, PaintRectangleF rectangle, int numSides)
        {
            float Radius = (float)((double)Math.Min(rectangle.Width, rectangle.Height) / 2.0);
            ShapePointF Center = new ShapePointF(
                (float)(rectangle.Location.X + rectangle.Width / 2.0),
                (float)(rectangle.Location.Y + rectangle.Height / 2.0));
            PaintRectangleF rectangleF = new PaintRectangleF(Center, new ShaipSizeF(1, 1));
            rectangleF.Inflate(Radius, Radius);

            float Sides = (float)numSides;
            float ExteriorAngle = (float)360 / Sides;
            float InteriorAngle = (Sides - (float)2) / Sides * (float)180;
            float SideLength = (float)2 * Radius * (float)Math.Sin(Math.PI / (double)Sides);
            for (int i = 1; i <= Sides; i++)
            {
                graphics.ResetTransform();
                graphics.TranslateTransform(Center.X, Center.Y);
                graphics.RotateTransform((i - 1) * ExteriorAngle);
                graphics.TranslateTransform(0, -Radius);
                graphics.RotateTransform(180 - InteriorAngle / 2);
                graphics.MySmoothingMode = EPaintSmoothingMode.AntiAlias;
                PaintPen pen = new PaintPen(Color, Thickness);
                pen.StartCap = EPaintLineCap.Round;
                pen.EndCap = EPaintLineCap.Round;
                graphics.DrawLine(
                    pen,
                    new ShapePointF(0, 0).ToPointF(),
                    new ShapePointF(0, -SideLength).ToPointF());
            }
        }
    }
}

