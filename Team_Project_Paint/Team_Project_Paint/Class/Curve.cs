﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Project_Paint.Class
{
    public class Curve : AbstractShape
    {
        private List<Point> points = new List<Point>();
        private bool isFinished = false;
        private bool isStarted = false;

        public Curve() : base("Curve") { }

        public override bool IsFinished()
        {
            return isFinished;
        }
        public override void Draw(Graphics graphics)
        {
            if (points.Count > 1)
            {
                graphics.DrawLines(
                    new Pen(new SolidBrush(Color), Thickness),
                    points.ToArray());
            }
        }

    
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if (!isFinished && !isStarted)
            {
                Location = e.Location;
                points.Add(e.Location);
                isStarted = true;
            }
        }
        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (!isFinished && isStarted)
            {
                points.Add(e.Location);
            }
        }
        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (!isFinished && isStarted)
            {
                isFinished = true;
                points.Add(e.Location);
            }
        }

    }
}
