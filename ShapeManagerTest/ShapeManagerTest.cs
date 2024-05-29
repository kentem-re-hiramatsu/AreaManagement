using AreaManagement;
using AreaManagement.Controller;
using AreaManagement.Model;
using AreaManagement1.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapeManagerTest.Test
{
    [TestClass]
    public class ShapeManagerUnitTest
    {
        ShapeManager shapeMana = new ShapeManager();

        /// <summary>
        /// 正しく三角形のGetShapeができているか
        /// </summary>
        [TestMethod]
        public void TriangleGetShpaeTest()
        {
            Triangle triangle = new Triangle(1);
            shapeMana.AddShapeList(triangle);
            var shape = shapeMana.GetShape(0);

            Assert.AreEqual(shape.GetShapeName(), ShapeNameEnum.三角形);
        }

        /// <summary>
        /// 正しく四角形のGetShapeができているか
        /// </summary>
        [TestMethod]
        public void QuadGetShapeTest()
        {
            Quadrilarea quad = new Quadrilarea(1);
            shapeMana.AddShapeList(quad);
            var shape = shapeMana.GetShape(0);

            Assert.AreEqual(shape.GetShapeName(), ShapeNameEnum.四角形);
        }

        /// <summary>
        /// 正しく台形のGetShapeができているか
        /// </summary>
        [TestMethod]
        public void TrapezoidGetShapeTest()
        {
            Trapezoid trapeziod = new Trapezoid(1, 1, 1);
            shapeMana.AddShapeList(trapeziod);
            var shape = shapeMana.GetShape(0);

            Assert.AreEqual(shape.GetShapeName(), ShapeNameEnum.台形);
        }

        /// <summary>
        /// 正しくShapeListに複数図形が追加されるか
        /// </summary>
        [TestMethod]
        public void ShapesAddTest()
        {
            Trapezoid trapeziod = new Trapezoid(1, 2, 3);
            Triangle triangle = new Triangle(3);
            Quadrilarea quad = new Quadrilarea(3);

            var shapeListCount = shapeMana.GetShapeListCount();
            Assert.AreEqual(shapeListCount, 0);

            shapeMana.AddShapeList(trapeziod);
            shapeMana.AddShapeList(triangle);
            shapeMana.AddShapeList(quad);

            shapeListCount = shapeMana.GetShapeListCount();
            Assert.AreEqual(shapeListCount, 3);
        }

        /// <summary>
        ///正しくListが削除されているか
        /// </summary>
        [TestMethod]
        public void RemovedListTest()
        {
            Trapezoid trapeziod = new Trapezoid(1, 2, 3);
            Triangle triangle = new Triangle(3);
            Quadrilarea quad = new Quadrilarea(3);

            shapeMana.AddShapeList(trapeziod);
            shapeMana.AddShapeList(triangle);
            shapeMana.AddShapeList(quad);

            var shapeListCount = shapeMana.GetShapeListCount();
            Assert.AreEqual(shapeListCount, 3);

            shapeMana.RemoveShapeAtIndex(0);

            shapeListCount = shapeMana.GetShapeListCount();
            Assert.AreEqual(shapeListCount, 2);

        }
    }
}

