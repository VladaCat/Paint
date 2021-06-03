using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using Team_Project_Paint.Class;
using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.Interfaces;
using Team_Project_Paint.PaintEnum;

namespace PaintTests
{
    public class StorageTests
    {
        private IStorage _storage;
        private IShapeFactory _factory;

        [SetUp]
        public void Setup()
        {
            _storage = new Storage();
            _factory = new ShapeFactory();
        }

        [TestCase(EShapeType.Dot)]
        [TestCase(EShapeType.Curve)]
        [TestCase(EShapeType.Ellipse)]
        [TestCase(EShapeType.Hexagon)]
        [TestCase(EShapeType.Line)]
        [TestCase(EShapeType.Rect)]
        [TestCase(EShapeType.RoundingRect)]
        [TestCase(EShapeType.Triangle)]
        public void AddTestCase(EShapeType type)
        {
            IShape exp = _factory.CreateShape(type);

            _storage.Add(exp);

            var act = _storage.GetShapeForIndex(0);

            Assert.AreSame(exp, act);
        }

        [Test]
        public void ClearTest()
        {
            IShape shape = new Rect();

            _storage.Add(shape);
            _storage.Add(shape);
            _storage.Add(shape);
            _storage.Add(shape);

            _storage.Clear();

            var act = _storage.GetCount();

            Assert.AreEqual(0, act);
        }

        [Test]
        public void GetAllTest()
        {
            List<IShape> _shapeList = new List<IShape>();

            var exp = _shapeList;

            var act = _storage.GetAll();

            Assert.AreEqual(exp, act);
        }

        [Test]
        public void GetCountTest()
        {
            IShape shape = new Rect();

            _storage.Add(shape);
            _storage.Add(shape);
            _storage.Add(shape);
            _storage.Add(shape);


            var act = _storage.GetCount();

            Assert.AreEqual(4, act);
        }

        [Test]
        public void GetLastTest()
        {
            IShape shape = new Rect();
            IShape shape2 = new Rect();

            _storage.Add(shape);
            _storage.Add(shape2);


            var act = _storage.GetLast();

            Assert.AreSame(shape2, act);
        }

        [Test]
        public void GetShapeForIndexTest()
        {
            IShape shape = new Rect();
            IShape shape2 = new Dot();
            IShape shape3 = new Line();
            IShape shape4 = new Curve();

            _storage.Add(shape);
            _storage.Add(shape2);
            _storage.Add(shape3);
            _storage.Add(shape4);

            var act = _storage.GetShapeForIndex(0);
            Assert.AreSame(shape, act);

            act = _storage.GetShapeForIndex(1);
            Assert.AreSame(shape2, act);

            act = _storage.GetShapeForIndex(2);
            Assert.AreSame(shape3, act);

            act = _storage.GetShapeForIndex(3);
            Assert.AreSame(shape4, act);
        }

        [Test]
        public void OpenJson()
        {
            IShape shape4 = new Curve();
            List<IShape> _shapeList = new List<IShape>();
            _shapeList.Add(shape4);

            _storage.OpenJson(_shapeList);

            var exp = _storage.GetAll();

            var act = _shapeList;

            Assert.AreSame(exp, act);
        }

        [Test]
        public void RemoveAtIndexTest()
        {
            IShape shape = new Rect();
            IShape shape2 = new Dot();
            IShape shape3 = new Line();
            IShape shape4 = new Curve();

            _storage.Add(shape);
            _storage.Add(shape2);
            _storage.Add(shape3);
            _storage.Add(shape4);

            _storage.RemoveAt(0);

            var act = _storage.GetShapeForIndex(0);
            var act2 = _storage.GetCount();
            Assert.AreSame(shape2, act);
            Assert.AreEqual(3, act2);
        }

        [Test]
        public void AddMockTest()
        {
            IStorage storage = new Storage();
            IShape ShapeMock = new Mock<IShape>(MockBehavior.Strict).Object;
            storage.Add(ShapeMock);
            Assert.AreEqual(1, storage.GetCount());
            Assert.AreSame(ShapeMock, storage.GetLast());
        }

        [Test]
        public void ClearMockTest()
        {
            IStorage storage = new Storage();
            IShape ShapeMock = new Mock<IShape>(MockBehavior.Strict).Object;
            storage.Add(ShapeMock);
            Assert.AreEqual(1, storage.GetCount());
            storage.Clear();
            Assert.AreEqual(0, storage.GetCount());

            storage.Clear();
            Assert.AreEqual(0, storage.GetCount());

            for (int i = 0; i < 100; i++)
            {
                storage.Add(ShapeMock);
            }
            Assert.AreEqual(100, storage.GetCount());
            storage.Clear();
            Assert.AreEqual(0, storage.GetCount());
        }

        [Test]
        public void GetAllWithOneElement()
        {
            IStorage storage = new Storage();
            IList<IShape> expectedShapeList = new List<IShape>();
            IShape ShapeMock = new Mock<IShape>(MockBehavior.Strict).Object;
            storage.Add(ShapeMock);
            expectedShapeList.Add(ShapeMock);
            IList<IShape> actualShapeList = storage.GetAll();
            Assert.AreEqual(expectedShapeList.Count, actualShapeList.Count);
            for (int i = 0; i < expectedShapeList.Count; i++)
            {
                Assert.AreSame(expectedShapeList[i], actualShapeList[i]);
            }

        }

        [Test]
        public void GetAllWith100Elements()
        {
            IStorage storage = new Storage();
            IList<IShape> expectedShapeList = new List<IShape>();
            for (int i = 0; i < 100; i++)
            {
                IShape ShapeMock = new Mock<IShape>(MockBehavior.Strict).Object;
                storage.Add(ShapeMock);
                expectedShapeList.Add(ShapeMock);
            }
            IList<IShape> actualShapeList = storage.GetAll();
            Assert.AreEqual(expectedShapeList.Count, actualShapeList.Count);
            for (int i = 0; i < expectedShapeList.Count; i++)
            {
                Assert.AreSame(expectedShapeList[i], actualShapeList[i]);
            }

        }


        [Test]
        public void GetLastMockTest()
        {
            IShape ShapeMock = new Mock<IShape>(MockBehavior.Strict).Object;
            _storage.Add(ShapeMock);
            Assert.AreSame(ShapeMock, _storage.GetLast());
        }

    }
}
