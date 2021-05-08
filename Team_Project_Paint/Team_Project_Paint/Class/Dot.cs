using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Project_Paint.Class
{
    public class Dot : AbstractShape
    {

        private bool isFinished = false;

        public Dot() : base("Dot") { }
        public override bool IsFinished()
        {
            return isFinished;
        }
        public override void Draw(Graphics graphics)
        {
            if (isFinished)
            {
                graphics.FillEllipse(
                   new SolidBrush(Color),
                   Location.X,
                   Location.Y,
                   Thickness,
                   Thickness);
            }
        }

        public override void MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !isFinished)
            {
                Location = e.Location;
                isFinished = true;
            }
        }
    }
}
