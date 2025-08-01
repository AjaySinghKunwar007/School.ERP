using Optimum.EInvoice.Windows.Models.EInvoice;

namespace Optimum.EInvoice.Windows.Models.Ewb
{
    public partial class EwaybillHeadersModel: EInvoiceHeadersModel
    {
        public string EnvironmentType { get; set; } = "Production";
    }
}