using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaManagement.Model
{
    public class Triangle : Shape
    {
        private double _sideLength;
        private string _shapeName = "三角形";

        public Triangle(int sideLength)
        {
            _sideLength = sideLength;
            ShapeName = _shapeName;
        }

        public override void SetArea()
        {
            Area = Math.Round((Math.Sqrt(3) / 4 * Math.Pow(_sideLength, 2)), 3);
        }
        public void SetLineLength()
        {
            LineLength = _sideLength;
        }
    }
}
