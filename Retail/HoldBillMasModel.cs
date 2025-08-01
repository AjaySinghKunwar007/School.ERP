using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Retail
{
    public class HoldBillMasModel
    {
        public int BillCode { get; set; }
        public string BillDate { get; set; }
        public string BillTime { get; set; }
        public int SrNo { get; set; }
        public int RawCode { get; set; }
        public string RawName { get; set; }
        public decimal Qty { get; set; }
        public decimal Rate { get; set; }
        public decimal AMOUNT { get; set; }
        public string Comment { get; set; }
        public string MobileNo { get; set; }
        public string CustomreName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int AccCode { get; set; }
        public string AccName { get; set; }
    }
}
