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
    public class Dot : AbstractShape
    {
        private Point location;
        public virtual Point Location 
        {
            get => location;
            set => location = value;
        }

        private bool isFinished = false;

        public Dot() : base(NameForShapeFactory.Dot) { }
        public override bool IsFinished()
        {
            return isFinished;
        }

        public override void Draw(Graphics graphics)
        {
            if (isFinished)
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.FillEllipse(
                   new SolidBrush(Color),
                   Location.X - Thickness/2, 
                   Location.Y - Thickness/2,
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

        public override void DrawTemp(Graphics graphics)
        {
        }
    }
}
