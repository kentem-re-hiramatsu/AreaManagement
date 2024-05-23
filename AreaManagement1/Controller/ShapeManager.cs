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

        public List<Shape> GetShapeList()
        {
            return _shapeList;
        }

        public void RemoveShapeAtIndex(int index)
        {
            _shapeList.RemoveAt(index);
        }
    }
}
