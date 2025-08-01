using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Inventory
{
    public class PurchaseReturnMasModel
    {
        public int PurchaseReturnCode { get; set; }
        public DateTime PurchaseReturnDate { get; set; }
        public int SeriesCode { get; set; }
        public int DocNo { get; set; }
        public string VCode { get; set; }
        public string VoucherCode { get; set; }
        public int VSeries { get; set; }
        public int YearCode { get; set; }
        public string chno { get; set; }
        public DateTime? chdate { get; set; }
        public int SaleCatog { get; set; }
        public int SalePurcType { get; set; }
        public int modeofacc { get; set; }
        public int AccCode { get; set; }
        public decimal TaxableAmt { get; set; }
        public decimal TotalAmt { get; set; }
        public decimal BillAmt { get; set; }
        public decimal GST1 { get; set; }
        public decimal GST1Amt { get; set; }
        public decimal GST2 { get; set; }
        public decimal GST3Amt { get; set; }  //IGST Perc
        public decimal GST3 { get; set; } //IGST Amount

        public decimal GST2Amt { get; set; }
        public string COther1 { get; set; }
        public string COther2 { get; set; }
        public string COther3 { get; set; }
        public string COther4 { get; set; }
        public string COther5 { get; set; }
        public string COther6 { get; set; }
        public decimal OtherAmt1 { get; set; }
        public decimal OtherAmt2 { get; set; }
        public decimal OtherAmt3 { get; set; }
        public decimal OtherAmt4 { get; set; }
        public decimal OtherAmt5 { get; set; }
        public decimal OtherAmt6 { get; set; }
        public int AccCodeOther1 { get; set; }
        public int AccCodeOther2 { get; set; }
        public int AccCodeOther3 { get; set; }
        public int AccCodeOther4 { get; set; }
        public int AccCodeOther5 { get; set; }
        public int AccCodeOther6 { get; set; }
        public decimal Perc1 { get; set; }
        public decimal Perc2 { get; set; }
        public decimal Perc3 { get; set; }
        public decimal Perc4 { get; set; }
        public decimal Perc5 { get; set; }
        public string Transport { get; set; }
        public string grno { get; set; }
        public string carrier { get; set; }
        public string ordno { get; set; }
        public DateTime orddate { get; set; }
        public string InvType { get; set; }
        public string Narr1 { get; set; }
        public string Narr2 { get; set; }
        public string Narr3 { get; set; }
        public string Narr4 { get; set; }
        public string Narr5 { get; set; }
        public string Narr6 { get; set; }
        public string Narr7 { get; set; }
        public string Narr8 { get; set; }
        public string Narr9 { get; set; }
        public string Narr10 { get; set; }
        public string Narr11 { get; set; }
        public string Narr12 { get; set; }
        public string Narr13 { get; set; }
        public string Narr14 { get; set; }
        public string Narr15 { get; set; }
        public string Narr16 { get; set; }
        public string Narr17 { get; set; }
        public string Narr18 { get; set; }
        public string Narr19 { get; set; }
        public string PurchaseReturnNarration { get; set; }
        public int LocationCode { get; set; }
        public int DeptCode { get; set; }
        public int PurchaseReturnManCode { get; set; }
        public int IsSync { get; set; }
        public int EInvoice { get; set; }
        public string IRN { get; set; }
        public string IRNQR { get; set; }
        public string IRNResp { get; set; }
        public string AckNo { get; set; }
        public string AckDate { get; set; }
        public string SignedQRCode { get; set; }
        public string CancelIRN { get; set; }
        public DateTime CancelIRNDate { get; set; }
        public int Distance { get; set; }
        public string TransMode { get; set; }
        public string TransDocNo { get; set; }
        public string TransDocDate { get; set; }
        public string ewayBillNo { get; set; }
        public DateTime ewayBillDate { get; set; }
        public string EwbValidTill { get; set; }
        public int VehicleType { get; set; }
        public string ExpDtls_ShipBNo { get; set; }
        public DateTime ExpDtls_ShipBDt { get; set; }
        public string ExpDtls_CntCode { get; set; }
        public string ExpDtls_ForCur { get; set; }
        public string ExpDtls_Port { get; set; }
        public string ExpDtls_RefClm { get; set; }
        public decimal ExpDtls_ExpDuty { get; set; }
        public string EWayBillCancelDate { get; set; }
        public string SeriesName { get; set; } //Add On
        public string AccName { get; set; } // Add On
    }
    public class PurchaseReturnDetModel
    {
        public int PurchaseReturnCode { get; set; }
        public int RawCode { get; set; }
        public int SrNo { get; set; }
        public int Pack { get; set; }
        public int PerPackQty { get; set; }
        public decimal qty { get; set; }
        public decimal PurchaseReturnRate { get; set; }
        public decimal GST1 { get; set; }
        public decimal GST1Amt { get; set; }
        public decimal GST2 { get; set; }
        public decimal GST2Amt { get; set; }
        public decimal Amount { get; set; }
        public decimal ItRate { get; set; }
        public decimal ItMrp { get; set; }
        public decimal Disc { get; set; }
        public decimal DiscAmt { get; set; }
        public int NRGPCode { get; set; }
        public int NrgpSrNo { get; set; }
        public int ChallanCode { get; set; }
        public int ChallanSrNo { get; set; }
        public string Opfield1 { get; set; }
        public string Opfield2 { get; set; }
        public string Opfield3 { get; set; }
        public string Opfield4 { get; set; }
        public string Opfield5 { get; set; }
        public string Opfield6 { get; set; }
        public string Opfield7 { get; set; }
        public string Opfield8 { get; set; }
        public string Opfield9 { get; set; }
        public string Opfield10 { get; set; }
        public string OrderNo { get; set; }
        public DateTime Orderdate { get; set; }
        public string RawName { get; set; } //Add on
        public string RawCodeNew { get; set; }

    }
    public class PurchaseReturnMasFiltterModel
    {
        public int? PurchaseReturnCode { get; set; }
        public int? AccCode { get; set; }
        public int? SalePurcType { get; set; }
        public int? SeriesCode { get; set; }
        public string AccName { get; set; }

    }

    public class GetPurchaseReturnCodeModel
    {
        public int PurchaseReturnCode { get; set; }

    }
}
