namespace Optimum.EInvoice.Windows.Models.Invoice
{
    public class InvoiceFilterModel
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? AccCode { get; set; }
        public int? SeriesCode { get; set; }
    }

    internal class SeriesModel
    {
        public int SeriesNo { get; set; }
        public string Series { get; set; }
        public string SeriesCode { get; set; }
    }

    public class InvoiceModel
    {
        public string SeriesName { get; set; }
        public int InvCode { get; set; }
        public int DocNo { get; set; }
        public DateTime InvDate { get; set; }
        public string GSTIN { get; set; }
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
}
