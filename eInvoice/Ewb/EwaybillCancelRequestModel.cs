using Newtonsoft.Json;

namespace Optimum.EInvoice.Windows.Models.Ewb
{
    public class EwaybillCancelRequestModel
    {
        [JsonProperty("ewbNo")]
        public string EwbNo { get; set; }

        [JsonProperty("cancelRsnCode")]
        public string CancelRsnCode { get; set; } = "2";

        [JsonProperty("cancelRmrk")]
        public string CancelRemark { get; set; } = "Cancelled the order";
    }
}