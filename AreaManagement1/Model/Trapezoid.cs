using AreaManagement;
using AreaManagement.Model;

namespace AreaManagement1.Model
{
    public class Trapezoid : Shape
    {
        private double _upperBaseLength;
        private double _lowerBaseLength;
        private double _height;

        public Trapezoid(double upperBaseLength, double lowerBaseLength, double height)
        {
            _upperBaseLength = upperBaseLength;
            _lowerBaseLength = lowerBaseLength;
            _height = height;
            this._shapeName = ShapeEnum.ShapeNameEnum.台形;
        }

        public override double GetArea()
        {
            return 0.5 * (_upperBaseLength + _lowerBaseLength) * _height;
        }
        public override double[] GetLength()
        {
            return new double[] { _upperBaseLength, _lowerBaseLength, _height };
        }
        public override void SetLength(double height, double upperLength, double lowerLength)
        {
            _upperBaseLength = upperLength;
            _lowerBaseLength = lowerLength;
            _height = height;
        }
    }
}
