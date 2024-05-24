using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using AreaManagement.Model;

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

        public List<Shape> GetShapeList(int index)
        {
            return _shapeList;
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

        public void ChangeShape(Shape shape, int index)
        {
            _shapeList[index] = shape;
        }
    }
}
