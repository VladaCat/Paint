﻿using System;
using System.Drawing;
using Team_Project_Paint.Class;
using Team_Project_Paint.PaintEnum;
using System.Drawing.Drawing2D;
using Team_Project_Paint.Class.OperationWithFigures;

namespace Team_Project_Paint
{
    /*
    https://www.codeproject.com/Articles/5649/Extended-Graphics-An-implementation-of-Rounded-Rec
    */
    public class RoundingRect : AbstractRectangleStyle
    {
        public RoundingRect() : base(EShapeType.RoundingRect) { }

        int radius = 10;
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

            graphics.MySmoothingMode = EPaintSmoothingMode.AntiAlias;
            PaintPen pen = new PaintPen(Color, Thickness);
            pen.LineJoin = LineJoin.Round;
            RectangleF rect = new RectangleF(x, y, width, height);
            PaintGraphicsPath path = this.GetRoundRectangle(rect, radius);

            graphics.DrawPath(pen, path);
        }

        private PaintGraphicsPath GetRoundRectangle(RectangleF baseRect, float radius)
        {
            if (radius <= 0.0F)
            {
                PaintGraphicsPath mPath = new PaintGraphicsPath(new GraphicsPath());
                mPath.AddRectangle(baseRect);
                mPath.CloseFigure();
                return mPath;
            }

            // if the corner radius is greater than or equal to 
            // half the width, or height (whichever is shorter) 
            // then return a capsule instead of a lozenge 
            if (radius >= (Math.Min(baseRect.Width, baseRect.Height)) / 2.0)
                return GetCapsule(baseRect);

            // create the arc for the rectangle sides and declare 
            // a graphics path object for the drawing 
            float diameter = radius * 2.0F;
            SizeF sizeF = new SizeF(diameter, diameter);
            RectangleF arc = new RectangleF(baseRect.Location, sizeF);
            PaintGraphicsPath path = new PaintGraphicsPath(new GraphicsPath());

            // top left arc 
            path.AddArc(arc, 180, 90);

            // top right arc 
            arc.X = baseRect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc 
            arc.Y = baseRect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc
            arc.X = baseRect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        private PaintGraphicsPath GetCapsule(RectangleF baseRect)
        {
            float diameter;
            RectangleF arc;
            PaintGraphicsPath path = new PaintGraphicsPath(new GraphicsPath());
            try
            {
                if (baseRect.Width > baseRect.Height)
                {
                    // return horizontal capsule 
                    diameter = baseRect.Height;
                    SizeF sizeF = new SizeF(diameter, diameter);
                    arc = new RectangleF(baseRect.Location, sizeF);
                    path.AddArc(arc, 90, 180);
                    arc.X = baseRect.Right - diameter;
                    path.AddArc(arc, 270, 180);
                }
                else if (baseRect.Width < baseRect.Height)
                {
                    // return vertical capsule 
                    diameter = baseRect.Width;
                    SizeF sizeF = new SizeF(diameter, diameter);
                    arc = new RectangleF(baseRect.Location, sizeF);
                    path.AddArc(arc, 180, 180);
                    arc.Y = baseRect.Bottom - diameter;
                    path.AddArc(arc, 0, 180);
                }
                else
                {
                    // return circle 
                    path.AddEllipse(baseRect);
                }
            }
            catch (Exception ex)
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

