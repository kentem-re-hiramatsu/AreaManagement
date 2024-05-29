using AreaManagement;
using AreaManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace QuadrilarealTest.Test
{
    [TestClass]
    public class QuadUnitTest
    {
        /// <summary>
        /// 四角形のコンストラクタに0の値を入れた場合エラーメッセージが出るか
        /// </summary>
        [TestMethod]
        public void ErrorForNegativeSideLengthInConstructor()
        {
            Assert.ThrowsException<Exception>(() => new Quadrilarea(0));
            Assert.ThrowsException<Exception>(() => new Quadrilarea(-1));
        }

        /// <summary>
        /// 四角形のSetLengthに0の値を入れた場合エラーメッセージが出るか
        /// </summary>
        [TestMethod]
        public void ErrorForNegativeLengthInSetLength()
        {
            Quadrilarea quad = new Quadrilarea(1);

            Assert.ThrowsException<Exception>(() => quad.Length = 0);
            Assert.ThrowsException<Exception>(() => quad.Length = -1);
        }

        /// <summary>
        /// 正しく四角形の名前を返しているか
        /// </summary>
        [TestMethod]
        public void ReturnNameForValidTriangle()
        {
            Quadrilarea quad = new Quadrilarea(5);

            Assert.AreEqual(quad.GetShapeName(), ShapeNameEnum.四角形);
        }

        /// <summary>
        /// 正しく四角形の面積が第４位で四捨五入されているか
        /// </summary>
        [TestMethod]
        public void AreaRoundedDownTo4DecimalPlaces_ForValidTriangle()
        {
            Quadrilarea quad = new Quadrilarea(4.551);
            var result = Math.Round(4.551 * 4.551, 4);

            //四角形の面積は20.71160
            Assert.AreEqual(quad.GetArea(), result);
        }

        /// <summary>
        /// 正しく四角形の面積が第４位で四捨五入されているか
        /// </summary>
        [TestMethod]
        public void AreaRoundedUpTo4DecimalPlaces_ForValidTriangle()
        {
            Quadrilarea quad = new Quadrilarea(4.558);
            var result = Math.Round(4.558 * 4.558, 4);

            //四角形の面積は20.77536
            Assert.AreEqual(quad.GetArea(), result);
        }

        /// <summary>
        /// 正しく四角形の面積を返しているか
        /// </summary>
        [TestMethod]
        public void TriangleAreaWithValidSides_ReturnsTriangleArea()
        {
            Quadrilarea quad = new Quadrilarea(5.0);
            var result = Math.Round(5.0 * 5.0, 4);

            //四角形の面積は25
            Assert.AreEqual(quad.GetArea(), result);
        }

        /// <summary>
        /// 正しく四角形の辺を返しているか
        /// </summary>
        [TestMethod]
        public void ReturnEdgesForValidTriangle()
        {
            Quadrilarea quad = new Quadrilarea(5);
            var length = quad.Length;

            Assert.AreEqual(length, 5);
        }
    }
}
