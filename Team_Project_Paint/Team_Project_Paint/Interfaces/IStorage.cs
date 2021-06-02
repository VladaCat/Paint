using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project_Paint.Interfaces
{
    public interface IStorage
    {
        void Add(IShape shape);

        void RemoveAt(int index);

        void Clear();

        void OpenJson(List<IShape> listJson);

        IShape GetLast();

        IShape GetShapeForIndex(int index);

        int GetCount();

        List<IShape> GetAll(); //возможно временный метод (позже уйдет)

    }
}
