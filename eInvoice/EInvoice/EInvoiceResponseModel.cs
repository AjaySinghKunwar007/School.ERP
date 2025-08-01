using Newtonsoft.Json;

namespace Optimum.EInvoice.Windows.Models.EInvoice
{
    public partial class EInvoiceResponseModel
    {
        [JsonProperty("status_cd")]
        public int StatusCd { get; set; }

        [JsonProperty("response_data")]
        public ResponseData ResponseData { get; set; }

        //[JsonProperty("infodtls")]
        //public Infodtl[] Infodtls { get; set; }

        [JsonProperty("Error")]
        public Error[] Errors { get; set; }
    }


    public partial class DuplicateIrnDtl
    {
        [JsonProperty("status_cd")]
        public int status_cd { get; set; }

        [JsonProperty("Error")]
        public Error[] Error { get; set; }

        [JsonProperty("infodtls")]
        public DuplicateInfodtl[] infodtls { get; set; }
    }

    public partial class DuplicateInfodtl
    {
        [JsonProperty("InfCd")]
        public string InfCd { get; set; }

        [JsonProperty("Desc")]
        public ResponseData Desc { get; set; }
    }

    public partial class Infodtl
    {
        [JsonProperty("InfCd")]
        public string InfCd { get; set; }

        [JsonProperty("Desc")]
        public Error[] Desc { get; set; }
    }

    public partial class Desc : Error
    {
        [JsonProperty("AckNo")]
        public long AckNo { get; set; }

        [JsonProperty("AckDt")]
        public DateTimeOffset AckDt { get; set; }

        [JsonProperty("Irn")]
        public string Irn { get; set; }
    }

    public partial class Error
    {
        [JsonProperty("ErrorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("ErrorMessage")]
        public string ErrorMessage { get; set; }
    }

    public partial class ResponseData
    {
        [JsonProperty("AckNo")]
        public string AckNo { get; set; }

        [JsonProperty("AckDt")]
        public string AckDt { get; set; }

        [JsonProperty("Irn")]
        public string Irn { get; set; }

        [JsonProperty("SignedInvoice")]
        public string SignedInvoice { get; set; }

        [JsonProperty("SignedQrCode")]
        public string SignedQrCode { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("JwtIssuer")]
        public string JwtIssuer { get; set; }

        [JsonProperty("EwbNo")]
        public string EwbNo { get; set; }

        [JsonProperty("EwbDt")]
        public string EwbDt { get; set; }

        [JsonProperty("EwbValidTill")]
        public string EwbValidTill { get; set; }

        [JsonProperty("Remarks")]
        public string Remarks { get; set; }
    }
}