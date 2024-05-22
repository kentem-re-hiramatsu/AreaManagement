using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AreaManagement.Controller;
using AreaManagement.model;

namespace AreaTest
{
    [TestClass]
    public class UnitTest1
    {
        AreaModel areaModel = new AreaModel();

        [TestMethod]
        public void TestSetTotalArea()
        {
            areaModel.TotalArea = 0;
            Assert.AreEqual(areaModel.TotalArea,0);
        }

        [TestMethod]
        public void TestDoubleSetTotalArea()
        {
            areaModel.TotalArea = 0.1;
            Assert.AreEqual(areaModel.TotalArea, 0.1);
        }

        [TestMethod]
        public void TestGetTriangleArea()
        {
            Triangle triangle = new Triangle(2);
            triangle.SetArea();
            Assert.AreEqual(triangle.GetArea(), 2);
        }

        [TestMethod]
        public void TestDoubleGetTriangleArea()
        {
            Triangle triangle = new Triangle(1);
            triangle.SetArea();
            Assert.AreEqual(triangle.GetArea(), 0.5);
        }

        [TestMethod]
        public void TestGetQuadrilareralArea()
        {
            Quadrilareral quadrilareral = new Quadrilareral(2);
            quadrilareral.SetArea();
            Assert.AreEqual(quadrilareral.GetArea(), 4);
        }

        [TestMethod]
        public void TestDoubleQuadrilareralArea()
        {
            Quadrilareral quadrilareral = new Quadrilareral(1);
            quadrilareral.SetArea();
            Assert.AreEqual(quadrilareral.GetArea(), 1);
        }
    }
}
