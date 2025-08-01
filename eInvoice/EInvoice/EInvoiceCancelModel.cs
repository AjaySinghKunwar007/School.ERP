using Newtonsoft.Json;

namespace Optimum.EInvoice.Windows.Models.EInvoice
{
    public partial class EInvoiceCancelModel
    {
        [JsonProperty("Irn")]
        public string Irn { get; set; }

        [JsonProperty("CnlRsn")]
        public string CnlRsn => "1";

        [JsonProperty("CnlRem")]
        public string CnlRem => "Wrong entry";
    }

    public partial class EInvoiceCancelResponseModel
    {
        [JsonProperty("status_cd")]
        public int StatusCd { get; set; }

        [JsonProperty("response_data")]
        public EInvoiceCancelResponseData ResponseData { get; set; }

        [JsonProperty("infodtls")]
        public Infodtl[] Infodtls { get; set; }

        [JsonProperty("Error")]
        public Error[] Errors { get; set; }
    }

    public partial class EInvoiceCancelResponseData
    {
        [JsonProperty("Irn")]
        public string Irn { get; set; }

        [JsonProperty("CancelDate")]
        public DateTime CancelDate { get; set; }
    }
}