using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Reports
{
    public class PIReportModel : ReportViewModel
    {
        public int PICode { get; set; }
        public DateTime PIDate { get; set; }
        public int SeriesCode { get; set; }
        public int DocNo { get; set; }
        public string chno { get; set; }
        public DateTime? chdate { get; set; }
        public int SaleCatog { get; set; }
        public int SalePurcType { get; set; }
        public int AccCode { get; set; }
        public decimal TaxableAmt { get; set; }
        public decimal TotalAmt { get; set; }
        public decimal BillAmt { get; set; }
        public decimal GST1 { get; set; }
        public decimal GST1Amt { get; set; }
        public decimal GST2 { get; set; }
        public decimal GST2Amt { get; set; }
        public decimal GST3 { get; set; }
        public decimal GST3Amt { get; set; }
        public string ordno { get; set; }
        public DateTime orddate { get; set; }
        public string SeriesName { get; set; }
        public string AccName { get; set; }
        // Item Details
        public string RawDesc { get; set; }
        public int RawCode { get; set; }
        public int SrNo { get; set; }
        public int Pack { get; set; }
        public int PerPackQty { get; set; }
        public decimal qty { get; set; }
        public decimal PIRate { get; set; }
        public decimal Detail_GST1 { get; set; }
        public decimal Detail_GST1Amt { get; set; }
        public decimal Detail_GST2 { get; set; }
        public decimal Detail_GST2Amt { get; set; }
        public decimal Amount { get; set; }
        public decimal ItRate { get; set; }
        public decimal ItMrp { get; set; }
        public decimal Disc { get; set; }
        public decimal DiscAmt { get; set; }
        public string RawCodeNew { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal NOS { get; set; }
        public string RawName { get; set; }
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
    }
    public class PIReportFiltterModel
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
