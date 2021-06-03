using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team_Project_Paint;
using Team_Project_Paint.Class;
using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.Interfaces;
using Team_Project_Paint.PaintEnum;

namespace PaintTests
{
    public class BussinesLogicTest
    {
        private IBusinessLogic _bl;
        private IStorage _storage;
        private IShapeFactory _shape;
        private IJsonLogic _jsonlogic;

        [SetUp]
        public void Setup()
        {
            _storage = new Storage();
            _shape = new ShapeFactory();
            _jsonlogic = new JsonLogic();
            _bl = new BusinessLogic(_storage, _shape, _jsonlogic);
        }

        [Test]
        public void InitTest()
        {
            IShape shape = new Rect();
            shape.Thickness = 20;
            shape.Color = new PaintColor(255, 222, 244);

            _bl.Init(EShapeType.Rect, 20, new PaintColor(255, 222, 244));

            var act = _storage.GetLast();

            Assert.AreEqual(shape.Color.ToColor(), act.Color.ToColor());
            Assert.AreEqual(shape.Thickness, act.Thickness);
            Assert.AreEqual(shape.Name, act.Name);
        }

        [Test]
        public void NewShapeTest()
        {
            IShape shape = new Hexagon();
            shape.Thickness = 20;
            shape.Color = new PaintColor(255, 222, 244);
            shape.Size = new ShapeSize(10, 50);

            _bl.NewShape(EShapeType.Hexagon, 20, new PaintColor(255, 222, 244), 4, new ShapeSize(10, 50));

            var act = _storage.GetLast();

            Assert.AreEqual(shape.Color.ToColor(), act.Color.ToColor());
            Assert.AreEqual(shape.Thickness, act.Thickness);
            Assert.AreEqual(shape.Name, act.Name);
            Assert.AreEqual(shape.Size.ToSize(), act.Size.ToSize());
        }

        [Test]

        public void GetSelectShapeTest()
        {
            Mock<IStorage> storage = new Mock<IStorage>(MockBehavior.Strict);
            Mock<IShape> shape = new Mock<IShape>(MockBehavior.Strict);
            storage.Setup(a => a.GetShapeForIndex(It.IsAny<int>())).Returns(shape.Object);
            storage.Setup(a => a.RemoveAt(It.IsAny<int>()));
            IBusinessLogic bl = new BusinessLogic(storage.Object, null, null);
            IShape actualShape = bl.GetSelectedShape();
            Assert.AreSame(shape.Object, actualShape);
            storage.Verify(a => a.GetShapeForIndex(It.IsAny<int>()), Times.Once);
            storage.Verify(a => a.RemoveAt(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void AddSelectShape()
        {
            Mock<IStorage> storage = new Mock<IStorage>(MockBehavior.Strict);
            Mock<IShape> shape = new Mock<IShape>(MockBehavior.Strict);
            IBusinessLogic bl = new BusinessLogic(storage.Object, null, null);
            storage.Setup(a => a.Add(It.IsAny<IShape>()));

            bl.AddSelectShape(shape.Object);

            storage.Verify(a => a.Add(It.IsAny<IShape>()), Times.Once);
        }

        [Test]

        public void ClearTest()
        {
            Mock<IStorage> storage = new Mock<IStorage>(MockBehavior.Strict);
            IBusinessLogic bl = new BusinessLogic(storage.Object, null, null);

            storage.Setup(a => a.Clear());

            bl.Clear();

            storage.Verify(a => a.Clear(), Times.Once);
        }

        [Test]

        public void LastTest()
        {
            Mock<IStorage> storage = new Mock<IStorage>(MockBehavior.Strict);
            Mock<IShape> shape = new Mock<IShape>(MockBehavior.Strict);
            storage.Setup(a => a.GetLast()).Returns(shape.Object);

            IBusinessLogic bl = new BusinessLogic(storage.Object, null, null);
            IShape actualShape = bl.Last();
            Assert.AreSame(shape.Object, actualShape);

            storage.Verify(a => a.GetLast(), Times.Once);
        }

        //[Test]
        //public void isBoolCountTest()
        //{
        //    Mock<IStorage> storage = new Mock<IStorage>(MockBehavior.Strict);
        //    storage.Setup(a => a.GetCount() > 0).Returns(It.IsAny<bool>());

        //    IBusinessLogic bl = new BusinessLogic(storage.Object, null, null);
        //    bool act = bl.isBoolCount();

        //    Assert.AreSame(It.IsAny<bool>(), act);

        //    storage.Verify(a => a.GetCount(), Times.Once);

        //}

    }
}
