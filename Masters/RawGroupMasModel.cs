using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Masters
{
    public class RawGroupMasModel
    {
        public int RawGroupCode { get; set; }
        public string RawGroupName { get; set; }
        public string ShowPOST { get; set; }
        public string ShowSaleT { get; set; }
        public string ShowPurcT { get; set; }
        public string ShowChallanT { get; set; }
        public int ShowPOS { get; set; }
        public int ShowHeightWidth { get; set; }
        public string ShowHeightWidthT { get; set; }
        public int ShowSale { get; set; }
        public int ShowPurc { get; set; }
        public int ShowChallan { get; set; }
        public int LocationCode { get; set; }
        public string LocationName { get; set; }

    }

    public class RawGroupFiltterModel
    {
        public int? RawGroupCode { get; set; }
        public string RawGroupName { get; set; }
        public int? CompanyCode { get; set; }
        public int? LocationCode { get; set; }

    }
}
