using AreaManagement;
using AreaManagement.Model;
using AreaManagement1;
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
            string expectedMessage = Consts.MESSAGE_PLEASENUMVER;
            string errorMessage = null;

            try
            {
                new Triangle(0);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.AreEqual(expectedMessage, errorMessage);
        }

        /// <summary>
        /// 三角形のSetLengthに0の値を入れた場合エラーメッセージが出るか
        /// </summary>
        [TestMethod]
        public void ErrorForNegativeLengthInSetLength()
        {
            string expectedMessage = Consts.MESSAGE_PLEASENUMVER;
            string errorMessage = null;
            Triangle triangle = new Triangle(1);

            try
            {
                triangle.Length = 0;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.AreEqual(expectedMessage, errorMessage);
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

            //三角形の面積は3.89711
            Assert.AreEqual(triangle.GetArea(), 6.9282);
        }

        /// <summary>
        /// 正しく三角形の面積が第４位で四捨五入されているか
        /// </summary>
        [TestMethod]
        public void AreaRoundedUpTo4DecimalPlaces_ForValidTriangle()
        {
            Triangle triangle = new Triangle(4.7);

            //三角形の面積は9.56525
            Assert.AreEqual(triangle.GetArea(), 9.5653);
        }

        /// <summary>
        /// 正しく三角形の面積を返しているか
        /// </summary>
        [TestMethod]
        public void TriangleAreaWithValidSides_ReturnsTriangleArea()
        {
            Triangle triangle = new Triangle(5);

            //三角形の面積は10.82531
            Assert.AreEqual(triangle.GetArea(), 10.8253);
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
