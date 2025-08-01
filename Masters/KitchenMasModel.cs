using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Masters
{
    public class KitchenMasModel
    {
        public int KitchenCode { get; set; }
        public string KitchenName { get; set; }
        public string PrinterName { get; set; }
        public string Driver { get; set; }
        public string KOTFormat { get; set; }
        public  int IsDeleted { get; set; }
    }

    public class KitchenMasFillterModel
    {
        public int? KitchenCode { get; set; }
        public string KitchenName { get; set; }
        public int? CompanyCode { get; set; }
        public int? LocationCode { get; set; }
    }
}
