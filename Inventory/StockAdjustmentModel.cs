using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Inventory
{
    public class StockAdjustmentModel
    {
        public int AdjustCode { get; set; }
        public int DocNo { get; set; }
        public DateTime AdjustDate { get; set; }
        public string Narration { get; set; }
        public string IsSync { get; set; }
    }
    public class StockAdjustmentFillterModel
    {
        public int? AdjustCode { get; set; }
        public int? DocNo { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
     
    }

    public class StockAdjustmentDet
    {
        public int AdjustCode { get; set; }
        public int SrNo { get; set; }
        public int RawCode { get; set; }
        public string RawName { get; set; }//AddOn
        public decimal Qty { get; set; }
        public string Remarks { get; set; }
    }

    public class GetNewAdjustmentCodeModel
    {
        public int AdjustCode { get; set; }
  
    }

}
