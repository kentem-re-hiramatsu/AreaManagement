using AreaManagement;
using AreaManagement.Model;
using System;

namespace AreaManagement1.Model
{
    public class Trapezoid : Shape
    {
        private double _height;
        private double _upperBaseLength;
        private double _lowerBaseLength;

        public double Height { get { return _height; } }
        public double UpperBaseLength { get { return _upperBaseLength; } }
        public double LowerBaseLength { get { return _lowerBaseLength; } }

        public Trapezoid(double height, double upperBaseLength, double lowerBaseLength)
        {
            if (upperBaseLength <= 0 || lowerBaseLength <= 0 || height <= 0)
            {
                throw new Exception(Consts.MESSAGE_PLEASENUMVER);
            }
            _height = height;
            _upperBaseLength = upperBaseLength;
            _lowerBaseLength = lowerBaseLength;
            _shapeName = ShapeNameEnum.台形;
        }

        public override double GetArea()
        {
            return Math.Round(0.5 * (_upperBaseLength + _lowerBaseLength) * _height, 4);
        }

        public void SetLength(double height, double upperLength, double lowerLength)
        {
            if (upperLength <= 0 || lowerLength <= 0 || height <= 0)
            {
                throw new Exception(Consts.MESSAGE_PLEASENUMVER);
            }
            _height = height;
            _upperBaseLength = upperLength;
            _lowerBaseLength = lowerLength;
        }
    }
}
