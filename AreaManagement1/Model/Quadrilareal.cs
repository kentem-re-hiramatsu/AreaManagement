namespace AreaManagement.Model
{
    public class Quadrilarea : Shape
    {
        private double _sideLength;

        public Quadrilarea(double sideLength)
        {
            _sideLength = sideLength;
            this._shapeName = ShapeEnum.ShapeNameEnum.四角形;
        }

        public override double GetArea()
        {
            return _sideLength * _sideLength;
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
