using System;

namespace AreaManagement.Model
{
    public class Triangle : Shape
    {
        private double _sideLength;

        public Triangle(double sideLength)
        {
            _sideLength = sideLength;
            this._shapeName = ShapeEnum.ShapeNameEnum.三角形;
        }

        public override double GetArea()
        {
            return Math.Round((Math.Sqrt(3) / 4 * Math.Pow(_sideLength, 2)), 3);
        }

        public override double[] GetLength()
        {
            return new double[] { _sideLength };
        }

        public override void SetLength(double Length)
        {
            _sideLength = Length;
        }
    }
}
