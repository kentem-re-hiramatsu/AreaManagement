using AreaManagement;
using AreaManagement.Controller;
using AreaManagement.Model;
using AreaManagement1.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        /// 正しく円のGetShapeができているか
        /// </summary>
        [TestMethod]
        public void CircleGetShapeTest()
        {
            Circle circle = new Circle(1);
            shapeMana.AddShapeList(circle);
            var shape = shapeMana.GetShape(0);

            Assert.AreEqual(shape.GetShapeName(), ShapeNameEnum.円);
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

        /// <summary>
        ///正しくすべてのListが削除されているか
        /// </summary>
        [TestMethod]
        public void AllRemovedListTest()
        {
            Trapezoid trapeziod = new Trapezoid(1, 2, 3);
            Triangle triangle = new Triangle(3);
            Quadrilarea quad = new Quadrilarea(3);

            shapeMana.AddShapeList(trapeziod);
            shapeMana.AddShapeList(triangle);
            shapeMana.AddShapeList(quad);

            var shapeListCount = shapeMana.GetShapeListCount();
            Assert.AreEqual(shapeListCount, 3);

            shapeMana.AllRemoveShape();

            shapeListCount = shapeMana.GetShapeListCount();
            Assert.AreEqual(shapeListCount, 0);
        }

        /// <summary>
        ///正しく面積合計が出せるか
        /// </summary>
        [TestMethod]
        public void ShapeSumAreaTest()
        {
            Trapezoid trapeziod = new Trapezoid(1, 2, 3);
            Triangle triangle = new Triangle(3);
            Quadrilarea quad = new Quadrilarea(3);

            shapeMana.AddShapeList(trapeziod);
            shapeMana.AddShapeList(triangle);
            shapeMana.AddShapeList(quad);

            var sumArea = shapeMana.GetSumArea();

            var trapeziodArea = Math.Round(0.5 * (2 + 3) * 1, 4);
            var triangleArea = Math.Round(Math.Sqrt(3) / 4 * Math.Pow(3, 2), 4);
            var quadArea = Math.Round(3.0 * 3.0, 4);
            var shapeAreaSum = trapeziodArea + triangleArea + quadArea;

            Assert.AreEqual(sumArea, shapeAreaSum);
        }
    }
}

