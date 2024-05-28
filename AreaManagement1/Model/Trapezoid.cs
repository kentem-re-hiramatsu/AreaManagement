using AreaManagement;
using AreaManagement.Model;
using System;

namespace AreaManagement1.Model
{
    public class Trapezoid : Shape
    {
        private double _upperBaseLength;
        private double _lowerBaseLength;
        private double _height;

        public Trapezoid(double upperBaseLength, double lowerBaseLength, double height)
        {
            if (upperBaseLength <= 0 || lowerBaseLength <= 0 || height <= 0)
            {
                throw new Exception(Consts.MESSAGE_PLEASENUMVER);
            }
            _upperBaseLength = upperBaseLength;
            _lowerBaseLength = lowerBaseLength;
            _height = height;
            _shapeName = ShapeNameEnum.台形;
        }

        public override double GetArea()
        {
            return Math.Round(0.5 * (_upperBaseLength + _lowerBaseLength) * _height, 4);
        }
        public double[] GetLength()
        {
            return new double[] { _upperBaseLength, _lowerBaseLength, _height };
        }
        public void SetLength(double height, double upperLength, double lowerLength)
        {
            if (upperLength <= 0 || lowerLength <= 0 || height <= 0)
            {
                throw new Exception(Consts.MESSAGE_PLEASENUMVER);
            }
            _upperBaseLength = upperLength;
            _lowerBaseLength = lowerLength;
            _height = height;
        }
    }
}
