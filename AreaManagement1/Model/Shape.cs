namespace AreaManagement.Model
{
    public class Shape
    {
        protected ShapeEnum.ShapeNameEnum _shapeName;

        public Shape() { }

        public virtual double GetArea()
        {
            return 0;
        }

        public ShapeEnum.ShapeNameEnum GetShapeName()
        {
            return _shapeName;
        }

        public virtual double[] GetLength()
        {
            return new double[] { };
        }

        public virtual void SetLength(double length)
        {
        }

        public virtual void SetLength(double length, double length2, double length3)
        {
        }
    }
}
