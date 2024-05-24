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

        public Trapezoid(double upperBaseLength, double lowerBaseLength, double height)
        {
            _upperBaseLength = upperBaseLength;
            _lowerBaseLength = lowerBaseLength;
            _height = height;
            this._shapeName = "台形";
        }

        public override double GetArea()
        {
            return 0.5 * (_upperBaseLength + _lowerBaseLength) * _height;
        }
    }
}
