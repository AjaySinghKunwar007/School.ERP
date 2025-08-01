using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Inventory
{
    public class LocationWiseStockModel
    {
        public string LocationName { get; set; }//AddOn
        public string RawName { get; set; }//AddOn
        public int LocationCode { get; set; }
        public int RawCode { get; set; }
        public decimal OpStock { get; set; }
    }
    public class LocationWiseStockFiltterModel
    {
        public int? LocationCode { get; set; }
        public int? RawCode { get; set; }
    }
}
