using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AreaManagement.Controller;
using AreaManagement.model;

namespace AreaTest
{
    [TestClass]
    public class UnitTest1
    {
        AreaModel areamodel = new AreaModel();

        [TestMethod]
        public void TestSetTotalArea()
        {
            areamodel.TotalArea = 0;
            Assert.AreEqual(areamodel.TotalArea,1);
        }

        [TestMethod]
        public void TestDoubleSetTotalArea()
        {
            areamodel.TotalArea = 0.1;
            Assert.AreEqual(areamodel.TotalArea, 0.1);
        }

        [TestMethod]
        public void TestGetTriangleArea()
        {
            Triangle triangle = new Triangle(2);
            Assert.AreEqual(triangle.GetArea(), 1);
        }

        [TestMethod]
        public void TestDoubleGetTriangleArea()
        {
            Triangle triangle = new Triangle(1);
            Assert.AreEqual(triangle.GetArea(), 0.5);
        }

        [TestMethod]
        public void TestGetQuadrilareralArea()
        {
            Quadrilareral triangle = new Quadrilareral(2);
            Assert.AreEqual(triangle.GetArea(), 1);
        }

        [TestMethod]
        public void TestDoubleQuadrilareralArea()
        {
            Quadrilareral triangle = new Quadrilareral(1);
            Assert.AreEqual(triangle.GetArea(), 0.5);
        }
    }
}
