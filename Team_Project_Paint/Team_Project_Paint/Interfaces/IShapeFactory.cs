using Team_Project_Paint.PaintEnum;

namespace Team_Project_Paint.Interfaces
{
    public interface IShapeFactory
    {
        IShape CreateShape(EShapeType currentMode);
    }
}
