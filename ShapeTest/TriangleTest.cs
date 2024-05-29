using AreaManagement;
using AreaManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TriangleTest.Test
{
    [TestClass]
    public class TriangleUnitTest
    {
        /// <summary>
        /// 三角形のコンストラクタに0の値を入れた場合エラーメッセージが出るか
        /// </summary>
        [TestMethod]
        public void ErrorForNegativeSideLengthInConstructor()
        {
            Assert.ThrowsException<Exception>(() => new Triangle(0));
            Assert.ThrowsException<Exception>(() => new Triangle(-1));
        }

        /// <summary>
        /// 三角形のSetLengthに0の値を入れた場合エラーメッセージが出るか
        /// </summary>
        [TestMethod]
        public void ErrorForNegativeLengthInSetLength()
        {
            Triangle triangle = new Triangle(1);

            Assert.ThrowsException<Exception>(() => triangle.Length = 0);
            Assert.ThrowsException<Exception>(() => triangle.Length = -1);
        }

        /// <summary>
        /// 正しく三角形の名前を返しているか
        /// </summary>
        [TestMethod]
        public void ReturnNameForValidTriangle()
        {
            Triangle triangle = new Triangle(5);

            Assert.AreEqual(triangle.GetShapeName(), ShapeNameEnum.三角形);
        }

        /// <summary>
        /// 正しく三角形の面積が第４位で四捨五入されているか
        /// </summary>
        [TestMethod]
        public void AreaRoundedDownTo4DecimalPlaces_ForValidTriangle()
        {
            Triangle triangle = new Triangle(4);
            var result = Math.Round(Math.Sqrt(3) / 4 * Math.Pow(4, 2), 4);

            //三角形の面積は6.9282
            Assert.AreEqual(triangle.GetArea(), result);
        }

        /// <summary>
        /// 正しく三角形の面積が第４位で四捨五入されているか
        /// </summary>
        [TestMethod]
        public void AreaRoundedUpTo4DecimalPlaces_ForValidTriangle()
        {
            Triangle triangle = new Triangle(4.7);
            var result = Math.Round(Math.Sqrt(3) / 4 * Math.Pow(4.7, 2), 4);

            //三角形の面積は9.56525
            Assert.AreEqual(triangle.GetArea(), result);
        }

        /// <summary>
        /// 正しく三角形の面積を返しているか
        /// </summary>
        [TestMethod]
        public void TriangleAreaWithValidSides_ReturnsTriangleArea()
        {
            Triangle triangle = new Triangle(5);
            var result = Math.Round(Math.Sqrt(3) / 4 * Math.Pow(5, 2), 4);

            //三角形の面積は10.82531
            Assert.AreEqual(triangle.GetArea(), result);
        }

        /// <summary>
        /// 正しく三角形の辺を返しているか
        /// </summary>
        [TestMethod]
        public void ReturnEdgesForValidTriangle()
        {
            Triangle triangle = new Triangle(5);
            var length = triangle.Length;

            Assert.AreEqual(length, 5);
        }
    }
}
