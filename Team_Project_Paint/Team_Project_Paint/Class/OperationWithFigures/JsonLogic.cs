using Newtonsoft.Json;

using System.Collections.Generic;
using Team_Project_Paint.Interfaces;
using Team_Project_Paint.PaintEnum;

namespace Team_Project_Paint.Class.OperationWithFigures
{
    public class JsonLogic : IJsonLogic
    {
        public string File { get; set; }

        public List<IShape> JsonList { get; set; }

        public void JsonSerialize(List<IShape> shapeList)
        {
            var obj = JsonConvert.SerializeObject(shapeList);
            File = obj;

        }


        public void JsonDeserialize(string jsonfile, List<IShape> shapeList)
        {
            var www = JsonConvert.DeserializeObject<List<ShapeListDTO>>(jsonfile);
            var listNew = CreateList(www);
            JsonList = listNew;
        }

        private List<IShape> CreateList(List<ShapeListDTO> www)
        {
            var list = new List<IShape>();
            foreach (var item in www)
            {
                switch (item.Name)
                {
                    case EShapeType.Rect:
                        list.Add(new Rect()
                        {
                            Color = item.Color,
                            Thickness = item.Thickness,
                            FinishLocation = item.FinishLocation,
                            Location = item.Location,
                        });
                        break;
                    case EShapeType.Dot:
                        list.Add(new Dot()
                        {
                            Color = new PaintColor(System.Drawing.Color.Black),
                            Thickness = item.Thickness,
                            FinishLocation = item.FinishLocation,
                            Location = item.Location,
                        });
                        break;
                    case EShapeType.Ellipse:
                        list.Add(new Ellipse()
                        {
                            Color = item.Color,
                            Thickness = item.Thickness,
                            FinishLocation = item.FinishLocation,
                            Location = item.Location,
                        });
                        break;
                    case EShapeType.Hexagon:
                        list.Add(new Hexagon()
                        {
                            Color = item.Color,
                            Thickness = item.Thickness,
                            FinishLocation = item.FinishLocation,
                            Location = item.Location,
                            Size = item.Size,
                            Cornes = item.Cornes,

                        });
                        break;
                    case EShapeType.Line:
                        list.Add(new Line()
                        {
                            Color = item.Color,
                            Thickness = item.Thickness,
                            FinishLocation = item.FinishLocation,
                            Location = item.Location,
                        });
                        break;
                    case EShapeType.RoundingRect:
                        list.Add(new RoundingRect()
                        {
                            Color = item.Color,
                            Thickness = item.Thickness,
                            FinishLocation = item.FinishLocation,
                            Location = item.Location,
                        });
                        break;
                    case EShapeType.Curve:
                        list.Add(new Curve()
                        {
                            Color = item.Color,
                            Thickness = item.Thickness,
                            FinishLocation = item.FinishLocation,
                            Location = item.Location,
                        });
                        break;
                    case EShapeType.Triangle:
                        list.Add(new Triangle()
                        {
                            Color = item.Color,
                            Thickness = item.Thickness,
                            FinishLocation = item.FinishLocation,
                            Location = item.Location,
                        });
                        break;
                    default:
                        break;
                }
            }
            return list;
        }
    }
}
