using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AreaManagement.Model
{
    public class Quadrilareal : Shape
    {
        private int _sideLength;
        private string _shapeName = "四角形";

        public Quadrilareal(int sideLength)
        {
            _sideLength = sideLength;
            ShapeName = _shapeName;
        }

        public Quadrilareal()
        {
        }

        public override void SetArea()
        {
            Area = _sideLength * _sideLength;
        }
    }
}
