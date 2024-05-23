using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaManagement.Model;

namespace AreaManagement.Controller
{
    public class ShapeManager
    {
        private List<Shape> _shapeList;

        Quadrilareal quad = new Quadrilareal();
        Triangle triangle = new Triangle();

        public void AddShapeList(Shape shape)
        {
            var aaa = shape.ShapeName;
        }

        public List<Shape> GetShapeList()
        {
            return _shapeList;
        }
    }
}
