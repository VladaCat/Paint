using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Project_Paint.Class
{
    public class Ellipse : AbstractShape
    {
        private bool isFinished = false;
        private bool isStarted = false;

        public Ellipse() : base("Ellipse") { }
        public override bool IsFinished()
        {
            return isFinished;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(
                new Pen(new SolidBrush(Color), Thickness),
                Location.X,
                Location.Y,
                FinishLocation.X - Location.X,
                FinishLocation.Y - Location.Y);
        }

        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (!isFinished && !isStarted)
            {
                Location = e.Location;
                isStarted = true;
                FinishLocation = e.Location;
            }
        }
        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (!isFinished && isStarted)
            {
                FinishLocation = new Point(
                    e.Location.X,
                    e.Location.Y);
            }
        }
        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (!isFinished && isStarted)
            {
                FinishLocation = new Point(
                    e.Location.X,
                    e.Location.Y);
                isFinished = true;
            }
        }
    }
}
