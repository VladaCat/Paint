using NUnit.Framework;
using System.Drawing;
using Team_Project_Paint.Class;
using Team_Project_Paint.Class.OperationWithFigures;

namespace PaintTests
{

    public class PaintImigeTest
    {


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ToImageTest()
        {
            Image image = new Bitmap(1, 1);
            PaintImage paintImage = new PaintBitmap(image);
            Image actualImage = paintImage.ToImage();
            Assert.AreSame(image, actualImage);
            Assert.AreEqual(1, actualImage.Width);
            Assert.AreEqual(1, actualImage.Height);

            paintImage = new PaintBitmap(100, 100);
            actualImage = paintImage.ToImage();
            Assert.AreEqual(100, actualImage.Width);
            Assert.AreEqual(100, actualImage.Height);

        }


        [Test]
        public void CloneTest()
        {
            Image image = new Bitmap(1, 1);
            PaintImage paintImage = new PaintBitmap(image);
            PaintImage actualImage = paintImage.Clone() as PaintImage;
            Assert.AreNotSame(paintImage, actualImage);
            Image actuaPaintlImage = actualImage.ToImage();
            Assert.AreNotSame(actuaPaintlImage, image);
            Assert.AreEqual(1, actuaPaintlImage.Width);
            Assert.AreEqual(1, actuaPaintlImage.Height);

        }

    }
}