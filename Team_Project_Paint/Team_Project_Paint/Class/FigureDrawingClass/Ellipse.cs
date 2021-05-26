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
    public class Ellipse : AbstractRectangleStyle
    {
        public Ellipse() : base(EShapeType.Ellipse) { }
        public override void Draw(Graphics graphics)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.DrawEllipse(
                new Pen(new SolidBrush(Color), Thickness),
                Location.X,
                Location.Y,
                FinishLocation.X - Location.X,
                FinishLocation.Y - Location.Y);
        }
    }
}
