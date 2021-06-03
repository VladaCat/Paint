using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team_Project_Paint.Class.OperationWithFigures;

namespace PaintTests
{
    public class ShapeSizeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetSetTests()
        {

            ShapePoint shapePoint = new ShapePoint(10, 20);
            Assert.AreEqual(10, shapePoint.X);
            Assert.AreEqual(20, shapePoint.Y);

            Point point = shapePoint.ToPoint();
            Assert.AreEqual(10, point.X);
            Assert.AreEqual(20, point.Y);

        }

        [Test]
        public void ConstructorPointTest()
        {
            ShapePoint shapePoint = new ShapePoint(new Point(20, 30));
            Assert.AreEqual(20, shapePoint.X);
            Assert.AreEqual(30, shapePoint.Y);

            Point point = shapePoint.ToPoint();
            Assert.AreEqual(20, point.X);
            Assert.AreEqual(30, point.Y);
        }

    }
}
