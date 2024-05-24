using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaManagement.Model
{
    public class Shape
    {
        private double _area;
        private string _shapeName;
        private double _lineLength;
        private double _lineLength2;
        private double _lineLength3;

        public virtual void SetArea()
        {
        }

        public string ShapeName { get { return _shapeName; } set { _shapeName = value; } }
        public double Area { get { return _area; } set { _area = value; } }
        public double LineLength { get { return _lineLength; } set { _lineLength = value; } }
        public double LineLength2 { get { return _lineLength2; } set { _lineLength2 = value; } }
        public double LineLength3 { get { return _lineLength3; } set { _lineLength3 = value; } }
    }
}
