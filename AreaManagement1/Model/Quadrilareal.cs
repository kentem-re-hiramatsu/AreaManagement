using AreaManagement1;
using System;

namespace AreaManagement.Model
{
    public class Quadrilarea : Shape
    {
        private double _sideLength;

        public Quadrilarea(double sideLength)
        {
            if (sideLength < 0)
            {
                throw new Exception(Consts.MESSAGE_PLEASENUMVER);
            }
            _sideLength = sideLength;
            _shapeName = ShapeEnum.ShapeNameEnum.四角形;
        }

        public override double GetArea()
        {
            return _sideLength * _sideLength;
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
