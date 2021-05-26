using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team_Project_Paint.Enum;

namespace Team_Project_Paint.Interfaces
{
   public interface IShape
    {
        int Thickness { get; set; }

        int Numb { get; set; }

        bool isClicked { get; set; }

        Point FinishLocation { get; set; }

        Point Location { get; set; }

        Color Color { get; set; }
        EShapeType Name { get; }

        void MouseClick(object sender, MouseEventArgs e);
        void MouseDown(object sender, MouseEventArgs e);
        void MouseUp(object sender, MouseEventArgs e);
        void MouseMove(object sender, MouseEventArgs e);
        void Draw(Graphics graphics);
        void DrawTemp(Graphics graphics);
        bool IsFinished();
        void SelectShape(List<IShape> shapeList, MouseEventArgs e);
    }
}
