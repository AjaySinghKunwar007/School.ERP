using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Inventory
{
    public class SaleReturnMasModel
    {

        public int SaleReturnCode { get; set; }
        public int SeriesCode { get; set; }
        public int EntryNo { get; set; }
        public DateTime EntryDate { get; set; }
        public string SaleReturnNo { get; set; }
        public DateTime SaleReturnDate { get; set; }
        public int yearcode { get; set; }
        public int VoucherCode { get; set; }
        public string vseries { get; set; }
        public string ChallanNo { get; set; }
        public DateTime? ChallanNoDate { get; set; }
        public int SaleReturnTypeCode { get; set; }
        public int AccCode { get; set; }
        public string AccName { get; set; } //Add On
        public string SeriesName { get; set; } //Add On
        public decimal TotalAmt { get; set; }
        public decimal TaxableAmt { get; set; }
        public decimal BillAmt { get; set; }
        public decimal GST1Perc { get; set; }
        public decimal GST1Amt { get; set; }
        public decimal GST2 { get; set; }
        public decimal GST2Amt { get; set; }
        public decimal GST3 { get; set; }
        public decimal GST3Amt { get; set; }
        public string transport { get; set; }
        public string grno { get; set; }
        public string carrier { get; set; }
        public string ordno { get; set; }
        public DateTime? orddate { get; set; }
        public string narr { get; set; }
        public int SaleReturncatog { get; set; }
        public int SaleReturnAccCode { get; set; }
        public string COther1 { get; set; }
        public string COther2 { get; set; }
        public string COther3 { get; set; }
        public string COther4 { get; set; }
        public string COther5 { get; set; }
        public decimal Other1 { get; set; }
        public decimal Other2 { get; set; }
        public decimal Other3 { get; set; }
        public decimal Other4 { get; set; }
        public decimal Other5 { get; set; }
        public int CreditDays { get; set; }
        public string InvType { get; set; }
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
        public int AccCodeOther1 { get; set; }
        public int AccCodeOther2 { get; set; }
        public int AccCodeOther3 { get; set; }
        public int AccCodeOther4 { get; set; }
        public int AccCodeOther5 { get; set; }
        public int LocationCode { get; set; }
        public int IsSync { get; set; }
        public int IsReturn { get; set; }
    }
    public class SaleReturnDetModel
    {
        public int SaleReturnCode { get; set; }
        public int MrnCode { get; set; }
        public int POCode { get; set; }
        public int SrNo { get; set; }
        public int RawCode { get; set; }
        public decimal Qty { get; set; }
        public decimal SaleReturnRate { get; set; }
        public decimal GST1Perc { get; set; }
        public decimal GST1Amt { get; set; }
        public decimal GST2Perc { get; set; }
        public decimal GST2Amt { get; set; }
        public decimal CessPerc { get; set; }
        public decimal CessAmt { get; set; }
        public decimal SaleRate { get; set; }
        public decimal Amount { get; set; }
        public int HSNCode { get; set; }
        public decimal MRP { get; set; }
        public decimal Disc { get; set; }
        public decimal DiscAmt { get; set; }
        public decimal Rate { get; set; } //Add On
        public string RawName { get; set; } // Add On
        public string RawCodeNew { get; set; } // Add On
        public string SaleReturnDet_Opfield1 { get; set; }
        public string SaleReturnDet_Opfield2 { get; set; }
        public string SaleReturnDet_Opfield3 { get; set; }
        public string SaleReturnDet_Opfield4 { get; set; }
        public string SaleReturnDet_Opfield5 { get; set; }
        public string SaleReturnDet_Opfield6 { get; set; }
        public string SaleReturnDet_Opfield7 { get; set; }
        public string SaleReturnDet_Opfield8 { get; set; }
        public string SaleReturnDet_Opfield9 { get; set; }
        public string SaleReturnDet_Opfield10 { get; set; }

    }
  

    public class SaleReturnMasFilterModel
    {
        public int? SaleReturnCode { get; set; }
        public int? AccCode { get; set; }
        public int SeriesCode { get; set; }
        public int EntryNo { get; set; }
    }
}
