using NUnit.Framework;
using System.Drawing;
using Team_Project_Paint.Class;
using Team_Project_Paint.Class.OperationWithFigures;

namespace PaintTests
{

    public class ShapePointFTests
    {


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetSetTests()
        {

            ShapePointF shapePointF = new ShapePointF(10,20);
            Assert.AreEqual(10, shapePointF.X);
            Assert.AreEqual(20, shapePointF.Y);

            PointF point = shapePointF.ToPointF();
            Assert.AreEqual(10, point.X);
            Assert.AreEqual(20, point.Y);

        }

        [Test]
        public void ConstructorPointTest()
        {
            ShapePointF shapePointF = new ShapePointF(new PointF(20, 30));
            Assert.AreEqual(20, shapePointF.X);
            Assert.AreEqual(30, shapePointF.Y);

            PointF point = shapePointF.ToPointF();
            Assert.AreEqual(20, point.X);
            Assert.AreEqual(30, point.Y);
        }

    }
}