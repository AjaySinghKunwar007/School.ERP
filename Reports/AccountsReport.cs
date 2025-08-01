using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Reports
{
    public class AccountsReportModel : ReportViewModel
    {
        public DateTime? VouchDate { get; set; }
        public string PartyName { get; set; }
        public string AccountName { get; set; }
        public string VouchNarr { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Balance { get; set; }
    }

    public class AccountReportFilterModel
    {
        public int? AccCode { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int ReportType { get; set; }
    }
}
