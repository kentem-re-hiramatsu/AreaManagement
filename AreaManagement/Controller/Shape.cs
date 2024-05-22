using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaManagement.Controller
{
    public class Shape
    {
        protected string shapeName = "None";
        protected double area;
        protected int sideLength;

        public Shape(int sideLength)
        {
        }

        public double GetArea()
        {
            return area;
        }

        public virtual void SetArea()
        {
        }
    }
}
