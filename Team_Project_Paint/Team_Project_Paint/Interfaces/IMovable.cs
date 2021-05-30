using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team_Project_Paint.Class.OperationWithFigures;

namespace Team_Project_Paint.Interfaces
{
   public interface IMovable
    {
        int Numb { get; set; }
        bool IsSelected { get; set; }
        void SelectShape(List<IShape> shapeList, ShapePoint e);
        void Move(int dx, int dy, IShape shape);

    }
}
