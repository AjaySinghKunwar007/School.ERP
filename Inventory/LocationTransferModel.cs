using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Inventory
{
    public class LocationTransferModel
    {
        public int TrfrCode { get; set; }
        public DateTime TrfrDate { get; set; }
        public int DocNo { get; set; }
        public int SeriesCode { get; set; }
        public int LocationCodeFrom { get; set; }
        public int LocationCodeTo { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation {  get; set; }
        public int YearCode { get; set; }
        public decimal TotQty { get; set; }
        public decimal TotAmount { get; set; }
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
    public class LocationTransferFillterModel
    {
        public int TrfrCode { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int DocNo { get; set; }
        public int? LocationCodeFrom { get; set; }
        public int? LocationCodeTo { get; set; }
    }

    public class LocationTransferDetModel
    {
        public int TrfrCode { get; set; }
        public int SrNo { get; set; }
        public int RawCode { get; set; }
        public string RawName { get; set; }
        public decimal Qty { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
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


    public class GetNewLocationTRFRCodeModel
    {
        public int TrfrCode { get; set; }
    }
}
