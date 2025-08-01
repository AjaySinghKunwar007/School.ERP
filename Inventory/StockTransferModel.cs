using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Inventory
{
    public class StockTransferModel
    {
        public int TrfrCode { get; set; }
        public DateTime TrfrDate { get; set; }
        public int DocNo { get; set; }
        public int SeriesCode { get; set; }
        public int DeptCodeFrom { get; set; }
        public int DeptCodeTo { get; set; }
        public int YearCode { get; set; }
        public decimal TotQty { get; set; }
        public string Narr1 { get; set; }
        public string Narr2 { get; set; }
        public string Narr3 { get; set; }
        public string Narr4 { get; set; }
        public string Narr5 { get; set; }
        public string Narr6 { get; set; }
        public string Narr7 { get; set; }
        public string Narr8 { get; set; }
        public string Narr9 { get; set; }
        public string Narr10 { get; set; }
    }

    public class StockTransferFillterModel
    {
        public int TrfrCode { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int DocNo { get; set; }
        public int? DeptCodeFrom { get; set; }
        public int? DeptCodeTo { get; set; }
    }

    public class StockTransferDetModel
    {
        public int TrfrCode { get; set; }
        public int SrNo { get; set; }
        public int RawCode { get; set; }
        public string RawName { get; set; }
        public decimal Qty { get; set; }
        public string Unit { get; set; }
        public string Remark { get; set; }
        public int OpField1 { get; set; }
        public int OpField2 { get; set; }
        public int OpField3 { get; set; }
        public int OpField4 { get; set; }
        public int OpField5 { get; set; }
        public int OpField6 { get; set; }
        public int OpField7 { get; set; }
        public int OpField8 { get; set; }
        public int OpField9 { get; set; }
        public int OpField10 { get; set; }
    }


    public class GetNewTRFRCodeModel
    {
        public int TrfrCode { get; set; }
    }

}
