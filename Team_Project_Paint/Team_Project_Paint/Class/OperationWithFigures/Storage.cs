using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team_Project_Paint.Interfaces;

namespace Team_Project_Paint.Class.OperationWithFigures
{
    public class Storage : IStorage
    {
        private List<IShape> _shapeList = new List<IShape>();



        public void Add(IShape shape)
        {
            _shapeList.Add(shape);
        }

        public void Clear()
        {
            _shapeList.Clear();
        }

        public List<IShape> GetAll()
        {
            return _shapeList;
        }

        public int GetCount()
        {
            return _shapeList.Count;
        }

        public IShape GetLast()
        {
            return _shapeList.Last();
        }

        public IShape GetShapeForIndex(int index)
        {
            return _shapeList[index];
        }

        public void OpenJson(List<IShape> listJson)
        {
            _shapeList = listJson;
        }

        public void RemoveAt(int index)
        {
            _shapeList.RemoveAt(index);
        }
    }
}
