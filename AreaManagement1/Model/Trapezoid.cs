using AreaManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaManagement1.Model
{
    public class Trapezoid : Shape
    {
        private double _upperBaseLength;
        private double _lowerBaseLength;
        private double _height;
        private string _shapeName = "台形";

        public Trapezoid(double upperBaseLength, double lowerBaseLength, double height)
        {
            _upperBaseLength = upperBaseLength;
            _lowerBaseLength = lowerBaseLength;
            _height = height;
            ShapeName = _shapeName;
        }

        public override void SetArea()
        {
            Area = 0.5 * (_upperBaseLength + _lowerBaseLength) * _height;
        }
    }
}
