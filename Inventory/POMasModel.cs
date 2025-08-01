using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Optimum.ERP.Models.Inventory
{
    public class POMasModel
    {
        public int POCode { get; set; }
        public int PODocNo { get; set; }
        public int SeriesCode { get; set; }
        public DateTime PODate { get; set; }
        public int YearCode { get; set; }
   
        public string RefNo { get; set; }
        public DateTime RefDate { get; set; }
        public int IndentCode { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public int AccCode { get; set; }
        public string AccName { get; set; } //AddOn
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
        public string Narr11 { get; set; }
        public string Narr12 { get; set; }
        public string Narr13 { get; set; }
        public string Narr14 { get; set; }
        public string Narr15 { get; set; }
        public string Narr16 { get; set; }
        public string Narr17 { get; set; }
        public string Narr18 { get; set; }
        public string Narr19 { get; set; }
        public string Narr20 { get; set; }
        public decimal TaxableAmt { get; set; }
        public decimal Tax1 { get; set; }
        public decimal Tax1Amt { get; set; }
        public decimal Tax2 { get; set; }
        public decimal Tax2Amt { get; set; }
        public decimal POAmt { get; set; }
        public int SalePurcType { get; set; }
        public int LocationCode { get; set; }
    }
    public class POMasFilterModel
    {
        public int? SeriesCode { get; set; }
        public int? AccCode { get; set; }
        public string AccName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
 
    }

    public class PODetModel
    {
        public int? POCode { get; set; }
        public int? YearCode { get; set; }
        public int RawCode { get; set; }
        public int Srno { get; set; }
        public decimal Qty { get; set; }
        public decimal Rate { get; set; }
        public decimal? DiscPerc { get; set; }
        public decimal ?DiscAmt { get; set; }
        public decimal Amount { get; set; }
        public string OpField1 { get; set; }
        public string OpField2 { get; set; }
        public string OpField3 { get; set; }
        public string OpField4 { get; set; }
        public string OpField5 { get; set; }
        public string OpField6 { get; set; }
        public string OpField7 { get; set; }
        public string OpField8 { get; set; }
        public string OpField9 { get; set; }
        public string OpField10 { get; set; }
        public decimal GST1Perc { get; set; }
        public decimal GST2Perc { get; set; }
        public decimal GST1Amt { get; set; }
        public decimal GST2Amt { get; set; }
        public decimal ItemAmt { get; set; }
        public string RawDesc { get; set; }
        public string? RawCodeNew { get; set; }
    }
  

}
