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
    public class Curve : AbstractShape
    {

        private List<Point> _points = new List<Point>();

        private bool _isFinished = false;

        private bool _isStarted = false;

        public Curve() : base(EShapeType.Curve) { }

        public override bool IsFinished()
        {
            return _isFinished;
        }

        public override void Draw(Graphics graphics)
        {
            if (_points.Count > 1)
            {
                for (int i = 0; i < _points.Count - 1; i++)
                {
                    graphics.DrawLine(new Pen(new SolidBrush(Color), Thickness), _points[i], _points[i + 1]);
                }
                foreach (Point point in _points)
                {
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    graphics.FillEllipse(new SolidBrush(Color),
                    point.X - Thickness / 2,
                    point.Y - Thickness / 2,
                    Thickness,
                    Thickness);
                }
            }
        }

        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (!_isFinished && !_isStarted)
            {
                Location = e.Location;
                _points.Add(e.Location);
                _isStarted = true;
            }
        }

        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isFinished && _isStarted)
            {
                _points.Add(e.Location);
            }
        }

        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (!_isFinished && _isStarted)
            {
                _isFinished = true;
                _points.Add(e.Location);
            }
        }

        public override void DrawTemp(Graphics graphics)
        {
            graphics.FillEllipse(new SolidBrush(Color),
            _points.Last().X - Thickness / 2,
            _points.Last().Y - Thickness / 2,
            Thickness,
            Thickness);
            if (_points.Count > 1)
            {
                graphics.DrawLine(new Pen(new SolidBrush(Color), Thickness), _points[_points.Count - 2], _points.Last());
            }
        }
    }
}
