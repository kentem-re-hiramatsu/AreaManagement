using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AreaManagement.Model
{
    public class Quadrilarea : Shape
    {
        private int _sideLength;

        public Quadrilarea(int sideLength)
        {
            _sideLength = sideLength;
            this._shapeName = "四角形";
        }

        public override double GetArea()
        {
            return _sideLength * _sideLength;
        }
    }
}
