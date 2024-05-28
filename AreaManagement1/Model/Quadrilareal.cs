using AreaManagement1;
using System;

namespace AreaManagement.Model
{
    public class Quadrilarea : Shape
    {
        private double _sideLength;

        public double Length
        {
            get { return _sideLength; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception(Consts.MESSAGE_PLEASENUMVER);
                }
                _sideLength = value;
            }
        }

        public Quadrilarea(double sideLength)
        {
            if (sideLength <= 0)
            {
                throw new Exception(Consts.MESSAGE_PLEASENUMVER);
            }
            _sideLength = sideLength;
            _shapeName = ShapeNameEnum.四角形;
        }

        public override double GetArea()
        {
            return Math.Round(_sideLength * _sideLength, 4);
        }
    }
}
