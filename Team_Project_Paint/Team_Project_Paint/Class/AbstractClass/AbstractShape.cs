using System.Collections.Generic;
using System.Windows.Forms;
using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.PaintEnum;
using Team_Project_Paint.Interfaces;
using Team_Project_Paint.Class.FigureDrawingClass;

namespace Team_Project_Paint.Class
{
    public abstract class AbstractShape : IShape
    {
        private EShapeType name;
        private EShapeStatus _eHsapeStatus = EShapeStatus.NOT_STARTED;

        public AbstractShape(EShapeType name)
        {
            this.name = name;
        }
        public int Thickness
        {
            get;
            set;
        }
        public EShapeType Name
        {
            get => name;
        }

        public int Numb { get; set; }
        public bool isClicked { get; set; }
        public ShapePoint FinishLocation { get; set; }
        public ShapePoint Location { get; set; }
        public PaintColor Color { get; set; }
        public ShapeSize Sizes { get; set; }

        public EShapeStatus EShapeStatus
        {
            get { return _eHsapeStatus; }
            protected set { _eHsapeStatus = value; }
        }

        public abstract void Draw(PaintGraphics graphics);

        public virtual void MouseClick(ShapePoint point)
        {
        }

        public virtual void MouseDown(ShapePoint point)
        {
            if (EShapeStatus == EShapeStatus.NOT_STARTED)
            {
                Location = new ShapePoint(point.ToPoint());
                FinishLocation = new ShapePoint(point.ToPoint());
                EShapeStatus = EShapeStatus.IN_PROGRESS;
            }
        }

        public virtual void MouseMove(ShapePoint point)
        {
            if (EShapeStatus == EShapeStatus.IN_PROGRESS)
            {
                FinishLocation = new ShapePoint(point.ToPoint());
            }
        }


        public virtual void MouseUp(ShapePoint point)
        {
            if (EShapeStatus == EShapeStatus.IN_PROGRESS)
            {
                FinishLocation = new ShapePoint(point.ToPoint());
                EShapeStatus = EShapeStatus.DONE;
            }
        }

        public void SelectShape(List<IShape> shapeList, MouseEventArgs e) { }
    }
}
