using System.Collections.Generic;
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
        public int Thickness { get; set;}
        public EShapeType Name
        {
            get => name;
        }
        

        public int Numb { get; set; }
        public bool IsSelected { get; set; }
        public ShapePoint FinishLocation { get; set; }
        public ShapePoint Location { get; set; }
        public PaintColor Color { get; set; }
        public ShapeSize Size { get; set; }

        public EShapeStatus EShapeStatus
        {
            get { return _eHsapeStatus; }
            set { _eHsapeStatus = value; }
        }

        
        public List<ShapePoint> ShapePoints { get; set; }

        public abstract void Draw(PaintGraphics graphics);

        public virtual PaintRectangle GetBoundingBox()
        {
            int x, y, height, width;

            if ((Location.X) < (FinishLocation.X))
            {
                x = Location.X;
                width = FinishLocation.X - Location.X;
            }
            else
            {
                x = FinishLocation.X;
                width = Location.X - FinishLocation.X;

            }

            if ((Location.Y)<(FinishLocation.Y))
            {
                y = Location.Y;
                height = FinishLocation.Y - Location.Y;
            }
            else
            {
                y = FinishLocation.Y;
                height = Location.Y - FinishLocation.Y;
            }


            return new PaintRectangle(x, y, width, height);

        }

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
    }
}
