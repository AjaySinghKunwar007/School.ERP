using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Inventory
{
    public class IndentMasModel
    {
        public int IndentCode { get; set; }
        public int SeriesCode { get; set; }
        public string SeriesName { get; set; }
        public int IndentDocNo { get; set; }
        public int AccCode { get; set; }
        public string AccName { get; set; }
        public int LocationCode { get; set; }
        public string LocationName { get; set; }
        public int Approval { get; set; }
        public DateTime IndentDate { get; set; }
        public string BuyerRefNo { get; set; }
        public string Remarks { get; set; }
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
    public class IndentDetModel
    {
        public int IndentCode { get; set; }
        public int SrNO { get; set; }
        public int RawCode { get; set; }
        public string RawDesc { get; set; }
        public decimal QtyIndent { get; set; }
        public decimal QtyApprove { get; set; }
        public DateTime? TargetDate { get; set; }
        public string Opfield_1 { get; set; }
        public string Opfield_2 { get; set; }
        public string Opfield_3 { get; set; }
        public string Opfield_4 { get; set; }
        public string Opfield_5 { get; set; }
        public string Opfield_6 { get; set; }
        public string Opfield_7 { get; set; }
        public string Opfield_8 { get; set; }
        public string Opfield_9 { get; set; }
        public string Opfield_10 { get; set; }


    }
    public class IndentMasFilterModel
    {
        public int? AccCode { get; set; }
        public int? SeriesCode { get; set; }
        public string AccName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
