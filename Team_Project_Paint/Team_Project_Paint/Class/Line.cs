using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Project_Paint.Class
{
    public class Line : AbstractShape
    {
        private bool isFinished = false;
        private bool isStarted = false;

        public Line() : base("Line") { }

        public override bool IsFinished()
        {
            return isFinished;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(
                new Pen(new SolidBrush(Color), Thickness),
                Location.X,
                Location.Y,
               FinishLocation.X,
               FinishLocation.Y);
        }


        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (!isFinished && !isStarted)
            {
                Location = e.Location;
                FinishLocation = e.Location;
                isStarted = true;
            }
        }
        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (!isFinished && isStarted)
            {
                FinishLocation = e.Location;
            }
        }
        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (!isFinished && isStarted)
            {
                FinishLocation = e.Location;
                isFinished = true;
            }
        }

    }
}
