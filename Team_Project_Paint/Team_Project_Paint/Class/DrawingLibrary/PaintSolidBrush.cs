using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project_Paint.Class.OperationWithFigures
{
    public class PaintSolidBrush
    {
        private Brush _brush;

        public PaintSolidBrush(PaintColor color)
        {
            _brush = new SolidBrush(color.ToColor());
        }
        public Brush toBrush()
        {
            return _brush;
        }
    }
}
