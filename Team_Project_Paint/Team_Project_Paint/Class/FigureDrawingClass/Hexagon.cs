using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team_Project_Paint.Class;
using Team_Project_Paint.Enum;

namespace Team_Project_Paint
{
    public class Hexagon : AbstractRectangleStyle
    {
        /*
         https://stackoverflow.com/questions/19210569/transcribing-a-polygon-on-a-circle#19210662
         */

        private int _cornes = 3;
        public Size Size { get; set; }
        public Hexagon() : base(EShapeType.Hexagon) { }

        public int Cornes
        {
            get
            {
                return _cornes;
            }
            set
            {
                if (!isFinished)
                {
                    _cornes = value;
                }
            }
        }

        public override void Draw(Graphics graphics)
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
            Point Center = new Point((int)((double)width / (double)2.0), (int)((double)height / (double)2.0));
            Rectangle rectangle = new Rectangle(Center, new Size(1, 1));
            rectangle.Inflate(Radius, Radius);

            //Image img = new Bitmap(800, 1200);
            Image img = new Bitmap(Size.Width, Size.Height);
            Graphics tmpGraphics = Graphics.FromImage(img);
                InscribePolygon(tmpGraphics, rectangle, _cornes);
                graphics.DrawImage(img, x, y);      
        }

        private void InscribePolygon(Graphics graphics, Rectangle rectangle, int numSides)
        {
            float Radius = (float)((double)Math.Min(rectangle.Width, rectangle.Height) / 2.0);
            PointF Center = new PointF(
                (float)(rectangle.Location.X + rectangle.Width / 2.0),
                (float)(rectangle.Location.Y + rectangle.Height / 2.0));
            RectangleF rectangleF = new RectangleF(Center, new SizeF(1, 1));
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
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Pen pen = new Pen(Color, Thickness);
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                graphics.DrawLine(
                    pen,
                    new PointF(0, 0),
                    new PointF(0, -SideLength));
            }
        }
    }
}

