using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team_Project_Paint.Enum;
using Team_Project_Paint.Interfaces;

namespace Team_Project_Paint.Class
{
    public abstract class AbstractShape : IShape
    {
        private NameForShapeFactory name;
        public AbstractShape(NameForShapeFactory name)
        {
            this.name = name;
        }
        public virtual int Thickness
        {
            get;
            set;
        }
        public virtual NameForShapeFactory Name
        {
            get => name;
        }
        public virtual Color Color
        {
            get;
            set;
        }

        public int Numb { get; set; }
        public bool isClicked { get; set; }
        public Point FinishLocation { get; set; }
        public Point Location { get; set; }

        public abstract void Draw(Graphics graphics);
        public abstract void DrawTemp(Graphics graphics);

        public abstract bool IsFinished();


        public virtual void MouseClick(object sender, MouseEventArgs e) { }


        public virtual void MouseDown(object sender, MouseEventArgs e) { }


        public virtual void MouseMove(object sender, MouseEventArgs e) { }


        public virtual void MouseUp(object sender, MouseEventArgs e) { }

        public virtual void SelectShape(List<IShape> shapeList, MouseEventArgs e) { }
    }
}
