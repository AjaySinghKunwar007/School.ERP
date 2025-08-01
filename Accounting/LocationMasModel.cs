using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Accounting
{
    public class LocationMasModel
    {
        public int LocationCode { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }          // Renamed from Remarks
        public int? Pin { get; set; }                 // Optional
        public int? StateCode { get; set; }               // Foreign key to StateMas
        public int? CompanyCode { get; set; }               // Foreign key to StateMas
        public string CompanyName { get; set; }
        public string StateName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string GSTIN { get; set; }
        public string RetailFormatName { get; set; }
        public int DefaultSaleTypeForRetail { get; set; }
        public int AccCode_Retail { get; set; }
        public int AccCodeAdjust { get; set; }
        public int ddlSearch { get; set; }
        public int ddlType { get; set; }
        public int NoOfColInRow { get; set; }
        public int TransportFeeCode { get; set; }
        public int TutionFeeCode { get; set; }
        public int OpeningBalFeeCode { get; set; }
        public int OnScreenKeyboard { get; set; }
        public int AskBillPrint { get; set; }
        public int AskKOTPrint { get; set; }
        public string BillPrinterName { get; set; }
    }


    public class LocationMasFiltterModel
    {
        public int? LocationCode { get; set; }
        public string LocationName { get; set; }
    }
    public class AccountConfigModel
    {
        public int? LocationCode { get; set; }
        // store report

        public int EffectStorePurc { get; set; }
        public int EffectStorePurcPassing { get; set; }
        public int EffectStoreSale { get; set; }
        public int EffectStoreMrn { get; set; }
        public int EffectStoreMrnJw { get; set; }
        public int EffectStoreChallan { get; set; }
        public int EffectStoreNRGP { get; set; }
        public int EffectStoreRGP { get; set; }
        public int EffectStoreRRGP { get; set; }
        public int EffectStoreJobWork { get; set; }
        public int EffectStoreRetail { get; set; }
        //purchase type
        public int PurcAcccode1 { get; set; }
        public int PurcAcccode2 { get; set; }
        public int PurcAcccode3 { get; set; }
        public int PurcAcccode4 { get; set; }
        public int PurcAcccode5 { get; set; }
        // sale type
        public int SaleAcccode1 { get; set; }
        public int SaleAcccode2 { get; set; }
        public int SaleAcccode3 { get; set; }
        public int SaleAcccode4 { get; set; }
        public int SaleAcccode5 { get; set; }
        public int SaleAcccode6 { get; set; }
        public string SaleCother1 { get; set; }
        public string SaleCother2 { get; set; }
        public string SaleCother3 { get; set; }
        public string SaleCother4 { get; set; }
        public decimal Saleperc1 { get; set; }
        public decimal Saleperc2 { get; set; }
        public decimal Saleperc3 { get; set; }
        public decimal Saleperc4 { get; set; }
        public int SaleAddLess1 { get; set; }
        public int SaleAddLess2 { get; set; }
        public int SaleAddLess3 { get; set; }
        public int SaleAddLess4 { get; set; }
        public int CalcType1 { get; set; }
        public int CalcType2 { get; set; }
        public int CalcType3 { get; set; }
        public int CalcType4 { get; set; }
        // POS
        public string POSCother1 { get; set; }
        public string POSCother2 { get; set; }
        public string POSCother3 { get; set; }
        public string POSCother4 { get; set; }
        public string POSCother5 { get; set; }
        public decimal POSperc1 { get; set; }
        public decimal POSperc2 { get; set; }
        public decimal POSperc3 { get; set; }
        public decimal POSperc4 { get; set; }
        public decimal POSperc5 { get; set; }
        public int POSAddLess1 { get; set; }
        public int POSAddLess2 { get; set; }
        public int POSAddLess3 { get; set; }
        public int POSAddLess4 { get; set; }
        public int POSAddLess5 { get; set; }
    }
}
