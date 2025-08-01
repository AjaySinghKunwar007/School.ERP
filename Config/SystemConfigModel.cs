using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Optimum.ERP.Models.Config
{
    public class SystemConfigModel
    {
        public string CShortName { get; set; }
        public string CName { get; set; }
        public string Cadd1 { get; set; }
        public string Cadd2 { get; set; }
        public string Cadd3 { get; set; }
        public string CStateCode { get; set; }
        public string CStateName { get; set; }
        public string Cphone { get; set; }
        public string CEmail { get; set; }
        public int FYearFrom { get; set; }
        public int FYearTo { get; set; }
        public string Ccode { get; set; }
        public DateTime CstrtDate { get; set; }
        public DateTime CEndDate { get; set; }
        public int DbVersion { get; set; }
        public string windll { get; set; }
        public string CGSTIN { get; set; }
        public int SoftwareCode { get; set; }
        public int OnScreenKeyboard { get; set; }
        public int EstiMateDefaultAcc { get; set; }
        public int IsMultiLocation { get; set; }
        public int TransportFeeCode { get; set; }
        public int TutionFeeCode { get; set; }
        public int OpeningBalFeeCode { get; set; }
        public int PINCODE { get; set; }
        public int ddlType { get; set; }
        public int ddlSearch { get; set; }
        public int NoOfColInRow { get; set; }
        public string recovery { get; set; }
        public int DefaultSaleTypeForRetail { get; set; } 
        public int AccCode_Retail { get; set; }
        public int AccCodeAdjust { get; set; }

    }

    public class SystemConfigPurcModel
    {
        public int PurcAcccode1 { get; set; }
        public int PurcAcccode2 { get; set; }
        public int PurcAcccode3 { get; set; }
        public int PurcAcccode4 { get; set; }
        public int PurcAcccode5 { get; set; }
        //public string PurcCother1 { get; set; }
        //public string PurcCother2 { get; set; }
        //public string PurcCother3 { get; set; }
        //public string PurcCother4 { get; set; }
        //public string PurcCother5 { get; set; }

    }
    public class SystemConfigSaleModel
    {
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
        //public string SaleCother5 { get; set; }
        //public string SaleCother6 { get; set; }
        public decimal Saleperc1 { get; set; }
        public decimal Saleperc2 { get; set; }
        public decimal Saleperc3 { get; set; }
        public decimal Saleperc4 { get; set; }
        //public decimal Saleperc5 { get; set; }
        //public decimal Saleperc6 { get; set; }
        public int SaleAddLess1 { get; set; }
        public int SaleAddLess2 { get; set; }
        public int SaleAddLess3 { get; set; }
        public int SaleAddLess4 { get; set; }
        //public int SaleAddLess5 { get; set; }
        //public int SaleAddLess6 { get; set; }


        //public int Salecalctype1 { get; set; }
        //public int Salecalctype2 { get; set; }
        //public int Salecalctype3 { get; set; }
        //public int Salecalctype4 { get; set; }
        //public int Salecalctype5 { get; set; }
        //public int Salecalctype6 { get; set; }

    }
    public class SystemConfig_Store
    { 
        public int EffactStorePurc { get; set; }
        public int EffactStoreSale { get; set; }
        public int EffactStoreMrn { get; set; }
        public int EffactStoreMrnJw { get; set; }
        public int EffactStoreChallan { get; set; }
        public int EffactStoreNRGP { get; set; }
        public int EffactStoreRGP { get; set; }
        public int EffactStoreRRGP { get; set; }
    }

    public class SystemConfigPosModel
    {
        public string POSCother1 { get; set; }
        public string POSCother2 { get; set; }
        public string POSCother3 { get; set; }
        public string POSCother4 { get; set; }
        public string POSCother5 { get; set; }
        public decimal POSperc1 { get; set; }
        public decimal POSperc2 { get; set; }
        public decimal POSperc3 { get; set; }
        public decimal POSperc4{ get; set; }
        public decimal POSperc5 { get; set; }
        public int POSAddLess1 { get; set; }
        public int POSAddLess2 { get; set; }
        public int POSAddLess3 { get; set; }
        public int POSAddLess4 { get; set; }
        public int POSAddLess5 { get; set; }
    }
    public class SystemConfigs
    { 
        public decimal ServiceCharge { get; set; }
        public string PrintFormatTable { get; set; }
        public string PrintFormatDelivery { get; set; }
        public string PrintFormatTakeaway { get; set; }
        public string KOTFormatTable { get; set; }
        public string KOTFormatDelivery { get; set; }
        public string KOTFormatTakeaway { get; set; }
        public string PrintFormatSO { get; set; }
        public int SaleDefaultPrint { get; set; }
        public int ServiceChargeTakeaway { get; set; }
        public int ServiceChargeDelivery { get; set; }
        public int ServiceChargeDineIn { get; set; }
        public int ResetBillNo { get; set; }
        public int MobileRequired { get; set; }
        public int DiscountType { get; set; }
        public int AutoDayClose { get; set; }
        public int ShowArea { get; set; }
        public string DuplicateBillPrinter { get; set; }
        public string OwnerMobile { get; set; }
        public int OnlyTakeaway { get; set; }
        public int ItemGroupVariance { get; set; }
        public int ShowTableBill { get; set; }
        public int ShowFormTakeaway { get; set; }
        public int ShowFormDelivery { get; set; }
        public int ShowFormRestaurant { get; set; }
        public int AskBillPrint { get; set; }
        public int OpenTouchKey { get; set; }
        public int BackDateSale { get; set; }
        public int MultiBackPath { get; set; }
        public int GeoLongitude { get; set; }
        public int GeoLatitude { get; set; }
        public int WeightMachine { get; set; }
        public int ActiveOptimumApp { get; set; }
        public int AskKOTPrint { get; set; }
        public string GrowAasanID { get; set; }
        public string ZomatoStoreID { get; set; }
        public string ZomatoOurURL { get; set; }
        public string ZomatoMenuURLty { get; set; }
        public string ZomatoSecurityCode { get; set; }
        public string ZomatoPicturePath { get; set; }
        public string ZomatoSingleMenuUrl { get; set; }
        public string GrowAasanSecurityCode { get; set; }
        public int CustomiseFor { get; set; }
        public string EInvoiceFolder { get; set; }
        public int UseEInvoice { get; set; }
        public int UseEwayBill { get; set; }
        public int AccountPostingPOS { get; set; }
        public int PaymentPostingPOS { get; set; }
        public int MultiPayOff { get; set; }
        public int AccCodeWareHouse { get; set; }
        public string SyncDataFolder { get; set; }
        public int CreditSaleAcc { get; set; }
        public int SaleForm { get; set; }
        public int PurchaseForm { get; set; }
        public int CafePOSApp { get; set; }
        public int ZomatoIntegration { get; set; }
        public string OneApikey { get; set; }
        public string PictureFolder{ get; set; }
    }

}



    