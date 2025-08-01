using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Retail
{
    public class BillMasModel
    {
        public int BillCode { get; set; }
        public int DocNo { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime BillTime { get; set; }
        public int YearCode { get; set; }
        public int WaiterCode { get; set; }
        public int TableCode { get; set; }
        public int BillType { get; set; }
        public int BillStatus { get; set; }
        public int DeliveryBoyCode { get; set; }
        public decimal Total { get; set; }
        public int OtherAcc1 { get; set; }
        public int OtherAcc2 { get; set; }
        public int OtherAcc3 { get; set; }
        public int OtherAcc4 { get; set; }
        public int OtherAcc5 { get; set; }
        public int OtherAcc6 { get; set; }
        public decimal OtherPerc1 { get; set; }
        public decimal OtherPerc2 { get; set; }
        public decimal OtherPerc3 { get; set; }
        public decimal OtherPerc4 { get; set; }
        public decimal OtherPerc5 { get; set; }
        public decimal OtherPerc6 { get; set; }
        public decimal OtherAmt1 { get; set; }
        public decimal OtherAmt2 { get; set; }
        public decimal OtherAmt3 { get; set; }
        public decimal OtherAmt4 { get; set; }
        public decimal OtherAmt5 { get; set; }
        public decimal OtherAmt6 { get; set; }
        public string OtherLbl1 { get; set; }
        public string OtherLbl2 { get; set; }
        public string OtherLbl3 { get; set; }
        public string OtherLbl4 { get; set; }
        public string OtherLbl5 { get; set; }
        public string OtherLbl6 { get; set; }
        public string CustomerName { get; set; }
        public string CustMobile { get; set; }
        public string CustAddress1 { get; set; }
        public string HDCustAddress2 { get; set; }
        public string HDCustMobile2 { get; set; }
        public decimal BillAmt { get; set; }
        public int KOTCode { get; set; }
        public int DeliveryStatus { get; set; }
        public int UserCode { get; set; }
        public int DiscountCode { get; set; }
        public string KOTNoStr { get; set; }
        public string Remarks { get; set; }
        public int DailyDocNo { get; set; }
        public int SeriesCode { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int IsSync { get; set; }
        public int AppBillNo { get; set; }
        public int AccCode { get; set; }
        public int LocationCode { get; set; }
        public int? PayMode { get; set; }
        public decimal? payment1 { get; set; }
        public int? PayMode2 { get; set; }
        public decimal? payment2 { get; set; }
        public int VoucherCode { get; set; }
        public int TypeCode { get; set; }
    }
    public class BillDetModel
    {
        public int BillCode { get; set; }
        public int SrNo { get; set; }
        public int RawCode { get; set; }
        public string RawDesc { get; set; }
        public decimal Rate { get; set; }
        public decimal Qty { get; set; }
        public int Discountable { get; set; }
        public int ServiceChargable { get; set; }
        public decimal DiscPerc { get; set; }
        public decimal DiscAmount { get; set; }
        public int IsTaxExtra { get; set; }
        public decimal Amount { get; set; }
        public string Comment { get; set; }
        public int IsDeleted { get; set; }
        public int HSNCode { get; set; }
        public decimal MRP { get; set; }
        public decimal GSTPerc { get; set; }
    }

    public class GetNewBillCodeModel
    {
        public int BillCode { get; set; }
    }

    public class BillMasFillterModel
    {
        public int? BillCode { get; set; }
        public int? DocNo { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int? LocationCode  { get; set; }
        public int? CompanyCode { get; set; }
    }
}
