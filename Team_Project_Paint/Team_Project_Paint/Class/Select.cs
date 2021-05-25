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

        public override void SelectShape(List<IShape> shapeList, MouseEventArgs e)
        {
            for (int i = 0; i < shapeList.Count; i++)
            {
                var tmp = shapeList[i];
                if (tmp.Name == NameForShapeFactory.Dot)
                {
                    if ((e.X > tmp.Location.X - 2 && e.X > tmp.Location.X + 2))
                    {
                        if ((e.Y > tmp.Location.Y - 2 && e.Y < tmp.Location.Y + 2))
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
                if ((e.X < tmp.FinishLocation.X) && (e.X > tmp.Location.X))
                {
                    if ((e.Y < tmp.FinishLocation.Y) && (e.Y > tmp.Location.Y))
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
