using Newtonsoft.Json;
using Optimum.EInvoice.Windows.Models.EInvoice;

namespace Optimum.EInvoice.Windows.Models.Ewb
{
    public partial class EwaybillResponseModel
    {
        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("data")]
        public EwaybillResponseData Data { get; set; }

        [JsonProperty("infodtls")]
        public object Infodtls { get; set; }

        [JsonProperty("Error")]
        public Error[] Errors { get; set; }
    }

    public partial class EwaybillResponseData
    {
        [JsonProperty("ewayBillNo")]
        public string EwayBillNo { get; set; }

        [JsonProperty("ewayBillDate")]
        public string EwayBillDate { get; set; }

        [JsonProperty("validUpto")]
        public string ValidUpto { get; set; }

        [JsonProperty("alert")]
        public string Alert { get; set; }

        [JsonProperty("cancelDate")]
        public string CancelDate { get; set; }
    }
}