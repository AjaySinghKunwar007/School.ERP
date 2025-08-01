
using System.Security.Principal;

namespace Optimum.ERP.Models.Masters
{
    public class AccMasModel
    {
        public int AccCode { get; set; }
        public string AccName { get; set; }
        public string AccTypeName { get; set; } // Add On
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
        public string StateName { get; set; }//Add On
        public string AccPrintName { get; set; }
        public string AccPrintCode { get; set; }
        public int gcode { get; set; }
        public int acctype { get; set; }
        public decimal accopbal { get; set; }
        public decimal baccopbal { get; set; }
        public decimal tdsrate { get; set; }
        public int creditdays { get; set; }
        public int adjbillwise { get; set; }
        public string accgtype { get; set; }
        public string PanNo { get; set; }
        public string Phone { get; set; }
        public int VendCode { get; set; }
        public int? StateCode { get; set; }
        public int smcode { get; set; }
        public string MobileNo { get; set; }
        public int AcLock { get; set; }
        public string email { get; set; }
        public string ItField1 { get; set; }
        public string ItField2 { get; set; }
        public string ItField3 { get; set; }
        public string ItField4 { get; set; }
        public string ItField5 { get; set; }
        public string ItField6 { get; set; }
        public string ItField7 { get; set; }
        public string ItField8 { get; set; }
        public string ItField9 { get; set; }
        public string ItField10 { get; set; }
        public int IsSync { get; set; }
        public string PIN { get; set; }
        public int AccDistance { get; set; }
        public string GSTIN { get; set; }
        public string AccGroupName { get; set; } //AddOn
        public int LocationCode { get; set; }
        public string LocationName { get; set; }
        public string ContactPerson { get; set; }
        public string PaymentTerms { get; set; }
        public int CreditLimit { get; set; }
        public int IsActive { get; set; }
        public string IsActiveT { get; set; }
        public int TransportMode { get; set; }
        public string TransportModeT { get; set; }
        public string TransID { get; set; }
    }



    public class AccMasFiltterModel
    {
        public int? AccCode { get; set; }
        public string AccName { get; set; }
        public int? CompanyCode { get; set; }
        public int? LocationCode { get; set; }
        public int? AccTypeCode { get; set; }
    }

    public class GetStateCode
    {
        public int StateCode { get; set; }
    }

}