using Newtonsoft.Json;

namespace Optimum.EInvoice.Windows.Models.EInvoice
{
    public partial class EInvoiceModel
    {
        [JsonProperty("Version")]
        public string Version { get; set; }

        [JsonProperty("TranDtls")]
        public TranDtls TranDtls { get; set; }

        [JsonProperty("DocDtls")]
        public DocDtls DocDtls { get; set; }

        [JsonProperty("BuyerDtls")]
        public Dtls BuyerDtls { get; set; }

        [JsonProperty("SellerDtls")]
        public Dtls SellerDtls { get; set; }

        [JsonProperty("DispDtls")]
        public DispDtls DispDtls { get; set; }

        [JsonProperty("ShipDtls")]
        public Dtls ShipDtls { get; set; }

        [JsonProperty("EwbDtls")]
        public EwbDtls EwbDtls { get; set; }

        [JsonProperty("ExpDtls")]
        public ExpDtls ExpDtls { get; set; }

        [JsonProperty("ItemList")]
        public IEnumerable<ItemList> ItemList { get; set; }

        [JsonProperty("ValDtls")]
        public ValDtls ValDtls { get; set; }

        [JsonProperty("PayDtls")]
        public PayDtls PayDtls { get; set; }

        [JsonProperty("RefDtls")]
        public RefDtls RefDtls { get; set; }

        [JsonProperty("AddlDocDtls")]
        public IEnumerable<AddlDocDtl> AddlDocDtls { get; set; }
    }

    public partial class AddlDocDtl
    {
        [JsonProperty("Url")]
        public Uri Url { get; set; }

        [JsonProperty("Docs")]
        public string Docs { get; set; }

        [JsonProperty("Info")]
        public string Info { get; set; }
    }

    public partial class Dtls
    {
        [JsonProperty("Gstin")]
        public string Gstin { get; set; }

        [JsonProperty("LglNm")]
        public string LglNm { get; set; }

        [JsonProperty("TrdNm")]
        public string TrdNm { get; set; }

        [JsonProperty("Pos")]
        public string Pos { get; set; }

        [JsonProperty("Addr1")]
        public string Addr1 { get; set; }

        [JsonProperty("Addr2")]
        public string Addr2 { get; set; }

        [JsonProperty("Loc")]
        public string Loc { get; set; } //string

        [JsonProperty("Pin")]
        public string Pin { get; set; }

        [JsonProperty("Stcd")]
        public string Stcd { get; set; }

        [JsonProperty("Ph")]
        public string Ph { get; set; }

        [JsonProperty("Em")]
        public string Em { get; set; }
    }

    public partial class DispDtls
    {
        [JsonProperty("Nm")]
        public string Nm { get; set; }

        [JsonProperty("Addr1")]
        public string Addr1 { get; set; }

        [JsonProperty("Addr2")]
        public string Addr2 { get; set; }

        [JsonProperty("Loc")]
        public string Loc { get; set; } 

        [JsonProperty("Pin")]
        public string Pin { get; set; } //string

        [JsonProperty("Stcd")]
        public string Stcd { get; set; }
    }

    public partial class DocDtls
    {
        [JsonProperty("Typ")]
        public string Typ { get; set; }

        [JsonProperty("No")]
        public string No { get; set; }

        [JsonProperty("Dt")]
        public string Dt { get; set; }
    }

    public partial class EwbDtls
    {
        [JsonProperty("Irn")]
        public string IRN { get; set; }

        [JsonProperty("TransId")]
        public string TransId { get; set; }

        [JsonProperty("TransName")]
        public string TransName { get; set; }

        [JsonProperty("TransMode")]
        public string TransMode { get; set; }

        [JsonProperty("Distance")]
        public int? Distance { get; set; }

        [JsonProperty("TransDocNo")]
        public string TransDocNo { get; set; }

        [JsonProperty("TransDocDt")]
        public string TransDocDt { get; set; }

        [JsonProperty("VehNo")]
        public string VehNo { get; set; }

        [JsonProperty("VehType")]
        public string VehType { get; set; }
    }

    public partial class ExpDtls
    {
        [JsonProperty("ShipBNo")]
        public string ShipBNo { get; set; }

        [JsonProperty("ShipBDt")]
        public DateTime? ShipBDt { get; set; }

        [JsonProperty("CntCode")]
        public string CntCode { get; set; }

        [JsonProperty("ForCur")]
        public string ForCur { get; set; }

        [JsonProperty("Port")]
        public string Port { get; set; }

        [JsonProperty("RefClm")]
        public string RefClm { get; set; }

        [JsonProperty("ExpDuty")]
        public decimal? ExpDuty { get; set; }
    }

    public partial class ItemList : AttribDtl
    {
        [JsonProperty("AttribDtls")]
        public AttribDtl[] AttribDtls { get; set; }

        [JsonProperty("PrdSlNo")]
        public string PrdSlNo { get; set; }

        [JsonProperty("OrgCntry")]
        public string OrgCntry { get; set; }

        [JsonProperty("OrdLineRef")]
        public string OrdLineRef { get; set; }

        [JsonProperty("TotItemVal")]
        public decimal? TotItemVal { get; set; }

        [JsonProperty("OthChrg")]
        public decimal? OthChrg { get; set; }

        [JsonProperty("StateCesNonAdvlAmt")]
        public decimal? StateCesNonAdvlAmt { get; set; }

        [JsonProperty("StateCesAmt")]
        public decimal? StateCesAmt { get; set; }

        [JsonProperty("StateCesRt")]
        public decimal? StateCesRt { get; set; }

        [JsonProperty("CesNonAdvlAmt")]
        public decimal? CesNonAdvlAmt { get; set; }

        [JsonProperty("CesAmt")]
        public decimal? CesAmt { get; set; }

