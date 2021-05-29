using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Team_Project_Paint.Class.OperationWithFigures
{
    public class PaintGraphics : IDisposable
    {
        private Graphics _graphics;

        public PaintGraphics(Graphics graphics)
        {
            _graphics = graphics;
        }

        public static PaintGraphics FromImage(Image image)
        {
            return new PaintGraphics(Graphics.FromImage(image));
        }

        public void FillEllipse(PaintSolidBrush brush, int x, int y, int width, int height)
        {
            _graphics.FillEllipse(brush.toBrush(), x, y, width, height);
        }
        public void DrawEllipse(PaintPen pen, int x, int y, int width, int height)
        {
            _graphics.DrawEllipse(pen.ToPen(), x, y, width, height);
        }

        public void DrawArc(PaintPen pen, int x, int y, int width, int height, int startAngle, int sweepAngle)
        {
            _graphics.DrawArc(pen.ToPen(), x, y, width, height, startAngle, sweepAngle);
        }

        public void DrawCurve(PaintPen pen, PointF[] points, float tension)
        {
            _graphics.DrawCurve(pen.ToPen(), points, tension);
        }

        public void DrawEllipse(PaintPen pen, float x, float y, float width, float height)
        {
            _graphics.DrawEllipse(pen.ToPen(), x, y, width, height);
        }


        public void DrawRectangle(PaintPen pen, float x, float y, float width, float height)
        {
            _graphics.DrawRectangle(pen.ToPen(), x, y, width, height);
        }

        public void DrawRectangle(PaintPen pen, int x, int y, int width, int height)
        {
            _graphics.DrawRectangle(pen.ToPen(), x, y, width, height);
        }

        public void DrawLine(PaintPen pen, int x1, int y1, int x2, int y2)
        {
            _graphics.DrawLine(pen.ToPen(), x1, y1, x2, y2);
        }

        public void DrawLine(PaintPen pen, ShapePoint pt1, ShapePoint pt2)
        {
            _graphics.DrawLine(pen.ToPen(), pt1.ToPoint(), pt2.ToPoint());
        }
        public void DrawPath(PaintPen pen, PaintGraphicsPath path)
        {
            _graphics.DrawPath(pen.ToPen(), path.ToGraphicsPath());
        }

        public void DrawPolygon(PaintPen pen, ShapePoint[] points)
        {
            Point[] point = new Point[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                point[i] = points[i].ToPoint();
            }
            _graphics.DrawPolygon(pen.ToPen(), point);
        }

        public void ResetTransform()
        {
            _graphics.ResetTransform();
        }

        public void TranslateTransform(float dx, float dy)
        {
            _graphics.TranslateTransform(dx, dy);
        }

        public void RotateTransform(float angle)
        {

            _graphics.RotateTransform(angle);
        }

        public EPaintSmoothingMode MySmoothingMode
        {
            get
            {
                string name = Enum.GetName(typeof(SmoothingMode), _graphics.SmoothingMode);
                return (EPaintSmoothingMode)Enum.Parse(typeof(EPaintSmoothingMode), name);
            }
            set
            {
                string name = Enum.GetName(typeof(EPaintSmoothingMode), value);
                _graphics.SmoothingMode =
                    (SmoothingMode)Enum.Parse(typeof(SmoothingMode), name);

            }
        }

        public void DrawLine(PaintPen pen, PointF pt1, PointF pt2)
        {
            _graphics.DrawLine(pen.ToPen(), pt1, pt2);
        }

        public void DrawImage(Image image, int x, int y)
        {
            _graphics.DrawImage(image, x, y);
        }

        public void Clear(PaintColor color)
        {
            _graphics.Clear(color.ToColor());
        }
        public void Dispose()
        {
            _graphics.Dispose();
        }
    }
}
