using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.Enum;
using Team_Project_Paint.Interfaces;

namespace Team_Project_Paint.Class
{
    public abstract class AbstractShape : IShape
    {
        private EShapeType name;
        public AbstractShape(EShapeType name)
        {
            this.name = name;
        }
        public virtual int Thickness
        {
            get;
            set;
        }
        public virtual EShapeType Name
        {
            get => name;
        }

        public int Numb { get; set; }
        public bool isClicked { get; set; }
        public ShapePoint FinishLocation { get; set; }
        public ShapePoint Location { get; set; }
        public PaintColor Color { get; set; }
        
        public abstract void Draw(PaintGraphics graphics);
        public abstract void DrawTemp(PaintGraphics graphics);

        public abstract bool IsFinished();

        public virtual void MouseClick(ShapePoint point) { }


        public virtual void MouseDown(ShapePoint point) { }


        public virtual void MouseMove(ShapePoint point) { }


        public virtual void MouseUp(ShapePoint point) { }

        public virtual void SelectShape(List<IShape> shapeList, MouseEventArgs e) { }
    }
}
