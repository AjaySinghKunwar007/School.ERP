using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.EInvoice.Windows.Models.EInvoice
{
    public class ChallanModel
    {
        public string SeriesCode { get; set; }
        public decimal BlNo { get; set; }
        public int DocNo { get; set; }
        public DateTime BlDate { get; set; }
        public string GSTNo { get; set; }
        public string AccName { get; set; }
        public decimal BillAmt { get; set; }
        public decimal taxableamt { get; set; }
        public string Irn { get; set; }
        public string AckNo { get; set; }
        public string AckDate { get; set; }
        public string CancelIRN { get; set; }
        public string EwayBillNo { get; set; }
        public string EWayBillCancelDate { get; set; }
        public string SignedQRCode { get; set; }
    }
    public class ChallanFilterModel
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? AccCode { get; set; }
        public int? SeriesNo { get; set; }
    }
}
