using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaManagement.model
{
    public class AreaModel
    {
        private double _totalArea;
        private string _name;

        public AreaModel(double totalarea, string name)
        {
            _totalArea = totalarea;
            _name = name;
        }
        public AreaModel()
        {
        }

        public double TotalArea {  get { return _totalArea; } set {  _totalArea = value; } }
        public string Name {  get { return _name; } set { _name = value; } }
    }
}
