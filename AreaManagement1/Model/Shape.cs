namespace AreaManagement.Model
{
    public abstract class Shape
    {
        protected ShapeNameEnum _shapeName;

        public Shape() { }

        public abstract double GetArea();

        public ShapeNameEnum GetShapeName()
        {
            return _shapeName;
        }
    }
}
