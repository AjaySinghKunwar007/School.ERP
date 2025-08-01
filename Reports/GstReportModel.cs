using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Optimum.ERP.Models.Reports
{
    public class GstReportModel : ReportViewModel
    {
        public string GSTIN { get; set; }
        public string AccName { get; set; }
        public string StateName { get; set; }
        public string StateCode { get; set; }
        public int DocNo { get; set; }
        public DateTime SaleDate { get; set; }
        public string SeriesPrintName { get; set; }
        public string SeriesSuffix { get; set; }
        public decimal Amount { get; set; }
        public decimal Qty { get; set; }
        public string UnitName { get; set; }
        public string HsnName { get; set; }
        public int Region { get; set; }
        public int TaxOn { get; set; }
        public decimal MasTax1 { get; set; }
        public decimal MasTaxAmount1 { get; set; }
        public decimal MasTax2 { get; set; }
        public decimal MasTaxAmount2 { get; set; }
        public decimal MasCess { get; set; }
        public decimal MasCessAmount { get; set; }
        public decimal DetTax1 { get; set; }
        public decimal DetTaxAmount1 { get; set; }
        public decimal DetTax2 { get; set; }
        public decimal DetTaxAmount2 { get; set; }
        public decimal DetCess { get; set; }
        public decimal DetCessAmount { get; set; }
      
    }
    public class GstReportFilterModel : ReportViewModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int? ReportName { get; set; }
        public int? AccCode { get; set; }
        public int? RegionCode { get; set; }
       


    }
    public class GstReportModel2 : ReportViewModel
    {
        //public int SrNo { get; set; }
        //public string PartyName { get; set; }
        //public string GSTINO { get; set; }
        //public string StateCode { get; set; }
        //public int INVNO { get; set; }
        //public DateTime INVDate { get; set; }
        //public int HSNCODE { get; set; }
        //public string ItemDescription { get; set; }
        //public string ItemCode { get; set; }
        //public int QTY { get; set; }
        //public string Unit { get; set; }
        //public decimal Rate { get; set; }
        //public decimal Disc { get; set; }
        //public decimal DiscAmt { get; set; }
        //public decimal ItemAmt { get; set; }
        //public decimal TotItemAmt { get; set; }
        //public decimal OtherAmt { get; set; }
        //public decimal Taxable { get; set; }
        //public decimal RatePerc { get; set; }
        //public decimal IgstAmt { get; set; }
        //public decimal CgstAmt { get; set; }
        //public int SgstAmt { get; set; }

        //public int BillAmt { get; set; }

        public string GSTIN { get; set; }
        public string AccName { get; set; }
        public string StateName { get; set; }
        public string StateCode { get; set; }
        public int DocNo { get; set; }
        public DateTime SaleDate { get; set; }
        public string SeriesPrintName { get; set; }
        public string SeriesSuffix { get; set; }
        public int RawCode { get; set; }
        public string RawName { get; set; }

        public decimal Amount { get; set; }
        public decimal Qty { get; set; }
        public string UnitName { get; set; }
        public string HsnName { get; set; }
        public int Region { get; set; }
        public int TaxOn { get; set; }
        public decimal MasTax1 { get; set; }
        public decimal MasTaxAmount1 { get; set; }
        public decimal MasTax2 { get; set; }
        public decimal MasTaxAmount2 { get; set; }
        public decimal MasCess { get; set; }
        public decimal MasCessAmount { get; set; }
        public decimal DetTax1 { get; set; }
        public decimal DetTaxAmount1 { get; set; }
        public decimal DetTax2 { get; set; }
        public decimal DetTaxAmount2 { get; set; }
        public decimal DetCess { get; set; }
        public decimal DetCessAmount { get; set; }

    }


}
