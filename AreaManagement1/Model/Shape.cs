using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaManagement.Model
{
    public class Shape
    {
        protected string _shapeName;

        public virtual double GetArea()
        {
            return 0;
        }

        public string GetShapeName()
        {
            return _shapeName;
        }
    }
}
