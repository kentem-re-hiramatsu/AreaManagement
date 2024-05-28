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
            Triangle triangle = new Triangle(3);
            shapeMana.AddShapeList(triangle);
            var shape = shapeMana.GetShape(0);

            Assert.AreEqual(shape.GetArea(), 3.8971);
            Assert.AreEqual(shape.GetShapeName(), ShapeNameEnum.三角形);
        }

        /// <summary>
        /// 正しく四角形のGetShapeができているか
        /// </summary>
        [TestMethod]
        public void QuadGetShapeTest()
        {
            Quadrilarea quad = new Quadrilarea(5.123);
            shapeMana.AddShapeList(quad);
            var shape = shapeMana.GetShape(0);

            Assert.AreEqual(shape.GetArea(), 26.2451);
            Assert.AreEqual(shape.GetShapeName(), ShapeNameEnum.四角形);
        }

        /// <summary>
        /// 正しく台形のGetShapeができているか
        /// </summary>
        [TestMethod]
        public void TrapezoidGetShapeTest()
        {
            Trapezoid trapeziod = new Trapezoid(2.1, 2.1, 2.1);
            shapeMana.AddShapeList(trapeziod);
            var shape = shapeMana.GetShape(0);

            Assert.AreEqual(shape.GetArea(), 4.41);
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

            shapeMana.AddShapeList(trapeziod);
            shapeMana.AddShapeList(triangle);
            shapeMana.AddShapeList(quad);

            var shapeTrapeziod = shapeMana.GetShape(0);
            var shapeTriangle = shapeMana.GetShape(1);
            var shapeQuad = shapeMana.GetShape(2);

            Assert.AreEqual(shapeTrapeziod.GetShapeName(), ShapeNameEnum.台形);
            Assert.AreEqual(shapeTriangle.GetShapeName(), ShapeNameEnum.三角形);
            Assert.AreEqual(shapeQuad.GetShapeName(), ShapeNameEnum.四角形);

            //台形の面積は4.5
            Assert.AreEqual(shapeTrapeziod.GetArea(), 4.5);
            //三角形の面積は3.89711
            Assert.AreEqual(shapeTriangle.GetArea(), 3.8971);
            //四角形の面積は9
            Assert.AreEqual(shapeQuad.GetArea(), 9);

            //三つの面積の合計値
            var sumArea = shapeMana.GetSumArea();
            Assert.AreEqual(sumArea, 17.3971, 0.0001);
        }

        /// <summary>
        ///正しくListがカウントされているか
        /// </summary>
        [TestMethod]
        public void ListCountTest()
        {
            Trapezoid trapeziod = new Trapezoid(1, 2, 3);
            Triangle triangle = new Triangle(3);
            Quadrilarea quad = new Quadrilarea(3);

            shapeMana.AddShapeList(trapeziod);
            shapeMana.AddShapeList(triangle);
            shapeMana.AddShapeList(quad);

            var shapeCount = shapeMana.GetShapeListCount();

            Assert.AreEqual(shapeCount, 3);
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

            var shapeCount = shapeMana.GetShapeListCount();
            Assert.AreEqual(shapeCount, 3);

            var sumArea = shapeMana.GetSumArea();
            Assert.AreEqual(sumArea, 17.3971, 0.0001);

            shapeMana.RemoveShapeAtIndex(0);

            shapeCount = shapeMana.GetShapeListCount();
            Assert.AreEqual(shapeCount, 2);

            sumArea = shapeMana.GetSumArea();
            //17.3971 - 4.5 = 12.8971
            Assert.AreEqual(sumArea, 12.8971);
        }
    }
}

