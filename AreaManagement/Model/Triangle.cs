using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaManagement.Model
{
    public class Triangle : Shape
    {
        private int _sideLength;
        private string _shapeName = "三角形";

        public Triangle(int sideLength)
        {
            _sideLength = sideLength;
            ShapeName = _shapeName;
        }
        public Triangle()
        {
        }

        public override void SetArea()
        {
            Area = _sideLength * _sideLength / 2;
        }
    }
}
