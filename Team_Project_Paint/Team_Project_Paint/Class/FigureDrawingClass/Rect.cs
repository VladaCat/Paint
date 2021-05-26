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
    public class Rect : AbstractRectangleStyle
    {
        public Rect() : base(EShapeType.Rect) { }


        public override void Draw(Graphics graphics)
        {
            int x = Location.X;
            int y = Location.Y;
            int width = FinishLocation.X - Location.X;
            int height = FinishLocation.Y - Location.Y;
            if (x > FinishLocation.X)
            {
                width = Math.Abs(FinishLocation.X - Location.X);
                x = FinishLocation.X;
            }
            if (y > FinishLocation.Y)
            {
                height = Math.Abs(FinishLocation.Y - Location.Y);
                y = FinishLocation.Y;
            }

            graphics.DrawRectangle(
               new Pen(Color, Thickness),
                x,
                y,
                width,
                height);
        }
    }
}
