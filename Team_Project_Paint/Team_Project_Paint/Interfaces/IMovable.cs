using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Project_Paint.Interfaces
{
   public interface IMovable
    {
        int Numb { get; set; }
        bool IsSelected { get; set; }
        void SelectShape(List<IShape> shapeList, MouseEventArgs e);
        void Move(int dx, int dy, IShape shape);

    }
}
