using AreaManagement;
using AreaManagement.Model;
using AreaManagement1;
using AreaManagement1.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreaTest
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

            Assert.AreEqual(triangle.GetArea(), 6.928);
        }

        /// <summary>
        /// 正しく三角形の面積が第４位で四捨五入されているか
        /// </summary>
        [TestMethod]
        public void AreaRoundedUpTo4DecimalPlaces_ForValidTriangle()
        {
            Triangle triangle = new Triangle(4.1);

            Assert.AreEqual(triangle.GetArea(), 7.279);
        }

        /// <summary>
        /// 正しく三角形の面積を返しているか
        /// </summary>
        [TestMethod]
        public void TriangleAreaWithValidSides_ReturnsTriangleArea()
        {
            Triangle triangle = new Triangle(5);

            Assert.AreEqual(triangle.GetArea(), 10.825);
        }

        /// <summary>
        /// 正しく三角形の辺を返しているか
        /// </summary>
        [TestMethod]
        public void ReturnEdgesForValidTriangle()
        {
            Triangle triangle = new Triangle(5);
            var getLength = triangle.Length;

            Assert.AreEqual(getLength, 5);
        }
    }

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

            Assert.AreEqual(quad.GetArea(), 20.7116);
        }

        /// <summary>
        /// 正しく四角形の面積が第４位で四捨五入されているか
        /// </summary>
        [TestMethod]
        public void AreaRoundedUpTo4DecimalPlaces_ForValidTriangle()
        {
            Quadrilarea quad = new Quadrilarea(4.558);

            Assert.AreEqual(quad.GetArea(), 20.7754);
        }

        /// <summary>
        /// 正しく四角形の面積を返しているか
        /// </summary>
        [TestMethod]
        public void TriangleAreaWithValidSides_ReturnsTriangleArea()
        {
            Quadrilarea quad = new Quadrilarea(5);

            Assert.AreEqual(quad.GetArea(), 25);
        }

        /// <summary>
        /// 正しく四角形の辺を返しているか
        /// </summary>
        [TestMethod]
        public void ReturnEdgesForValidTriangle()
        {
            Quadrilarea quad = new Quadrilarea(5);
            var getLength = quad.Length;

            Assert.AreEqual(getLength, 5);
        }
    }

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
        }

        /// <summary>
        /// 台形のコンストラクタに0の値を入れた場合エラーメッセージが出るか
        /// </summary>
        [TestMethod]
        public void ErrorForNegativeLowerBaseLengthInConstructor()
        {
            string expectedMessage = Consts.MESSAGE_PLEASENUMVER;
            string errorMessage = null;

            try
            {
                new Trapezoid(1, 0, 1);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.AreEqual(expectedMessage, errorMessage);
        }

        /// <summary>
        /// 台形のコンストラクタに0の値を入れた場合エラーメッセージが出るか
        /// </summary>
        [TestMethod]
        public void ErrorForNegativeUpperBaseLengthInConstructor()
        {
            string expectedMessage = Consts.MESSAGE_PLEASENUMVER;
            string errorMessage = null;

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
        }

        /// <summary>
        /// 台形のSetLengthに0の値を入れた場合エラーメッセージが出るか
        /// </summary>
        [TestMethod]
        public void ErrorForNegativeLengthInSetUpperLength()
        {
            string expectedMessage = Consts.MESSAGE_PLEASENUMVER;
            string errorMessage = null;
            Trapezoid trapezoid = new Trapezoid(1, 1, 1);

            try
            {
                trapezoid.SetLength(1, 0, 1);
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
        public void ErrorForNegativeLengthInSetHeightLength()
        {
            string expectedMessage = Consts.MESSAGE_PLEASENUMVER;
            string errorMessage = null;
            Trapezoid trapezoid = new Trapezoid(1, 1, 1);

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
            Trapezoid quad = new Trapezoid(1, 1, 1);

            Assert.AreEqual(quad.GetShapeName(), ShapeNameEnum.台形);
        }

        /// <summary>
        /// 正しく台形の面積が第４位で四捨五入されているか
        /// </summary>
        [TestMethod]
        public void AreaRoundedDownTo4DecimalPlaces_ForValidTriangle()
        {
            Trapezoid quad = new Trapezoid(1.111, 1.111, 1.111);

            Assert.AreEqual(quad.GetArea(), 1.2343);
        }

        /// <summary>
        /// 正しく台形の面積が第４位で四捨五入されているか
        /// </summary>
        [TestMethod]
        public void AreaRoundedUpTo4DecimalPlaces_ForValidTriangle()
        {
            Trapezoid quad = new Trapezoid(2.222, 2.222, 2.222);

            Assert.AreEqual(quad.GetArea(), 4.9373);
        }

        /// <summary>
        /// 正しく台形の面積を返しているか
        /// </summary>
        [TestMethod]
        public void TriangleAreaWithValidSides_ReturnsTriangleArea()
        {
            Trapezoid quad = new Trapezoid(2, 2, 2);

            Assert.AreEqual(quad.GetArea(), 4);
        }

        /// <summary>
        /// 正しく台形の上底の辺を返しているか
        /// </summary>
        [TestMethod]
        public void ReturnUpperLengthForValidTriangle()
        {
            Trapezoid quad = new Trapezoid(1, 2, 3);
            var getLength = (quad.GetLength())[0];

            Assert.AreEqual(getLength, 1);
        }

        /// <summary>
        /// 正しく台形の下底の辺を返しているか
        /// </summary>
        [TestMethod]
        public void ReturnLowerLengthForValidTriangle()
        {
            Trapezoid quad = new Trapezoid(1, 2, 3);
            var getLength = quad.GetLength()[1];

            Assert.AreEqual(getLength, 2);
        }

        /// <summary>
        /// 正しく台形の高さの辺を返しているか
        /// </summary>
        [TestMethod]
        public void ReturnHeightLengthForValidTriangle()
        {
            Trapezoid quad = new Trapezoid(1, 2, 3);
            var getLength = quad.GetLength()[2];

            Assert.AreEqual(getLength, 3);
        }
    }
}
