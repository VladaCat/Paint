using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.PaintEnum;

namespace Team_Project_Paint.Class
{
    public abstract class AbstractRectangleStyle : AbstractShape
    {
        protected bool isFinished = false;

        protected bool isStarted = false;

        public AbstractRectangleStyle(EShapeType Name) : base(Name) { }
        public abstract override void Draw(PaintGraphics graphics);
        public override bool IsFinished()
        {
            return isFinished;
        }

        public override void DrawTemp(PaintGraphics graphics)
        {
            Draw(graphics);
        }

        public override void MouseDown(ShapePoint point)
        {
            if (!isFinished && !isStarted)
            {
                Location =new ShapePoint(point.ToPoint());
                FinishLocation = new ShapePoint(point.ToPoint());
                isStarted = true;
            }
        }
        public override void MouseMove(ShapePoint point)
        {
            if (!isFinished && isStarted)
            {
                FinishLocation = new ShapePoint(point.ToPoint());
            }
        }
        public override void MouseUp(ShapePoint point)
        {
            if (!isFinished && isStarted)
            {
                FinishLocation =new ShapePoint(point.ToPoint());
                isFinished = true;
            }
        }
    }
}
