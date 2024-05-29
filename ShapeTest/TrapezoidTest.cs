using AreaManagement;
using AreaManagement1;
using AreaManagement1.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TrapezoidTest.Test
{
    [TestClass]
    public class TrapezoidUnitTest
    {
        /// <summary>
        /// 台形のコンストラクタに0の値を入れた場合エラーメッセージが出るか
        /// </summary>
        [TestMethod]
        public void ErrorForNegativeHeightInConstructor()
        {
            string expectedMessage = Consts.MESSAGE_PLEASENUMVER;
            string errorMessage = null;

            try
            {
                new Trapezoid(1, 1, 0);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.AreEqual(expectedMessage, errorMessage);

            try
            {
                new Trapezoid(1, 0, 1);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.AreEqual(expectedMessage, errorMessage);

            try
            {
                new Trapezoid(0, 1, 1);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.AreEqual(expectedMessage, errorMessage);
        }

        /// <summary>
        /// 台形のSetLengthに0の値を入れた場合エラーメッセージが出るか
        /// </summary>
        [TestMethod]
        public void ErrorForNegativeLengthInSetLowerLength()
        {
            string expectedMessage = Consts.MESSAGE_PLEASENUMVER;
            string errorMessage = null;
            Trapezoid trapezoid = new Trapezoid(1, 1, 1);

            try
            {
                trapezoid.SetLength(1, 1, 0);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.AreEqual(expectedMessage, errorMessage);

            try
            {
                trapezoid.SetLength(1, 0, 1);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.AreEqual(expectedMessage, errorMessage);

            try
            {
                trapezoid.SetLength(0, 1, 1);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.AreEqual(expectedMessage, errorMessage);
        }

        /// <summary>
        /// 正しく台形の名前を返しているか
        /// </summary>
        [TestMethod]
        public void ReturnNameForValidTriangle()
        {
            Trapezoid trapeziod = new Trapezoid(1, 1, 1);

            Assert.AreEqual(trapeziod.GetShapeName(), ShapeNameEnum.台形);
        }

        /// <summary>
        /// 正しく台形の面積が第４位で四捨五入されているか
        /// </summary>
        [TestMethod]
        public void AreaRoundedDownTo4DecimalPlaces_ForValidTriangle()
        {
            Trapezoid trapeziod = new Trapezoid(1.111, 1.111, 1.111);

            //台形の面積の値1.23432
            Assert.AreEqual(trapeziod.GetArea(), 1.2343);
        }

        /// <summary>
        /// 正しく台形の面積が第４位で四捨五入されているか
        /// </summary>
        [TestMethod]
        public void AreaRoundedUpTo4DecimalPlaces_ForValidTriangle()
        {
            Trapezoid trapeziod = new Trapezoid(2.222, 2.222, 2.222);

            //台形の面積の値4.93728
            Assert.AreEqual(trapeziod.GetArea(), 4.9373);
        }

        /// <summary>
        /// 正しく台形の面積を返しているか
        /// </summary>
        [TestMethod]
        public void TriangleAreaWithValidSides_ReturnsTriangleArea()
        {
            Trapezoid trapeziod = new Trapezoid(2, 2, 2);

            //台形の面積の値4.0
            Assert.AreEqual(trapeziod.GetArea(), 4);
        }

        /// <summary>
        /// 正しく台形の上底の辺を返しているか
        /// </summary>
        [TestMethod]
        public void ReturnUpperLengthForValidTriangle()
        {
            Trapezoid trapeziod = new Trapezoid(1, 2, 3);
            var length = trapeziod.UpperBaseLength;

            Assert.AreEqual(length, 1);
        }

        /// <summary>
        /// 正しく台形の下底の辺を返しているか
        /// </summary>
        [TestMethod]
        public void ReturnLowerLengthForValidTriangle()
        {
            Trapezoid trapeziod = new Trapezoid(1, 2, 3);
            var length = trapeziod.LowerBaseLength;

            Assert.AreEqual(length, 2);
        }

        /// <summary>
        /// 正しく台形の高さの辺を返しているか
        /// </summary>
        [TestMethod]
        public void ReturnHeightLengthForValidTriangle()
        {
            Trapezoid trapeziod = new Trapezoid(1, 2, 3);
            var length = trapeziod.Height;

            Assert.AreEqual(length, 3);
        }
    }
}
