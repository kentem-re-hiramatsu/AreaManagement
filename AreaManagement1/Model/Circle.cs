using AreaManagement1;
using System;

namespace AreaManagement.Model
{
    public class Circle : Shape
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

        public Circle(double sideLength)
        {
            if (sideLength <= 0)
            {
                throw new Exception(Consts.MESSAGE_PLEASENUMVER);
            }
            _sideLength = sideLength;
            _shapeName = ShapeNameEnum.円;
        }

        public override double GetArea()
        {
            return Math.Round(_sideLength * _sideLength * Math.PI, 4);
        }
    }
}
