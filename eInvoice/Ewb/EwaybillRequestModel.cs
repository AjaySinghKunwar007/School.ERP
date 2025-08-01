using Newtonsoft.Json;

namespace Optimum.EInvoice.Windows.Models.Ewb
{
    public class EwaybillRequestModel
    {
        [JsonProperty("supplyType")]
        public string SupplyType { get; set; }

        [JsonProperty("subSupplyType")]
        public string SubSupplyType { get; set; }

        [JsonProperty("subSupplyDesc")]
        public string SubSupplyDesc { get; set; }

        [JsonProperty("docType")]
        public string DocType { get; set; }

        [JsonProperty("docNo")]
        public string DocNo { get; set; }

        [JsonProperty("docDate")]
        public string DocDate { get; set; }

        [JsonProperty("fromGstin")]
        public string FromGstin { get; set; }

        [JsonProperty("fromTrdName")]
        public string FromTrdName { get; set; }

        [JsonProperty("fromAddr1")]
        public string FromAddr1 { get; set; }

        [JsonProperty("fromAddr2")]
        public string FromAddr2 { get; set; }

        [JsonProperty("fromPlace")]
        public string FromPlace { get; set; }

        [JsonProperty("fromPincode")]
        public string FromPincode { get; set; }  //int

        [JsonProperty("actFromStateCode")]
        public string ActFromStateCode { get; set; }

        [JsonProperty("fromStateCode")]
        public string FromStateCode { get; set; }

        [JsonProperty("toGstin")]
        public string ToGstin { get; set; }

        [JsonProperty("toTrdName")]
        public string ToTrdName { get; set; }

        [JsonProperty("toAddr1")]
        public string ToAddr1 { get; set; }

        [JsonProperty("toAddr2")]
        public string ToAddr2 { get; set; }

        [JsonProperty("toPlace")]
        public string ToPlace { get; set; }

        [JsonProperty("toPincode")]
        public string ToPincode { get; set; }

        [JsonProperty("actToStateCode")]
        public string ActToStateCode { get; set; }

        [JsonProperty("toStateCode")]
        public string ToStateCode { get; set; }

        [JsonProperty("transactionType")]
        public string TransactionType { get; set; }

        [JsonProperty("otherValue")]
        public decimal? OtherValue { get; set; }

        [JsonProperty("totalValue")]
        public decimal? TotalValue { get; set; }

        [JsonProperty("cgstValue")]
        public decimal? CgstValue { get; set; }

        [JsonProperty("sgstValue")]
        public decimal? SgstValue { get; set; }

        [JsonProperty("igstValue")]
        public decimal? IgstValue { get; set; }

        [JsonProperty("cessValue")]
        public decimal? CessValue { get; set; }

        [JsonProperty("cessNonAdvolValue")]
        public decimal? CessNonAdvolValue { get; set; }

        [JsonProperty("totInvValue")]
        public decimal? TotInvValue { get; set; }

        [JsonProperty("transporterId")]
        public string TransporterId { get; set; }

        [JsonProperty("transporterName")]
        public string TransporterName { get; set; }

        [JsonProperty("transDocNo")]
        public string TransDocNo { get; set; }

        [JsonProperty("transMode")]
        public int TransMode { get; set; }

        [JsonProperty("transDistance")]
        public int? TransDistance { get; set; } // Int

        [JsonProperty("transDocDate")]
        public string TransDocDate { get; set; }

        [JsonProperty("vehicleNo")]
        public string VehicleNo { get; set; }

        [JsonProperty("vehicleType")]
        public string VehicleType { get; set; }

        [JsonProperty("itemList")]
        public IEnumerable<EwaybillItemList> ItemList { get; set; }
    }

    public partial class EwaybillItemList
    {
        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("productDesc")]
        public string ProductDesc { get; set; }

        [JsonProperty("hsnCode")]
        public string HsnCode { get; set; }

        [JsonProperty("quantity")]
        public decimal Quantity { get; set; }

        [JsonProperty("qtyUnit")]
        public string QtyUnit { get; set; }

        [JsonProperty("cgstRate")]
        public decimal? CgstRate { get; set; }

        [JsonProperty("sgstRate")]
        public decimal? SgstRate { get; set; }

        [JsonProperty("igstRate")]
        public decimal? IgstRate { get; set; }

        [JsonProperty("cessRate")]
        public decimal? CessRate { get; set; }

        [JsonProperty("cessNonadvol")]
        public decimal? CessNonadvol { get; set; }

        [JsonProperty("taxableAmount")]
        public decimal? TaxableAmount { get; set; }
    }

    public class EInvoiceresponseModel
    {
        public DateTime? EntryTime { get; set; }
        public decimal BlNo { get; set; }
        public string RequestJson { get; set; }
        public string ResponseJson { get; set; }
        public string InvType { get; set; }
    }
}