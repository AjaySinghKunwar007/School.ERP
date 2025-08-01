using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Inventory
{
    public class ChallanMasModel
    {
        public int ChallanCode { get; set; }
        public DateTime ChallanDate { get; set; }
        public int SeriesCode { get; set; }
        public string SeriesName { get; set; }
        public int DocNo { get; set; }
        public int AccCode { get; set; }
        public int AccCodeShipTo { get; set; }
        public string Transport { get; set; }
        public string Carrier { get; set; }
        public string Freight { get; set; }
        public int Type { get; set; }
        public int LocationCode { get; set; }
        public string Remarks { get; set; }
        public int YearCode { get; set; }
        public int SaleCode { get; set; }
        public string OrdNo { get; set; }
        public DateTime Orddate { get; set; }
        public decimal TotalAmt { get; set; }
        public decimal ChallanAmt { get; set; }
        public string RemovelTime { get; set; }
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
        public int STypeCode { get; set; }
        public decimal TaxPerc1 { get; set; }
        public decimal TaxPerc2 { get; set; }
        public decimal TaxPerc3 { get; set; }
        public decimal TaxAmt1 { get; set; }
        public decimal TaxAmt2 { get; set; }
        public decimal TaxAmount3 { get; set; }
        public int DeptCode { get; set; }
        public decimal TaxableAmt { get; set; }
        public int AccCOtherOther1 { get; set; }
        public int AccCOtherOther2 { get; set; }
        public int AccCOtherOther3 { get; set; }
        public int AccCOtherOther4 { get; set; }
        public int AccCOtherOther5 { get; set; }
        public decimal OtherPerc1 { get; set; }
        public decimal OtherPerc2 { get; set; }
        public decimal OtherPerc3 { get; set; }
        public decimal OtherPerc4 { get; set; }
        public decimal OtherPerc5 { get; set; }
        public decimal OtherAmt1 { get; set; }
        public decimal OtherAmt2 { get; set; }
        public decimal OtherAmt3 { get; set; }
        public decimal OtherAmt4 { get; set; }
        public decimal OtherAmt5 { get; set; }
        public string AccName { get; set; } // Add on
        public string Disp_fromAddr1 { get; set; }
        public string Disp_fromAddr2 { get; set; }
        public string Disp_fromPlace { get; set; }
        public string Disp_fromPincode { get; set; }
        public string Disp_actFromStateCode { get; set; }
        public string LocationName { get; set; }


    }
    public class ChallanDetModel
    {

        public int ChallanCode{ get; set; }
        public int SrNo { get; set; }
        public int RawCode { get; set; }
        public string RawCodeNew { get; set; } //AddOn
        public string RawName { get; set; } //AddOn
        public decimal Qty { get; set; }
        public int Pack { get; set; }
        public int PerPackQty { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public string Remarks { get; set; }
        public string Desc { get; set; }
        public int YearCode { get; set; }
        public int ToBill { get; set; }
        public int Process { get; set; }
        public string Opfield1 { get; set; }
        public string Opfield2 { get; set; }
        public string Opfield3 { get; set; }
        public string Opfield4 { get; set; }
        public string Opfield5 { get; set; }
        public string Opfield6 { get; set; }
        public string Opfield7 { get; set; }
        public string Opfield8 { get; set; }
        public string Opfield9 { get; set; }
        public string Opfield10 { get; set; }
        public int LocationCode { get; set; }
        public string LocationName { get; set; }

    }

    public class ChallanMasFiltterModel
    {
        public int? ChallanCode { get; set; }
        public int? AccCode { get; set; }
        public int? SeriesNo { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }


    public class GetNewChallanCodeModel
    {
        public int ChallanCode { get; set; }
    }
}


    