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

        public virtual void SetArea()
        {
        }

        public double Area { get { return _area; } set { _area = value; } }
        public string ShapeName { get { return _shapeName; } set { _shapeName = value; } }
    }
}
