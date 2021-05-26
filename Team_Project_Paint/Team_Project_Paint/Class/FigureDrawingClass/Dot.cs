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

        private bool _isFinished = false;

        public Dot() : base(EShapeType.Dot) { }
        public override bool IsFinished()
        {
            return _isFinished;
        }

        public override void Draw(Graphics graphics)
        {
            if (_isFinished)
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.FillEllipse(
                   new SolidBrush(Color),
                   Location.X - Thickness / 2,
                   Location.Y - Thickness / 2,
                   Thickness,
                   Thickness);
            }
        }

        public override void MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !_isFinished)
            {
                Location = e.Location;
                _isFinished = true;
            }
        }

        public override void DrawTemp(Graphics graphics)
        {
        }
    }
}
