using Newtonsoft.Json;
using System.Collections.Generic;
using Team_Project_Paint.PaintEnum;

namespace Team_Project_Paint.Class.OperationWithFigures
{
    class ShapeListDTO
    {
        [JsonProperty]
        public int Thickness { get; set; }

        [JsonProperty]
        public ShapePoint FinishLocation { get; set; }

        [JsonProperty]
        public ShapePoint Location { get; set; }

        [JsonProperty]
        public PaintColor Color { get; set; }

        [JsonProperty]
        public ShapeSize Size { get; set; }

        [JsonProperty]
        public int Cornes { get; set; }

        [JsonProperty]
        public EShapeType Name { get; set; }

        [JsonProperty]

        public List<ShapePoint> ShapePoints { get; set; }
    }
}
