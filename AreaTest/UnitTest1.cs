using AreaManagement;
using AreaManagement.Controller;
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
            var getLength = (trapeziod.GetLength())[0];

            Assert.AreEqual(getLength, 1);
        }

        /// <summary>
        /// 正しく台形の下底の辺を返しているか
        /// </summary>
        [TestMethod]
        public void ReturnLowerLengthForValidTriangle()
        {
            Trapezoid trapeziod = new Trapezoid(1, 2, 3);
            var getLength = trapeziod.GetLength()[1];

            Assert.AreEqual(getLength, 2);
        }

        /// <summary>
        /// 正しく台形の高さの辺を返しているか
        /// </summary>
        [TestMethod]
        public void ReturnHeightLengthForValidTriangle()
        {
            Trapezoid trapeziod = new Trapezoid(1, 2, 3);
            var getLength = trapeziod.GetLength()[2];

            Assert.AreEqual(getLength, 3);
        }
    }
    [TestClass]
    public class ShapeManagerUnitTest
    {
        ShapeManager shapeMana = new ShapeManager();

        /// <summary>
        /// 正しくShapeListに三角形の面積が入っているか
        /// </summary>
        [TestMethod]
        public void TriangleAreaStoredCorrectlyInDobleShapeList()
        {
            Triangle triangle = new Triangle(3);
            shapeMana.AddShapeList(triangle);
            var getShape = shapeMana.GetShape(0);
            Assert.AreEqual(getShape.GetArea(), 3.8971);
        }

        /// <summary>
        /// 正しくShapeListに三角形の名前が入っているか
        /// </summary>
        [TestMethod]
        public void TriangleNameStoredCorrectlyInShapeList()
        {
            Triangle triangle = new Triangle(3);
            shapeMana.AddShapeList(triangle);
            var getShape = shapeMana.GetShape(0);
            Assert.AreEqual(getShape.GetShapeName(), ShapeNameEnum.三角形);
        }

        /// <summary>
        /// 正しくShapeListに四角形の面積が入っているか
        /// </summary>
        [TestMethod]
        public void QuadAreaStoredCorrectlyInShapeList()
        {
            Quadrilarea quad = new Quadrilarea(3);
            shapeMana.AddShapeList(quad);
            var getShape = shapeMana.GetShape(0);
            Assert.AreEqual(getShape.GetArea(), 9);
        }

        /// <summary>
        /// 正しくShapeListに四角形のdouble型の面積が入っているか
        /// </summary>
        [TestMethod]
        public void QuadAreaStoredCorrectlyInDoubleShapeList()
        {
            Quadrilarea quad = new Quadrilarea(5.123);
            shapeMana.AddShapeList(quad);
            var getShape = shapeMana.GetShape(0);
            Assert.AreEqual(getShape.GetArea(), 26.2451);
        }

        /// <summary>
        /// 正しくShapeListに四角形の名前が入っているか
        /// </summary>
        [TestMethod]
        public void QuadNameStoredCorrectlyInShapeList()
        {
            Quadrilarea quad = new Quadrilarea(3);
            shapeMana.AddShapeList(quad);
            var getShape = shapeMana.GetShape(0);
            Assert.AreEqual(getShape.GetShapeName(), ShapeNameEnum.四角形);
        }

        /// <summary>
        /// 正しくShapeListに台形の面積が入っているか
        /// </summary>
        [TestMethod]
        public void TrapezoidAreaStoredCorrectlyInShapeList()
        {
            Trapezoid trapeziod = new Trapezoid(2, 2, 2);
            shapeMana.AddShapeList(trapeziod);
            var getShape = shapeMana.GetShape(0);
            Assert.AreEqual(getShape.GetArea(), 4);
        }

        /// <summary>
        /// 正しくShapeListに台形のdouble型の面積が入っているか
        /// </summary>
        [TestMethod]
        public void TrapezoidAreaStoredCorrectlyInDoubleShapeList()
        {
            Trapezoid quad = new Trapezoid(2.1, 2.1, 2.1);
            shapeMana.AddShapeList(quad);
            var getShape = shapeMana.GetShape(0);
            Assert.AreEqual(getShape.GetArea(), 4.41);
        }

        /// <summary>
        /// 正しくShapeListに台形の名前が入っているか
        /// </summary>
        [TestMethod]
        public void TrapezoidNameStoredCorrectlyInShapeList()
        {
            Trapezoid trapeziod = new Trapezoid(1, 2, 3);
            shapeMana.AddShapeList(trapeziod);
            var getShape = shapeMana.GetShape(0);
            Assert.AreEqual(getShape.GetShapeName(), ShapeNameEnum.台形);
        }

        /// <summary>
        /// 正しくShapeListに複数図形が入っているか
        /// </summary>
        [TestMethod]
        public void ValidShapesAddedToShapeList()
        {
            Trapezoid trapeziod = new Trapezoid(1, 2, 3);
            Triangle triangle = new Triangle(3);
            Quadrilarea quad = new Quadrilarea(3);
            shapeMana.AddShapeList(triangle);
            shapeMana.AddShapeList(quad);
            var getShape = shapeMana.GetShape(0);
            Assert.AreEqual(getShape.GetShapeName(), ShapeNameEnum.台形);
        }
    }
}
