using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project_Paint.Interfaces
{
    public interface IBL
    {
        int Numb { get; set; }

        void Move(int dx, int dy, IShape shape);
    }
}
