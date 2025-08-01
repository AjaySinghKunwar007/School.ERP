using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Accounting
{
    public class AccountPostingModel
    {
        public int VouchCode { get; set; }
        public DateTime VouchDate { get; set; }
        public int VoucherCode { get; set; }
        public int YearCode { get; set; }
        public int VNo { get; set; }
        public string VouchNarr { get; set; }
        public int AccCode { get; set; }
        public decimal BillAmt { get; set; }
        public int TypeAccCode { get; set; }
        public decimal TotalAmt { get; set; }
        public int AccCodeOther1 { get; set; }
        public decimal OtherAmt1 { get; set; }
        public int AccCodeOther2 { get; set; }
        public decimal OtherAmt2 { get; set; }
        public int AccCodeOther3 { get; set; }
        public decimal OtherAmt3 { get; set; }
        public int AccCodeOther4 { get; set; }
        public decimal OtherAmt4 { get; set; }
        public int AccCodeOther5 { get; set; }
        public decimal OtherAmt5 { get; set; }
        public int GSTAccCode1 { get; set; }
        public decimal GSTAmt1 { get; set; }
        public int GSTAccCode2 { get; set; }
        public decimal GSTAmt2 { get; set; }
        public decimal TotalVouchAmt { get; set; }
        public int IsPaymentDelete { get; set; }
    }

}
