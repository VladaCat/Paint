using Team_Project_Paint.Class;
using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.PaintEnum;

namespace Team_Project_Paint.Interfaces
{
    public interface IBusinessLogic
    {
        int Numb { get; set; }

        void Move(int dx, int dy, IShape shape);

        void Init(EShapeType type, int thickness, PaintColor color);

        void NewShape(EShapeType type, int thickness, PaintColor color, int cornes, ShapeSize size);

        IShape GetSelectedShape();

        void Delete(PaintBitmap paintBitmap);

        void AddSelectShape(IShape shape);

        void ChangeFigureColor(PaintBitmap paintBitmap, PaintColor color);

        void ChanhgeFirgureThickness(PaintBitmap paintBitmap, int thickness);

        void Clear();

        IShape Last();

        bool isBoolCount();

        bool IsSelectShape(ShapePoint e);
        IShape SelectedFigure { get; set; }

        void UpdatePicture(PaintBitmap paintBitmap);

    }
}
