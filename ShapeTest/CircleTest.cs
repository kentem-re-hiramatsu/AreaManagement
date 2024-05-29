using AreaManagement;
using AreaManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ShapeTest
{
    [TestClass]
    public class CircleTest
    {
        /// <summary>
        /// 円のコンストラクタに0の値を入れた場合エラーメッセージが出るか
        /// </summary>
        [TestMethod]
        public void ErrorForNegativeSideLengthInConstructor()
        {
            Assert.ThrowsException<Exception>(() => new Circle(0));
            Assert.ThrowsException<Exception>(() => new Circle(-1));
        }

        /// <summary>
        /// 円のSetLengthに0の値を入れた場合エラーメッセージが出るか
        /// </summary>
        [TestMethod]
        public void ErrorForNegativeLengthInSetLength()
        {
            Circle circle = new Circle(1);

            Assert.ThrowsException<Exception>(() => circle.Length = 0);
            Assert.ThrowsException<Exception>(() => circle.Length = -1);
        }

        /// <summary>
        /// 正しく円の名前を返しているか
        /// </summary>
        [TestMethod]
        public void ReturnNameForValidCircle()
        {
            Circle circle = new Circle(5);

            Assert.AreEqual(circle.GetShapeName(), ShapeNameEnum.円);
        }

        /// <summary>
        /// 正しく円の面積が第４位で四捨五入されているか
        /// </summary>
        [TestMethod]
        public void AreaRoundedDownTo4DecimalPlaces_ForValidCircle()
        {
            Circle circle = new Circle(3);
            var result = Math.Round(3 * 3 * Math.PI, 4);

            //四角形の面積は28.27433
            Assert.AreEqual(circle.GetArea(), result);
        }

        /// <summary>
        /// 正しく円の面積が第４位で四捨五入されているか
        /// </summary>
        [TestMethod]
        public void AreaRoundedUpTo4DecimalPlaces_ForValidCircle()
        {
            Circle circle = new Circle(4);
            var result = Math.Round(4 * 4 * Math.PI, 4);

            //四角形の面積は50.26548
            Assert.AreEqual(circle.GetArea(), result);
        }

        /// <summary>
        /// 正しく円の面積を返しているか
        /// </summary>
        [TestMethod]
        public void TriangleAreaWithValidSides_ReturnsCircleArea()
        {
            Circle circle = new Circle(5.0);
            var result = Math.Round(5.0 * 5.0 * Math.PI, 4);

            //円の面積は78.53981
            Assert.AreEqual(circle.GetArea(), result);
        }

        /// <summary>
        /// 正しく円の辺を返しているか
        /// </summary>
        [TestMethod]
        public void ReturnEdgesForValidCircle()
        {
            Circle circle = new Circle(5);
            var length = circle.Length;

            Assert.AreEqual(length, 5);
        }
    }
}
