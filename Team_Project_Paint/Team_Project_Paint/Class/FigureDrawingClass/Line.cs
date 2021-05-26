using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team_Project_Paint.Enum;

namespace Team_Project_Paint.Class
{
    public class Line : AbstractRectangleStyle
    {
        public Line() : base(EShapeType.Line) { }  
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(
                new Pen(new SolidBrush(Color), Thickness),
                Location.X,
                Location.Y,
                FinishLocation.X,
                FinishLocation.Y);
        }
    }
}
