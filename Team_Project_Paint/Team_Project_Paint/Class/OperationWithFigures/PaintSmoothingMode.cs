using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project_Paint.Class.OperationWithFigures
{

    public class PaintSmoothingMode
    {
       
    }
      public enum EPaintSmoothingMode
    {
        Invalid = -1,
      
        Default = 0,
       
        HighSpeed = 1,
      
        HighQuality = 2,
        None = 3,
        AntiAlias = 4
    }
}
