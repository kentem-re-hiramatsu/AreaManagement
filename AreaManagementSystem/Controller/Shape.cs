using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaManagement.model;

namespace AreaManagement.Controller
{
    public class Shape
    {
        AreaListModel listModel = new AreaListModel();

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

        public void AddAreaList(double area, string name)
        {
            var areaModel = new AreaModel();
            areaModel.TotalArea = area;
            areaModel.Name = name;

            listModel.areaList.Add(areaModel);
        }
    }
}
