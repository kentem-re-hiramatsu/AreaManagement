using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaManagement.model
{
    public class AreaListModel
    {
        public List<AreaModel> areaList = new List<AreaModel>();

        public List<AreaModel> GetAreaList()
        {
            return areaList;
        }
    }
}
