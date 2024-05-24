using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AreaManagement.Controller;
using AreaManagement.Model;
using AreaManagement1.Model;

namespace AreaTest
{
    [TestClass]
    public class ShapeUnitTest
    {
        Shape shape = new Shape();
        [TestMethod]
        public void ShapeNameGesSet()
        {
            shape.ShapeName = "図形";
            Assert.AreEqual(shape.ShapeName, "図形");
        }

        [TestMethod]
        public void AreaGesSet()
        {
            shape.Area = 0.1;
            Assert.AreEqual(shape.Area, 0.1);
        }

        [TestMethod]
        public void LengthGesSet()
        {
            shape.LineLength = 0.1;
            Assert.AreEqual(shape.LineLength, 0.1);
        }

        [TestMethod]
        public void Length2GesSet()
        {
            shape.LineLength2 = 0.1;
            Assert.AreEqual(shape.LineLength2, 0.1);
        }

        [TestMethod]
        public void Length3GesSet()
        {
            shape.LineLength3 = 0.1;
            Assert.AreEqual(shape.LineLength3, 0.1);
        }
    }

    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]
        public void TriangleAreaCalculation()
        {
            var triangle = new Triangle(3);
            triangle.SetArea();
            Assert.AreEqual(triangle.Area, 3.897);
        }

        [TestMethod]
        public void RoundedTriangleAreaCalculation()
        {
            var triangle = new Triangle(1);
            triangle.SetArea();
            Assert.AreEqual(triangle.Area.ToString().Length, 5);
        }

        [TestMethod]
        public void TriangleNameGetSet()
        {
            var triangle = new Triangle(1);
            Assert.AreEqual(triangle.ShapeName, "三角形");
        }

        [TestMethod]
        public void TriangleLengthGetSet()
        {
            var triangle = new Triangle(1);
            triangle.SetLineLength();
            Assert.AreEqual(triangle.LineLength, 1);
        }
    }

    [TestClass]
    public class QuadUnitTest
    {
        [TestMethod]
        public void QuadAreaCalculation()
        {
            var Quad = new Quadrilarea(3);
            Quad.SetArea();
            Assert.AreEqual(Quad.Area, 9);
        }

        [TestMethod]
        public void QuadNameGetSet()
        {
            var Quad = new Quadrilarea(1);
            Assert.AreEqual(Quad.ShapeName, "四角形");
        }

        [TestMethod]
        public void QuadLengthGetSet()
        {
            var Quad = new Quadrilarea(1);
            Quad.SetLineLength();
            Assert.AreEqual(Quad.LineLength, 1);
        }
    }

    [TestClass]
    public class TrapezoidUnitTest
    {
        [TestMethod]
        public void trapezoidAreaCalculation()
        {
            var trapezoid = new Trapezoid(3,3,3);
            trapezoid.SetArea();
            Assert.AreEqual(trapezoid.Area, 9);
        }

        [TestMethod]
        public void trapezoidNameGetSet()
        {
            var trapezoid = new Trapezoid(1, 1, 1);
            Assert.AreEqual(trapezoid.ShapeName, "台形");
        }

        [TestMethod]
        public void trapezoidLengthGetSet()
        {
            var trapezoid = new Trapezoid(1, 2, 3);
            trapezoid.SetLineLength();
            Assert.AreEqual(trapezoid.LineLength, 1);
        }

        [TestMethod]
        public void trapezoidLength2GetSet()
        {
            var trapezoid = new Trapezoid(1, 2, 3);
            trapezoid.SetLineLength();
            Assert.AreEqual(trapezoid.LineLength2, 2);
        }

        [TestMethod]
        public void trapezoidLength3GetSet()
        {
            var trapezoid = new Trapezoid(1, 2, 3);
            trapezoid.SetLineLength();
            Assert.AreEqual(trapezoid.LineLength3, 3);
        }
    }
}
