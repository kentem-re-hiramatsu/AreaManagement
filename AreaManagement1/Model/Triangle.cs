using AreaManagement1;
using System;

namespace AreaManagement.Model
{
    public class Triangle : Shape
    {
        private double _sideLength;

        public Triangle(double sideLength)
        {
            if (sideLength < 0)
            {
                throw new Exception(Consts.MESSAGE_PLEASENUMVER);
            }
            _sideLength = sideLength;
            _shapeName = ShapeEnum.ShapeNameEnum.三角形;
        }

        public override double GetArea()
        {
            return Math.Round((Math.Sqrt(3) / 4 * Math.Pow(_sideLength, 2)), 3);
        }

        public override double[] GetLength()
        {
            return new double[] { _sideLength };
        }

        public void SetLength(double length)
        {
            if (length < 0)
            {
                throw new Exception(Consts.MESSAGE_PLEASENUMVER);
            }
            _sideLength = length;
        }
    }
}
