using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Inventory
{
    public class QuoteMasModel
    {
        public int QuoteCode { get; set; }
        public int SeriesCode { get; set; }
        public string SeriesName { get; set; }
        public int QuoteDocNo { get; set; }
        public DateTime QuoteDate { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public int AccCode { get; set; }
        public string AccName { get; set; }
        public int Approval { get; set; }
        public string BuyerRefNo { get; set; }
        public string Remarks { get; set; }
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
        public decimal TaxableAmt { get; set; }
        public decimal Tax1 { get; set; }
        public decimal Tax1Amt { get; set; }
        public decimal Tax2 { get; set; }
        public decimal Tax2Amt { get; set; }
        public decimal QuoteAmt { get; set; }
        public int SalePurcType { get; set; }

    }
    public class QuoteDetModel
    {
      
        public int QuoteCode { get; set; }
        public int SrNO { get; set; }
        public decimal Qty { get; set; }
        public int RawCode { get; set; }
        public string RawDesc { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public string Opfield_1 { get; set; }
        public string Opfield_2 { get; set; }
        public string Opfield_3 { get; set; }
        public string Opfield_4 { get; set; }
        public string Opfield_5 { get; set; }
        public string Opfield_6 { get; set; }
        public string Opfield_7 { get; set; }
        public string Opfield_8 { get; set; }
        public string Opfield_9 { get; set; }
        public string Opfield_10 { get; set; }
        public decimal GST1Perc { get; set; }
        public decimal GST2Perc { get; set; }
        public decimal GST1Amt { get; set; }
        public decimal GST2Amt { get; set; }
        public decimal ItemAmt { get; set; }
        public string? RawCodeNew { get; set; }

    }
    public class QuoteMasFilterModel
    {
        public int? AccCode { get; set; }
        public int? SeriesCode { get; set; }
        public string AccName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
