using AreaManagement.Model;
using System.Collections.Generic;

namespace AreaManagement.Controller
{
    public class ShapeManager
    {
        private List<Shape> _shapeList;

        public ShapeManager()
        {
            _shapeList = new List<Shape>();
        }

        public void AddShapeList(Shape shape)
        {
            _shapeList.Add(shape);
        }

        public Shape GetShape(int index)
        {
            return _shapeList[index];
        }

        public int GetShapeListCount()
        {
            return _shapeList.Count;
        }

        public double GetSumArea()
        {
            double sumArea = 0;

            for (int i = 0; i < _shapeList.Count; i++)
            {
                sumArea += _shapeList[i].GetArea();
            }
            return sumArea;
        }

        public void RemoveShapeAtIndex(int index)
        {
            _shapeList.RemoveAt(index);
        }

        public void AllRemoveShape()
        {
            _shapeList.Clear();
        }
    }
}
