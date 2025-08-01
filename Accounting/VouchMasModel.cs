using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Accounting
{
    public class VouchMasModel
    {
        public int VouchCode { get; set; }
        public DateTime VouchDate { get; set; }
        public int VoucherCode { get; set; }
        public string VName { get; set; } //Add On
        public string AccName { get; set; } //AddOn
        public int yearcode { get; set; }
        public int VNo { get; set; }
        public int? VoucherCode_PaymentFrom { get; set; }
        public int AccCode { get; set; }
        public string Narration { get; set; }
        public decimal TotalVouchAmt { get; set; }
        public string TransType { get; set; }
    }

    public class VouchMasFillterModel
    {
        public int? VouchCode { get; set; }
        public int? AccCode { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }

    public class GetNewVouchCodeModel
    {
        public int VouchCode { get; set; }
    }

    public class VouchDetModel
    {

        public int VouchCode { get; set; }
        public int VoucherCode { get; set; }
        public int yearcode { get; set; }
        public int VNo { get; set; }
        public int SrNo { get; set; }
        public DateTime VouchDate { get; set; }
        public int AccCode { get; set; }
        public string AccName { get; set; } //Add On
        public string VouchNarr { get; set; }
        public decimal VouchAmt { get; set; }
        public DateTime ClDate { get; set; }
        public int chno { get; set; }
        public DateTime chqDate { get; set; }
        public string TransType { get; set; }
    }

    public class AccBalanceModel
    {
        public int AccCode { get; set; }
        public DateTime VDate { get; set; }
        public decimal Amount { get; set; }

    }

}



