using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Inventory
{
    public class RGPMasModel
    {
        public int RGPCode { get; set; }
        public DateTime RGPDate { get; set; }
        public int AccCode { get; set; }
        public string AccName { get; set; }
        public int DocNo { get; set; }
        public int SeriesCode { get; set; }
        public string Remarks { get; set; }
        public int Type { get; set; }
        public int SaleType { get; set; }
        public string Transport { get; set; }
        public string Carrier { get; set; }
        public string Package { get; set; }
        public string Freight { get; set; }
        public decimal TotalQty { get; set; }
        public int YearCode { get; set; }
        public string TimeOFIssue { get; set; }
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
        public int Process { get; set; }
        public int IsOpening { get; set; }
        public DateTime? ChDate { get; set; }
        public int? ChNo { get; set; }
        public int DeptCode { get; set; }
        public decimal TotalAmt { get; set; }
        public decimal TaxPerc1 { get; set; }
        public decimal TaxPerc2 { get; set; }
        public decimal GSTAMT1 { get; set; }
        public decimal GSTAMT2 { get; set; }
        public decimal OtherAmt { get; set; }
        public decimal TaxableAmt { get; set; }
        public int AccCodeShipTo { get; set; }
        public int Distance { get; set; }
        public int TransMode { get; set; }
        public string TransDocNo { get; set; }
        public string TransId { get; set; }
        public string TransName { get; set; }
        public string TransDocDate { get; set; }
        public int VehicleType { get; set; }
        public string VehicleNo { get; set; }
        public int AccCodeDispatchFrom { get; set; }
        public int TransType { get; set; }
        public string Disp_fromAddr1 { get; set; }
        public string Disp_fromAddr2 { get; set; }
        public string Disp_fromPlace { get; set; }
        public string Disp_fromPincode { get; set; }
        public string Disp_actFromStateCode { get; set; }
        public string EwayBillNo { get; set; }
        public string EwayBillDate { get; set; }
        public string EwbValidTill { get; set; }
        public string Cancel { get; set; }
    }
    public class RGPDetModel
    {
        public bool IsChecked { get; set; }
        public int RGPCode { get; set; }
        public int Srno { get; set; }
        public int RawCode { get; set; }
        public string RawName { get; set; }
        public string Desc { get; set; }
        public decimal Qty { get; set; }
        public decimal TempQty { get; set; }
        public int YearCode { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public int Type { get; set; }
        public int ProcessCode { get; set; }
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
        public DateTime RGPDate { get; set; }
        public string HSNName { get; set; }
        public int HSNCode { get; set; }
        public decimal GST1 { get; set; }
        public decimal GST2 { get; set; }
        public decimal GST1Amt { get; set; }
        public decimal GST2Amt { get; set; }
        public decimal TaxableAmount { get; set; }
        public decimal TotalAmount { get; set; }

    }


    public class RGPMasFilterModel
    {
        public int RGPCode { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int? AccCode { get; set; }
        public int DocNo { get; set; }
        public int? SeriesCode { get; set; }
    }





}