using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team_Project_Paint.Interfaces;

namespace Team_Project_Paint.Class
{
   public abstract class AbstractShape:IShape
    {
        private int thickness;
        private Color color;
        private string name;
        public AbstractShape(string name)
        {
            this.name = name;
        }   
        public virtual int Thickness 
        { 
            get => thickness;
            set => thickness=value;
        }
        public virtual String Name 
        {
            get => name;
        }
        public virtual Color Color 
        { 
            get => color;
            set => color = value;
        }

        public abstract void Draw(Graphics graphics);
        public abstract void DrawTemp(Graphics graphics);

        public abstract bool IsFinished();
      

        public virtual void MouseClick(object sender, MouseEventArgs e) { }


        public virtual void MouseDown(object sender, MouseEventArgs e) { }
      


        public virtual void MouseMove(object sender, MouseEventArgs e) { }


        public virtual void MouseUp(object sender, MouseEventArgs e) { }
    
    }
}
