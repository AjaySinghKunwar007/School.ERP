using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Inventory
{
    public class JobWorkMasModel
    {
        public int JobWorkCode { get; set; }
        public DateTime JobWorkDate { get; set; }
        public int JobWorkDocNo { get; set; }
        public int AccCode { get; set; }
        public string AccName { get; set; }
        public string Remarks { get; set; }
        public int? saleblno { get; set; }
        public int? blno { get; set; }
        public decimal? OtherAmt1 { get; set; }
        public decimal? OtherAmt2 { get; set; }
        public decimal? OtherAmt3 { get; set; }
        public decimal? OtherAmt4 { get; set; }
        public decimal? OtherAmt5 { get; set; }
        public string OtherCap1 { get; set; }
        public string OtherCap2 { get; set; }
        public string OtherCap3 { get; set; }
        public string OtherCap4 { get; set; }
        public string OtherCap5 { get; set; }
        public decimal JobWorkAmt { get; set; }
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
        public int SeriesCode { get; set; }
        public string SeriesName { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string IsCancel { get; set; }
        public decimal? CashReceived1 { get; set; }
        public decimal? CashReceived2 { get; set; }
        public decimal? CashReceived3 { get; set; }
        public decimal? CashReceived4 { get; set; }
        public decimal? CashReceived5 { get; set; }
        public DateTime? ReceiveDate1 { get; set; }
        public DateTime? ReceiveDate2 { get; set; }
        public DateTime? ReceiveDate3 { get; set; }
        public DateTime? ReceiveDate4 { get; set; }
        public DateTime? ReceiveDate5 { get; set; }
        public int? IsDelivery { get; set; }
        public int? UserCodeReceive1 { get; set; }
        public int? UserCodeReceive2 { get; set; }
        public string ContactPerson { get; set; }
        public int? Pay1 { get; set; }
        public int? Pay2 { get; set; }
        public int? Pay3 { get; set; }
        public int? Pay4 { get; set; }
        public int? Pay5 { get; set; }
        public int? PICode { get; set; }
        public DateTime? PIDate { get; set; }
        public string PONo { get; set; }

    }
    public class GetJobWorkCodeModel
    {
        public int NewJobWorkCode { get; set; }

    }
    public class JobWorkDetModel
    {
        public int JobWorkCode { get; set; }
        public int Srno { get; set; }
        public int RawCode { get; set; }
        public string RawDesc { get; set; }
        public decimal Qty { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public int ToBill { get; set; }
        public int MachineCode { get; set; }
        public int ColourCode { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
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
        public int PICode { get; set; }

    }
    public class JobWorkMasFilterModel
    {
        public int? AccCode { get; set; }
        public string AccName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
    
}
