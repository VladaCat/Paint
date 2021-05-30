using System.Collections.Generic;
using System.Windows.Forms;
using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.PaintEnum;
using Team_Project_Paint.Interfaces;

namespace Team_Project_Paint.Class
{
    public class Select : IMovable
    {
        protected bool isSelect;
        public int Numb { get; set; }
        public bool IsSelected { get { return isSelect; } set => isSelect = value; }

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


        public void SelectShape(List<IShape> shapeList, ShapePoint e)
        {
            for (int i = 0; i < shapeList.Count; i++)
            {
                var tmp = shapeList[i];

                    if (tmp.Name == EShapeType.Dot && !isSelect)
                    {
                        if ((e.X >= tmp.Location.X - tmp.Thickness / 2 && e.X <= tmp.Location.X + tmp.Thickness))
                        {
                            if ((e.Y >= tmp.Location.Y - tmp.Thickness / 2 && e.Y <= tmp.Location.Y + tmp.Thickness))
                            {
                                isSelect = true;
                                Numb = i;
                            }
                            else
                            {
                                isSelect = false;
                            }
                        }
                    }
                if (tmp.Location != null && tmp.FinishLocation != null)
                {
                    if (((e.X < tmp.FinishLocation.X) && (e.X > tmp.Location.X)) && tmp.Name != EShapeType.Dot && !isSelect || ((e.X > tmp.FinishLocation.X) && (e.X < tmp.Location.X) && tmp.Name != EShapeType.Dot && !isSelect))
                    {
                        if (((e.Y < tmp.FinishLocation.Y) && (e.Y > tmp.Location.Y)) || ((e.Y > tmp.FinishLocation.Y) && (e.Y < tmp.Location.Y)))
                        {
                            isSelect = true;
                            Numb = i;
                        }
                        else
                        {
                            isSelect = false;
                        }
                    }
                }
                


            }
        }

    }
}    