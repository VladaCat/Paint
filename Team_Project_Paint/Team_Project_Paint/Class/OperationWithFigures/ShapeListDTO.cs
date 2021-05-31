using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public EShapeType Name { get; set; }
    }
}
