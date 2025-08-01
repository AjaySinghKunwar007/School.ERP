using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Reports
{
    public class PurcReport_BillWiseDetailModel :ReportViewModel
    {
        public int? PurcCode { get; set; }
        public int? SrNo { get; set; }
        public int? PurcBillNo { get; set; }
        public string AccName { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string GSTIN { get; set; }
        public DateTime PurcDate { get; set; }
        public string RawDesc { get; set; }
        public string UnitName { get; set; }
        public decimal? PurcRate { get; set; }
        public decimal? QTY { get; set; }
        public decimal? Amount { get; set; }
        public decimal? CGST { get; set; }
        public decimal? SGST { get; set; }
        public decimal? GSTAmount { get; set; }
        public decimal? BillAmount { get; set; }
   
       
    }
    public class PurcReport_BillWiseSummaryModel : ReportViewModel
    {
        public int? Purc_BillNo { get; set; }
        public DateTime Purc_Date { get; set; }
        public string AccName { get; set; }
        public decimal? BillAmt { get; set; }
        
    }
    public class PurcReport_DateWiseModel : ReportViewModel
    {
        public int SrNo { get; set; }
    }
    public class PurcReport_FiltterModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate{ get; set; }
        public int? ReportType{ get; set; }
        public int? AccCode { get; set; }
        public int? TypeCode { get; set; }
        public int? SeriesCode { get; set; }
        public int? LocationCode { get; set; }
    }
}
