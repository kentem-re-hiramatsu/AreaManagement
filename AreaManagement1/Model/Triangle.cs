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

        public Triangle(int sideLength)
        {
            _sideLength = sideLength;
            this._shapeName = "三角形";
        }

        public override double GetArea()
        {
            return Math.Round((Math.Sqrt(3) / 4 * Math.Pow(_sideLength, 2)), 3);
        }
    }
}
