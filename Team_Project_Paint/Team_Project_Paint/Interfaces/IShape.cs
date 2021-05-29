using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Team_Project_Paint.Class;
using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.Enum;

namespace Team_Project_Paint.Interfaces
{
    public interface IShape
    {
        int Thickness { get; set; }

        int Numb { get; set; }

        bool isClicked { get; set; }

        ShapePoint Location { get; set; }
        ShapePoint FinishLocation { get; set; }

        PaintColor Color { get; set; }
        EShapeType Name { get; }

        void MouseClick(ShapePoint point);
        void MouseDown(ShapePoint point);
        void MouseUp(ShapePoint point);
        void MouseMove(ShapePoint point);
        void Draw(PaintGraphics graphics);
        void DrawTemp(PaintGraphics graphics);
        bool IsFinished();
        void SelectShape(List<IShape> shapeList, MouseEventArgs e);
    }
}
