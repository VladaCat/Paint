using System.Collections.Generic;

namespace Team_Project_Paint.Interfaces
{
    public interface IJsonLogic
    {

        List<IShape> JsonList { get; set; }
        string File { get; set; }

        void JsonDeserialize(string jsonfile, List<IShape> shapeList);

        void JsonSerialize(List<IShape> shapeList);
    }
}
