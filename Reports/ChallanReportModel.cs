using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Reports
{
    public class ChallanReport_Detail_Model : ReportViewModel
    {
        public int? ChallanCode { get; set; }
        public int? ChallanBillNo { get; set; }
        public DateTime ChallanDate { get; set; }
        public int? SrNo { get; set; }
        public string RawDesc { get; set; }
        public string UnitName { get; set; }
        public decimal? Rate { get; set; }
        public decimal? QTY { get; set; }
        public decimal? Amount { get; set; }
        public decimal? CGST { get; set; }
        public decimal? SGST { get; set; }
        public decimal? GSTAmount { get; set; }
        public decimal? ChallanAmt { get; set; }
    }
    public class ChallanReport_Summary_Model : ReportViewModel
    {
    }
    public class ChallanReport_Fillter_Model 
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int? ReportType { get; set; }
        public int? LocationCode { get; set; }
        public int? AccCode { get; set; }
    }
}
