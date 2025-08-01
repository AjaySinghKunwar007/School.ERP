namespace Optimum.EInvoice.Windows.Models.EInvoice
{
    public partial class EInvoiceHeadersModel
    {
        public string GSTIN { get; set; }
        public string CustomerName { get; set; }
        public string Branch { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string CustomerId { get; set; }
        public string APIId { get; set; }
        public string APISecret { get; set; }
        public string Source => "API";
        public string Url { get; set; }
    }
}