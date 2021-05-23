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

        public bool isClicked = false;

        public override void Draw(Graphics graphics)
        {
        }

        public override void SelectShape(List<IShape> shapeList, MouseEventArgs e)
        {
            for (int i = 0; i < shapeList.Count; i++)
            {
                var tmp = shapeList[i];
                int width = tmp.FinLocation.X - tmp.StartLocation.X;
                int height = tmp.FinLocation.Y - tmp.StartLocation.Y;

                if ((e.X < tmp.StartLocation.X + width) && (e.X > tmp.StartLocation.X))
                    if ((e.Y < tmp.StartLocation.Y + height) && (e.Y > tmp.StartLocation.Y))
                    {
                        isClicked = true;
                        Numb = i;
                    }
            }
        }

    }
}
