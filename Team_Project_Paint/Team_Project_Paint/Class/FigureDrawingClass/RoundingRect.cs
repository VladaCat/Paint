using System;
/*using System.Drawing;*/
using Team_Project_Paint.Class;
using Team_Project_Paint.PaintEnum;
using System.Drawing.Drawing2D;
using Team_Project_Paint.Class.OperationWithFigures;

namespace Team_Project_Paint
{    
    public class RoundingRect : AbstractShape
    {
        public RoundingRect() : base(EShapeType.RoundingRect) { }

        int radius = 10;
        public override void Draw(PaintGraphics graphics)
        {
            (int x, int y, int width, int height) = CalculateRoundRect();

            graphics.MySmoothingMode = EPaintSmoothingMode.AntiAlias;
            PaintPen pen = new PaintPen(Color, Thickness);
            pen.LineJoin = EPainLinejoin.Round;
            PaintRectangleF rect = new PaintRectangleF(x, y, width, height);
            PaintGraphicsPath path = this.GetRoundRectangle(rect, radius);

            graphics.DrawPath(pen, path);
        }
        private (int, int, int, int) CalculateRoundRect()
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

        private PaintGraphicsPath GetRoundRectangle(PaintRectangleF baseRect, float radius)
        {
            if (radius <= 0.0F)
            {
                PaintGraphicsPath mPath = new PaintGraphicsPath(new GraphicsPath());
                mPath.AddRectangle(baseRect);
                mPath.CloseFigure();
                return mPath;
            }

            
            if (radius >= (Math.Min(baseRect.Width, baseRect.Height)) / 2.0)
                return GetCapsule(baseRect);

            
            float diameter = radius * 2.0F;
            ShaipSizeF sizeF = new ShaipSizeF(diameter, diameter);
            PaintRectangleF arc = new PaintRectangleF(baseRect.Location, sizeF);
            PaintGraphicsPath path = new PaintGraphicsPath(new GraphicsPath());

            
            path.AddArc(arc, 180, 90);

            
            arc.X = baseRect.Right - diameter;
            path.AddArc(arc, 270, 90);

            
            arc.Y = baseRect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

          
            arc.X = baseRect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        private PaintGraphicsPath GetCapsule(PaintRectangleF baseRect)
        {
            float diameter;
            PaintRectangleF arc;
            PaintGraphicsPath path = new PaintGraphicsPath(new GraphicsPath());
            try
            {
                if (baseRect.Width > baseRect.Height)
                {
                   
                    diameter = baseRect.Height;
                    ShaipSizeF sizeF = new ShaipSizeF(diameter, diameter);
                    arc = new PaintRectangleF(baseRect.Location, sizeF);
                    path.AddArc(arc, 90, 180);
                    arc.X = baseRect.Right - diameter;
                    path.AddArc(arc, 270, 180);
                }
                else if (baseRect.Width < baseRect.Height)
                {
                
                    diameter = baseRect.Width;
                    ShaipSizeF sizeF = new ShaipSizeF(diameter, diameter);
                    arc = new PaintRectangleF(baseRect.Location, sizeF);
                    path.AddArc(arc, 180, 180);
                    arc.Y = baseRect.Bottom - diameter;
                    path.AddArc(arc, 0, 180);
                }
                else
                {
                    
                    path.AddEllipse(baseRect);
                }
            }
            catch (Exception)
            {
                path.AddEllipse(baseRect);
            }
            finally
            {
                path.CloseFigure();
            }
            return path;
        }
    }
}

