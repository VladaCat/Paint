using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project_Paint.Class
{
    public class PaintColor
    {
        public int A { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public PaintColor(int red, int green, int blue)
            : this(red, green, blue, 255) { }
        public PaintColor(Color color)
            : this(color.R, color.G, color.B, color.A) { }
        public PaintColor(int red, int green, int blue, int alpha)
        {
            R = red;
            G = green;
            B = blue;
            A = alpha;
        }

        public Color ToColor()
        {
            return Color.FromArgb(A, R, G, B);
        }
    }
}
