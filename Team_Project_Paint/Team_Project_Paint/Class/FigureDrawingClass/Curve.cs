﻿using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.Enum;

namespace Team_Project_Paint.Class
{
    public class Curve : AbstractShape
    {
        private List<ShapePoint> _points = new List<ShapePoint>();
        private bool _isFinished = false;
        private bool _isStarted = false;

        public Curve() : base(EShapeType.Curve) { }

        public override bool IsFinished()
        {
            return _isFinished;
        }

        public override void Draw(PaintGraphics graphics)
        {
            if (_points.Count > 1)
            {
                for (int i = 0; i < _points.Count - 1; i++)
                {
                    graphics.DrawLine(new PaintPen(new PaintSolidBrush(Color), Thickness), _points[i], _points[i + 1]);
                }
                foreach (ShapePoint point in _points)
                {
                    graphics.MySmoothingMode = SmoothingMode.AntiAlias;
                    graphics.FillEllipse(new PaintSolidBrush(Color),
                    point.X - Thickness / 2,
                    point.Y - Thickness / 2,
                    Thickness,
                    Thickness);
                }
            }
        }

        public override void MouseDown(ShapePoint point)
        {
            if (!_isFinished && !_isStarted)
            {

                _points.Add(new ShapePoint(point.ToPoint()));
                _isStarted = true;
            }
        }

        public override void MouseMove(ShapePoint point)
        {
            if (!_isFinished && _isStarted)
            {
                _points.Add(new ShapePoint(point.ToPoint()));
            }
        }

        public override void MouseUp(ShapePoint point)
        {
            if (!_isFinished && _isStarted)
            {
                _isFinished = true;
                _points.Add(new ShapePoint(point.ToPoint()));
            }
        }

        public override void DrawTemp(PaintGraphics graphics)
        {
            graphics.FillEllipse(new PaintSolidBrush(Color),
            _points.Last().X - Thickness / 2,
            _points.Last().Y - Thickness / 2,
            Thickness,
            Thickness);
            if (_points.Count > 1)
            {
                graphics.DrawLine(new PaintPen(new PaintSolidBrush(Color), Thickness), _points[_points.Count - 2], _points.Last());
            }
        }
    }
}
