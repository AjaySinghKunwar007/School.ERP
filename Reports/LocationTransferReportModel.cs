using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Reports
{
  

    public class LocationTransferReportModel : ReportViewModel
    {
        public int? DocNo { get; set; }
        public DateTime TrfrDate { get; set; }
        public int? SrNo { get; set; }
        public string RawDesc { get; set; }
        public string UnitName { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? TotQty { get; set; }
        public decimal? TotAmount { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
    }
    public class LocationTransferReportFiltterModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int ReportType { get; set; }
        public string ReportName { get; set; }
        public int? ToLocationCode { get; set; }
        public int? TypeCode { get; set; }
    }
}
