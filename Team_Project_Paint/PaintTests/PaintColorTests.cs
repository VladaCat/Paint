using NUnit.Framework;
using System.Drawing;
using Team_Project_Paint.Class;

namespace PaintTests
{

    public class PaintColorTests
    {


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetSetTests()
        {
            PaintColor paintColor = new PaintColor();
            Assert.AreEqual(0, paintColor.A);
            Assert.AreEqual(0, paintColor.R);
            Assert.AreEqual(0, paintColor.G);
            Assert.AreEqual(0, paintColor.B);

            Color color = paintColor.ToColor();
            Assert.AreEqual(0, color.A);
            Assert.AreEqual(0, color.R);
            Assert.AreEqual(0, color.G);
            Assert.AreEqual(0, color.B);

            paintColor.A = 255;
            paintColor.R = 100;
            paintColor.G = 50;
            paintColor.B = 67;

            Assert.AreEqual(255, paintColor.A);
            Assert.AreEqual(100, paintColor.R);
            Assert.AreEqual(50, paintColor.G);
            Assert.AreEqual(67, paintColor.B);

            color = paintColor.ToColor();
            Assert.AreEqual(255, color.A);
            Assert.AreEqual(100, color.R);
            Assert.AreEqual(50, color.G);
            Assert.AreEqual(67, color.B);
        }

        [Test]
        public void ConstructorARGBTest()
        {
            PaintColor paintColor = new PaintColor(20, 30, 35, 40);
            Assert.AreEqual(40, paintColor.A);
            Assert.AreEqual(20, paintColor.R);
            Assert.AreEqual(30, paintColor.G);
            Assert.AreEqual(35, paintColor.B);

            Color color = paintColor.ToColor();
            Assert.AreEqual(40, color.A);
            Assert.AreEqual(20, color.R);
            Assert.AreEqual(30, color.G);
            Assert.AreEqual(35, color.B);
        }

        [Test]
        public void ConstructorColorTest()
        {
            PaintColor paintColor = new PaintColor(Color.FromArgb(40, 20, 30, 35));
            Assert.AreEqual(40, paintColor.A);
            Assert.AreEqual(20, paintColor.R);
            Assert.AreEqual(30, paintColor.G);
            Assert.AreEqual(35, paintColor.B);

            Color color = paintColor.ToColor();
            Assert.AreEqual(40, color.A);
            Assert.AreEqual(20, color.R);
            Assert.AreEqual(30, color.G);
            Assert.AreEqual(35, color.B);
        }

        [Test]
        public void ConstructorRGBTest()
        {
            PaintColor paintColor = new PaintColor(20, 30, 35);
            Assert.AreEqual(255, paintColor.A);
            Assert.AreEqual(20, paintColor.R);
            Assert.AreEqual(30, paintColor.G);
            Assert.AreEqual(35, paintColor.B);

            Color color = paintColor.ToColor();
            Assert.AreEqual(255, color.A);
            Assert.AreEqual(20, color.R);
            Assert.AreEqual(30, color.G);
            Assert.AreEqual(35, color.B);
        }

    }
}