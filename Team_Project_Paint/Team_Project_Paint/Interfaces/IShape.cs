using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Team_Project_Paint.Class;
using Team_Project_Paint.Class.FigureDrawingClass;
using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.PaintEnum;

namespace Team_Project_Paint.Interfaces
{
    public interface IShape
    {
        int Thickness { get; set; }

        ShapePoint Location { get; set; }
        ShapePoint FinishLocation { get; set; }
        List<ShapePoint> ShapePoints { get; set; }

        PaintColor Color { get; set; }
        ShapeSize Size { get; set; }
        EShapeType Name { get; }
        EShapeStatus EShapeStatus { get; set; }
        void MouseClick(ShapePoint point);
        void MouseDown(ShapePoint point);
        void MouseUp(ShapePoint point);
        void MouseMove(ShapePoint point);
        void Draw(PaintGraphics graphics);
    }
}
