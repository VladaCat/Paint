using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team_Project_Paint.PaintEnum;

namespace Team_Project_Paint.Interfaces
{
    public interface IShapeFactory
    {
        IShape CreateShape(EShapeType currentMode);
    }
}
