using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Team_Project_Paint.Interfaces;
using Team_Project_Paint.PaintEnum;

namespace Team_Project_Paint.Class.OperationWithFigures
{
    public class BusinessLogic : IBusinessLogic
    {
        public IStorage _storage;
        private IShapeFactory _shape;
        private IShape _newshape;
        private IJsonLogic _jsonlogic;


        public int Numb { get; set; }

        public BusinessLogic(IStorage storage, IShapeFactory shape, IJsonLogic jsonLogic)
        {
            _storage = storage;
            _shape = shape;
            _jsonlogic = jsonLogic;
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

        public IShape GetSelectedShape()
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
            IShape shape = _storage.GetLast();
            return shape;
        }

        public bool isBoolCount()
        {
            return _storage.GetCount() > 0;
        }

        public bool IsSelectShape(ShapePoint e)
        {
            bool isSelect = false;

            for (int i = _storage.GetCount() - 1; i >= 0; i--)
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
            var update = new Update(_storage.GetAll(), paintBitmap);
            update.UpdatePicture();
        }

        public void UpdatePictureJson(PaintBitmap paintBitmap)
        {
            var update = new Update(_storage.GetAll(), paintBitmap);
            update.UpdatePictureJson();
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

        public bool JsonOpen(string jsonFile, PaintBitmap paintBitmap)
        {
            _jsonlogic.JsonDeserialize(jsonFile, _storage.GetAll());
            _storage.OpenJson(_jsonlogic.JsonList);
            UpdatePictureJson(paintBitmap);
            return true;
        }

        public void JsonSave(string fileName)
        {
            _jsonlogic.JsonSerialize(_storage.GetAll());
            File.WriteAllText(fileName, _jsonlogic.File);
        }

        public string RemoteSaveBitmap(PaintBitmap bitmap,string fileType)
        {
            Stream srcStream;
            byte[] srcArray;

            srcStream = new MemoryStream();
            EncoderParameters ec = new EncoderParameters();
            bitmap.Save(srcStream, ImageFormat.Png);

            srcStream.Position = 0;
            srcArray = new byte[srcStream.Length];
            srcStream.Read(srcArray, 0, Convert.ToInt32(srcStream.Length));

            var savedimage = Convert.ToBase64String(srcArray);

            return savedimage;
        }

        public void RemoteLoadBitmap(string image, PaintBitmap bitmap)
        {
            Stream dstStream;
            byte[] dstArray;

            dstArray = Convert.FromBase64String(image);

            dstStream = new MemoryStream(dstArray);

            //bitmap = Image.FromStream(dstStream);
        }
    }
}
