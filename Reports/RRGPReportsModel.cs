using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Reports
{

    public class RRGPReport_billWiseDetails : ReportViewModel
    {
        public int? RRGPNo { get; set; }
        public DateTime RRGPDate { get; set; }
        public int? SrNo { get; set; }
        public string RawDesc { get; set; }
        public string UnitName { get; set; }
        public decimal? SaleRate { get; set; }
        public decimal? QTY { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Disc { get; set; }
        public decimal? DiscAmt { get; set; }
        public decimal? CGST { get; set; }
        public decimal? SGST { get; set; }
        public decimal? GSTAmount { get; set; }
        public decimal? BillAmt { get; set; }
        public decimal? TotalAmount { get; set; }
        public string AccName { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string GSTIN { get; set; }
        public string SaleType { get; set; }

    }


    public class RRGPReport_ItemWiseDetails : ReportViewModel
    {
        public int? RRGPNo { get; set; }
        public DateTime RRGPDate { get; set; }
        public int? SrNo { get; set; }
        public string RawDesc { get; set; }
        public string UnitName { get; set; }
        public decimal? SaleRate { get; set; }
        public decimal? QTY { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Disc { get; set; }
        public decimal? DiscAmt { get; set; }
        public decimal? CGST { get; set; }
        public decimal? SGST { get; set; }
        public decimal? GSTAmount { get; set; }
        public decimal? BillAmt { get; set; }
        public string AccName { get; set; }

    }



    public class RRGPReports_BillWiseSummary : ReportViewModel
    {
        public int? RRGPNo { get; set; }
        public DateTime RRGPDate { get; set; }
        public string AccName { get; set; }
        public decimal CGST { get; set; }
        public decimal CGSTAmt { get; set; }
        public decimal SGST { get; set; }
        public decimal SGSTAmt { get; set; }
        public decimal? RRGPAmt { get; set; }
        public decimal? TaxableAmt { get; set; }
        public string SaleType { get; set; }

    }
    public class RRGPReportsFiltterModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int ReportType { get; set; }
        public string ReportName { get; set; }
        public int? AccCode { get; set; }
        public int? LocationCode { get; set; }
        public int? TypeCode { get; set; }
        public int? SeriesCode { get; set; }
        public int? RawGroupCode { get; set; }
        public int? RawCode { get; set; }
    }
}
