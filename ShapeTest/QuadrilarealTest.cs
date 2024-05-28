using AreaManagement;
using AreaManagement.Model;
using AreaManagement1;
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
            string expectedMessage = Consts.MESSAGE_PLEASENUMVER;
            string errorMessage = null;

            try
            {
                new Quadrilarea(0);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.AreEqual(expectedMessage, errorMessage);
        }

        /// <summary>
        /// 四角形のSetLengthに0の値を入れた場合エラーメッセージが出るか
        /// </summary>
        [TestMethod]
        public void ErrorForNegativeLengthInSetLength()
        {
            string expectedMessage = Consts.MESSAGE_PLEASENUMVER;
            string errorMessage = null;
            Quadrilarea quad = new Quadrilarea(1);

            try
            {
                quad.Length = 0;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.AreEqual(expectedMessage, errorMessage);
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

            //四角形の面積は20.71160
            Assert.AreEqual(quad.GetArea(), 20.7116);
        }

        /// <summary>
        /// 正しく四角形の面積が第４位で四捨五入されているか
        /// </summary>
        [TestMethod]
        public void AreaRoundedUpTo4DecimalPlaces_ForValidTriangle()
        {
            Quadrilarea quad = new Quadrilarea(4.558);

            //四角形の面積は20.77536
            Assert.AreEqual(quad.GetArea(), 20.7754);
        }

        /// <summary>
        /// 正しく四角形の面積を返しているか
        /// </summary>
        [TestMethod]
        public void TriangleAreaWithValidSides_ReturnsTriangleArea()
        {
            Quadrilarea quad = new Quadrilarea(5);

            //四角形の面積は25
            Assert.AreEqual(quad.GetArea(), 25);
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
