using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaManagement.Controller
{
    public class Quadrilareral: Shape
    {
        public string shapeName = "四角形";

        public Quadrilareral(int sideLength) : base(sideLength)
        {
            this.sideLength = sideLength;
        }
        public override void SetArea()
        {
            area = sideLength * sideLength;
        }
    }
}
