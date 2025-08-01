namespace Optimum.ERP.Models.Inventory
{
    public class PurcMasModel
    {
        public int PurcCode { get; set; }
        public int SeriesCode { get; set; }
        public int EntryNo { get; set; }
        public DateTime EntryDate { get; set; }
        public string PurcNo { get; set; }
        public DateTime PurcDate { get; set; }
        public int yearcode { get; set; }
        public int VoucherCode { get; set; }
        public string vseries { get; set; }
        public string ChallanNo { get; set; }
        public DateTime? ChallanNoDate { get; set; }
        public int SalePurcTypeCode { get; set; }
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
        public int Purccatog { get; set; }
        public int PurcAccCode { get; set; }
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
        public string TypeName { get; set; }
        public int AccCodeOther1 { get; set; }
        public int AccCodeOther2 { get; set; }
        public int AccCodeOther3 { get; set; }
        public int AccCodeOther4 { get; set; }
        public int AccCodeOther5 { get; set; }
        public int LocationCode { get; set; }
        public int IsSync { get; set; }
        public int IsReturn { get; set; }
        public string LocationName { get; set; }
        public int TypeAccCode { get; set; }
        public int GSTAccCode1 { get; set; }
        public int GSTAccCode2 { get; set; }
        public int salePurcType { get; set; } //Used Is Only In API For Return Data
    }   
    
    public class PurcDetModel
    {
        public int PurcCode { get; set; } 
        public int MrnCode { get; set; }
        public int POCode { get; set; }
        public int SrNo { get; set; }
        public int RawCode { get; set; }
        public decimal Qty { get; set; }
        public decimal PurcRate { get; set; }
        public decimal ITTaxableAmt { get; set; }
        public decimal ToTItemAmount { get; set; }
        public decimal GST1Perc { get; set; }
        public decimal GST1Amt { get; set; }
        public decimal GST2Perc { get; set; }
        public decimal GST2Amt { get; set; }
        public decimal GST3Perc { get; set; }
        public decimal GST3Amt { get; set; }
        public decimal CessPerc { get; set; }
        public decimal CessAmt { get; set; }
        public decimal SaleRate { get; set; }
        public decimal Amount { get; set; }
        public int HSNCode { get; set; }
        public decimal MRP { get; set; }
        public decimal Disc { get; set; }
        public decimal DiscAmt{ get; set; }
        public decimal Rate { get; set; } //Add On
        public string RawName { get; set; } // Add On
        public string RawCodeNew { get; set; } // Add On
        public string PurcDet_Opfield1 { get; set; }
        public string PurcDet_Opfield2 { get; set; }
        public string PurcDet_Opfield3 { get; set; }
        public string PurcDet_Opfield4 { get; set; }
        public string PurcDet_Opfield5 { get; set; }
        public string PurcDet_Opfield6 { get; set; }
        public string PurcDet_Opfield7 { get; set; }
        public string PurcDet_Opfield8 { get; set; }
        public string PurcDet_Opfield9 { get; set; }
        public string PurcDet_Opfield10 { get; set; }
        public int LocationCode { get; set; }
        public string LocationName { get; set; }

    }
     public class PurcDetFilterModel {
      public int PurcCode { get; set; }
      public int RawCode { get; set; }
}

     public class PurcMasFilterModel
    {
        public int? PurcCode { get; set; }
        public int? AccCode { get; set; }
        public int SeriesCode { get; set; }
        public string Search { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int? LocationCode{ get; set; }
     }

}
