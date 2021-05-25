using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Team_Project_Paint.Enum;
using Team_Project_Paint.Interfaces;

namespace Team_Project_Paint.Class
{
    public class Select : AbstractRectangleStyle
    {

        public Select() : base(NameForShapeFactory.Select) { }

        public override void Draw(Graphics graphics)
        {
        }

        public void Move(int dx, int dy, IShape shape)
        {
            int startX = shape.Location.X + dx;
            int startY = shape.Location.Y + dy;

            int finX = shape.FinishLocation.X + dx;
            int finY = shape.FinishLocation.Y + dy;

            Point start = new Point(startX, startY);
            Point finish = new Point(finX, finY);

            shape.Location = start;
            shape.FinishLocation = finish;

        }

        public override void SelectShape(List<IShape> shapeList, MouseEventArgs e)
        {
            for (int i = 0; i < shapeList.Count; i++)
            {
                var tmp = shapeList[i];
                if (tmp.Name == NameForShapeFactory.Dot)
                {
                    if ((e.X >= tmp.Location.X - tmp.Thickness /2 && e.X <= tmp.Location.X + tmp.Thickness))
                    {
                        if ((e.Y >= tmp.Location.Y - tmp.Thickness / 2 && e.Y <= tmp.Location.Y + tmp.Thickness))
                        {
                            isClicked = true;
                            Numb = i;
                        }
                        else
                        {
                            isClicked = false;
                        }
                    }
                }
                if (((e.X < tmp.FinishLocation.X) && (e.X > tmp.Location.X)) || ((e.X > tmp.FinishLocation.X) && (e.X < tmp.Location.X)))
                {
                    if (((e.Y < tmp.FinishLocation.Y) && (e.Y > tmp.Location.Y)) || ((e.Y > tmp.FinishLocation.Y) && (e.Y < tmp.Location.Y)))
                    {
                        isClicked = true;
                        Numb = i;
                    }
                    else
                    {
                        isClicked = false;
                    }
                }


            }

        }

    }
}
