using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Reports
{
    public class JobWorkReportModel : ReportViewModel
    {
        public string AccName { get; set; }
        public int JobCardNo { get; set; }
        
        public DateTime JobCardDate { get; set; }
        public string RawDesc { get; set; }
        public string CoaterName { get; set; }
        public string CoatingDate { get; set; }
        public string InvoiceDate { get; set; }
        public string InvoiceNo { get; set; }
       

       
    }
    public class JobWorkReportFilterModel : ReportViewModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int? ReportName { get; set; }
        public int? AccCode { get; set; }
        public int? ItemCode { get; set; }
        public int? ItemGroupCode { get; set; }
        public int? JobWorkCode { get; set; }



    }
}
