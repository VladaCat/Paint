using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team_Project_Paint.Enum;

namespace Team_Project_Paint.Class
{
    public class Curve : AbstractShape
    {
        private Point location;
        public virtual Point Location 
        { 
            get => location;
            set => location = value;
        }

        private List<Point> points = new List<Point>();

        private bool isFinished = false;

        private bool isStarted = false;

        public Curve() : base(NameForShapeFactory.Curve) { }

        public override bool IsFinished()
        {
            return isFinished;
        }

        public override void Draw(Graphics graphics)
        {
            if (points.Count > 1)
            {
                for (int i = 0; i < points.Count - 1; i++) 
                {
                    graphics.DrawLine(new Pen(new SolidBrush(Color), Thickness),points[i],points[i+1]);
                }
                foreach (Point point in points)
                {
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    graphics.FillEllipse(new SolidBrush(Color),
                    point.X - Thickness / 2,
                    point.Y - Thickness / 2,
                    Thickness,
                    Thickness);
                }
            }
        }
   
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (!isFinished && !isStarted)
            {
                Location = e.Location;
                points.Add(e.Location);
                isStarted = true;
            }
        }

        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (!isFinished && isStarted)
            {
                points.Add(e.Location);
            }
        }

        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (!isFinished && isStarted)
            {
                isFinished = true;
                points.Add(e.Location);
            }
        }

        public override void DrawTemp(Graphics graphics)
        {
            graphics.FillEllipse(new SolidBrush(Color),
            points.Last().X - Thickness / 2,
            points.Last().Y - Thickness / 2,
            Thickness,
            Thickness);
            if (points.Count > 1) 
            {
                graphics.DrawLine(new Pen(new SolidBrush(Color), Thickness), points[points.Count-2], points.Last());
            }
        }
    }
}