        [JsonProperty("CesRt")]
        public decimal? CesRt { get; set; }

        [JsonProperty("SgstAmt")]
        public decimal? SgstAmt { get; set; }

        [JsonProperty("CgstAmt")]
        public decimal? CgstAmt { get; set; }

        [JsonProperty("IgstAmt")]
        public decimal? IgstAmt { get; set; }

        [JsonProperty("Qty")]
        public decimal? Qty { get; set; }

        [JsonProperty("AssAmt")]
        public decimal? AssAmt { get; set; }

        [JsonProperty("PreTaxVal")]
        public decimal? PreTaxVal { get; set; }

        [JsonProperty("Discount")]
        public decimal? Discount { get; set; }

        [JsonProperty("TotAmt")]
        public decimal? TotAmt { get; set; }

        [JsonProperty("UnitPrice")]
        public decimal? UnitPrice { get; set; }

        [JsonProperty("Unit")]
        public string Unit { get; set; }

        [JsonProperty("FreeQty")]
        public decimal? FreeQty { get; set; }

        [JsonProperty("GstRt")]
        public decimal? GstRt { get; set; }

        [JsonProperty("Barcde")]
        public string Barcde { get; set; }

        [JsonProperty("BchDtls")]
        public BchDtls BchDtls { get; set; }

        [JsonProperty("HsnCd")]
        public string HsnCd { get; set; }

        [JsonProperty("IsServc")]
        public string IsServc { get; set; }

        [JsonProperty("PrdDesc")]
        public string PrdDesc { get; set; }

        [JsonProperty("SlNo")]
        public int? SlNo { get; set; }
    }

    public partial class ValDtls
    {
        public decimal? AssVal { get; set; }
        public decimal? CgstVal { get; set; }
        public decimal? SgstVal { get; set; }
        public decimal? IgstVal { get; set; }
        public decimal? CesVal { get; set; }
        public decimal? StCesVal { get; set; }
        public decimal? RndOffAmt { get; set; }
        public decimal? TotInvVal { get; set; }
        public decimal? TotInvValFc { get; set; }
        public decimal? Discount { get; set; }
        public decimal? OthChrg { get; set; }
    }

    public partial class AttribDtl
    {
        [JsonProperty("Nm")]
        public string Nm { get; set; }

        [JsonProperty("Val")]
        public decimal? Val { get; set; }
    }

    public partial class BchDtls
    {
        [JsonProperty("Nm")]
        public long? Nm { get; set; }

        [JsonProperty("ExpDt")]
        public string ExpDt { get; set; }

        [JsonProperty("WrDt")]
        public string WrDt { get; set; }
    }

    public partial class PayDtls
    {
        [JsonProperty("Nm")]
        public string Nm { get; set; }

        [JsonProperty("AccDet")]
        public string AccDet { get; set; }

        [JsonProperty("Mode")]
        public string Mode { get; set; }

        [JsonProperty("FinInsBr")]
        public string FinInsBr { get; set; }

        [JsonProperty("CrTrn")]
        public string CrTrn { get; set; }

        [JsonProperty("PayInstr")]
        public string PayInstr { get; set; }

        [JsonProperty("PayTerm")]
        public long? PayTerm { get; set; }

        [JsonProperty("DirDr")]
        public string DirDr { get; set; }

        [JsonProperty("CrDay")]
        public long? CrDay { get; set; }

        [JsonProperty("PaidAmt")]
        public long? PaidAmt { get; set; }

        [JsonProperty("PaymtDue")]
        public long? PaymtDue { get; set; }
    }

    public partial class RefDtls
    {
        [JsonProperty("InvRm")]
        public string InvRm { get; set; }

        [JsonProperty("PrecDocDtls")]
        public IEnumerable<PrecDocDtl> PrecDocDtls { get; set; }

        [JsonProperty("ContrDtls")]
        public IEnumerable<ContrDtl> ContrDtls { get; set; }

        [JsonProperty("DocPerdDtls")]
        public DocPerdDtls DocPerdDtls { get; set; }
    }

    public partial class ContrDtl
    {
        [JsonProperty("RecAdvDt")]
        public string RecAdvDt { get; set; }

        [JsonProperty("RecAdvRefr")]
        public string RecAdvRefr { get; set; }

        [JsonProperty("TendRefr")]
        public string TendRefr { get; set; }

        [JsonProperty("ContrRefr")]
        public string ContrRefr { get; set; }

        [JsonProperty("ExtRefr")]
        public string ExtRefr { get; set; }

        [JsonProperty("ProjRefr")]
        public string ProjRefr { get; set; }

        [JsonProperty("PORefr")]
        public string PoRefr { get; set; }

        [JsonProperty("PORefDt")]
        public string PoRefDt { get; set; }
    }

    public partial class DocPerdDtls
    {
        [JsonProperty("InvStDt")]
        public string InvStDt { get; set; }

        [JsonProperty("InvEndDt")]
        public string InvEndDt { get; set; }
    }

    public partial class PrecDocDtl
    {
        [JsonProperty("InvNo")]
        public string InvNo { get; set; }

        [JsonProperty("InvDt")]
        public string InvDt { get; set; }

        [JsonProperty("OthRefNo")]
        public long? OthRefNo { get; set; }
    }

    public partial class TranDtls
    {
        [JsonProperty("TaxSch")]
        public string TaxSch { get; set; }

        [JsonProperty("SupTyp")]
        public string SupTyp { get; set; } //string

        [JsonProperty("RegRev")]
        public string RegRev { get; set; }

        [JsonProperty("EcmGstin")]
        public object EcmGstin { get; set; }

        [JsonProperty("IgstOnIntra")]
        public string IgstOnIntra { get; set; }
    }
}