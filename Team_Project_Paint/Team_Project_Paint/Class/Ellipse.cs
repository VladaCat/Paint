using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Project_Paint.Class
{
    public class Ellipse : AbstractRectangleStyle
    {
        public Ellipse() : base("Ellipse") { }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(
                new Pen(new SolidBrush(Color), Thickness),
                Location.X,
                Location.Y,
                FinishLocation.X - Location.X,
                FinishLocation.Y - Location.Y);
        }
    }
}
