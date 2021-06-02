using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team_Project_Paint.Interfaces;
using Team_Project_Paint.PaintEnum;

namespace Team_Project_Paint.Class.OperationWithFigures
{
    public class BL : IBL
    {
        private IStorage _storage;
        private IShapeFactory _shape;
        private IShape _newshape;

        public int Numb { get; set; }

        public BL(IStorage storage, IShapeFactory shape)
        {
            _storage = storage;
            _shape = shape;
        }

        public void Init(EShapeType type, int thickness, PaintColor color)
        {
            _newshape = _shape.CreateShape(type);
            _newshape.Thickness = thickness;
            _newshape.Color = color;

            _storage.Add(_newshape);

        }


        public void NewShape(EShapeType type, int thickness, PaintColor color, int cornes, ShapeSize size)
        {
            _newshape = _shape.CreateShape(type);
            _newshape.Thickness = thickness;
            _newshape.Color = color;

            if (_newshape is Hexagon)
            {
                (_newshape as Hexagon).Cornes = cornes;
                (_newshape as Hexagon).Size = size;
            }
            _storage.Add(_newshape);
        }

        public IShape IsSelectShape()
        {
            IShape shape = _storage.GetShapeForIndex(Numb);
            _storage.RemoveAt(Numb);
            return shape;
        }

        public void Delete(PaintBitmap paintBitmap)
        {
            _storage.RemoveAt(Numb);
            UpdatePicture(paintBitmap);
        }

        public void AddSelectShape(IShape shape)
        {
            _storage.Add(shape);
        }

        public void ChangeFigureColor(PaintBitmap paintBitmap, PaintColor color)
        {
            IShape shape = _storage.GetShapeForIndex(Numb);
            _storage.RemoveAt(Numb);
            shape.Color = color;
            _storage.Add(shape);
            UpdatePicture(paintBitmap);
            Numb = _storage.GetCount() - 1;
        }

        public void ChanhgeFirgureThickness(PaintBitmap paintBitmap, int thickness)
        {
            IShape shape = _storage.GetShapeForIndex(Numb);
            _storage.RemoveAt(Numb);
            shape.Thickness = thickness;
            _storage.Add(shape);
            UpdatePicture(paintBitmap);
            Numb = _storage.GetCount() - 1;
        }

       public void Clear()
        {
            _storage.Clear();
        }

        public IShape Last()
        {
            return _storage.GetLast();
        }

        public bool GetBoolCount()
        {
            return _storage.GetCount() > 0;
        }

        public bool SelectShape(ShapePoint e)
        {
            bool isSelect = false;

            for (int i = 0; i < _storage.GetCount(); i++)
            {
                var tmp = _storage.GetShapeForIndex(i);

                if (tmp.Name == EShapeType.Dot && !isSelect)
                {
                    if ((e.X >= tmp.Location.X - tmp.Thickness / 2 && e.X <= tmp.Location.X + tmp.Thickness))
                    {
                        if ((e.Y >= tmp.Location.Y - tmp.Thickness / 2 && e.Y <= tmp.Location.Y + tmp.Thickness))
                        {
                            isSelect = true;
                            Numb = i;
                        }
                        else
                        {
                            isSelect = false;
                        }
                    }
                }
                if (tmp.Location != null && tmp.FinishLocation != null)
                {
                    if (((e.X < tmp.FinishLocation.X) && (e.X > tmp.Location.X)) && tmp.Name != EShapeType.Dot && !isSelect || ((e.X > tmp.FinishLocation.X) && (e.X < tmp.Location.X) && tmp.Name != EShapeType.Dot && !isSelect))
                    {
                        if (((e.Y < tmp.FinishLocation.Y) && (e.Y > tmp.Location.Y)) || ((e.Y > tmp.FinishLocation.Y) && (e.Y < tmp.Location.Y)))
                        {
                            isSelect = true;
                            Numb = i;
                        }
                        else
                        {
                            isSelect = false;
                        }
                    }
                }
            }

            return isSelect;
        }

        public void UpdatePicture(PaintBitmap paintBitmap)
        {
            var update = new ChangeOperation(_storage.GetAll(), paintBitmap);
            update.UpdatePicture();
        }

        public void Move(int dx, int dy, IShape shape)
        {
            int startX = shape.Location.X + dx;
            int startY = shape.Location.Y + dy;

            if (shape.FinishLocation != null)
            {
                int finX = shape.FinishLocation.X + dx;
                int finY = shape.FinishLocation.Y + dy;

                ShapePoint finish = new ShapePoint(finX, finY);
                shape.FinishLocation = finish;
            }
            else
            {
                shape.FinishLocation = null;
            }

            ShapePoint start = new ShapePoint(startX, startY);


            shape.Location = start;
        }
    }
}
