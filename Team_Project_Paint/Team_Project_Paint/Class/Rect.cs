using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Project_Paint.Class
{
    public class Rect : AbstractShape
    {
        private bool isFinished = false;
        private bool isStarted = false;

        public Rect() : base("Rect") { }
        public override bool IsFinished()
        {
            return isFinished;
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
            graphics.DrawRectangle(
                new Pen(new SolidBrush(Color), Thickness),
                x,
                y,
                width,
                height);
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
