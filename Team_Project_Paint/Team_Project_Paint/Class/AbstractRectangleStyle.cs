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
    public abstract class AbstractRectangleStyle : AbstractShape
    {
        protected bool isFinished = false;

        protected bool isStarted = false;

        public AbstractRectangleStyle(NameForShapeFactory Name) : base(Name) { }
        public abstract override void Draw(Graphics graphics);
        public override bool IsFinished()
        {
            return isFinished;
        }

        public override void DrawTemp(Graphics graphics)
        {
            Draw(graphics);
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
            if (!isFinished && isStarted && e.Button == MouseButtons.Left)
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
