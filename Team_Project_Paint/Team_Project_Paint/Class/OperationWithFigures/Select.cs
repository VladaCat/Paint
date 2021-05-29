using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.Enum;
using Team_Project_Paint.Interfaces;

namespace Team_Project_Paint.Class
{
    public class Select /*: AbstractRectangleStyle*/
    {

        /*public Select() : base(EShapeType.Select) { }*/

       /* public override void Draw(PaintGraphics graphics)
        {
        }

        public void Move(int dx, int dy, IShape shape)
        {
            int startX = shape.Location.X + dx;
            int startY = shape.Location.Y + dy;

            int finX = shape.FinishLocation.X + dx;
            int finY = shape.FinishLocation.Y + dy;

            ShapePoint start = new ShapePoint(startX, startY);
            ShapePoint finish = new ShapePoint(finX, finY);

            shape.Location = start;
            shape.FinishLocation = finish;

        }

        public override void SelectShape(List<IShape> shapeList, MouseEventArgs e)
        {
            for (int i = 0; i < shapeList.Count; i++)
            {
                var tmp = shapeList[i];
                if (tmp.Name == EShapeType.Dot && !isClicked)
                {
                    if ((e.X >= tmp.Location.X - tmp.Thickness / 2 && e.X <= tmp.Location.X + tmp.Thickness))
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

                {
                    if (((e.X < tmp.FinishLocation.X) && (e.X > tmp.Location.X)) && tmp.Name != EShapeType.Dot && !isClicked || ((e.X > tmp.FinishLocation.X) && (e.X < tmp.Location.X) && tmp.Name != EShapeType.Dot && !isClicked))
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

        }*/
    }
}
