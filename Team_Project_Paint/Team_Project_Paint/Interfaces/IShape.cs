﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Project_Paint.Interfaces
{
   public interface IShape
    {
        int Thickness { get; set; }
        Color Color { get; set; }
        String Name { get; }

        void MouseClick(object sender, MouseEventArgs e);
        void MouseDown(object sender, MouseEventArgs e);
        void MouseUp(object sender, MouseEventArgs e);
        void MouseMove(object sender, MouseEventArgs e);
        void Draw(Graphics graphics);
        void DrawTemp(Graphics graphics);//new
        bool IsFinished();
    }
}