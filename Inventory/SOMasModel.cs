using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Inventory
{
    public class SOMasModel
    {

        public int SeriesCode { get; set; }
        public string SeriesName { get; set; }
        public int SaleOrderCode { get; set; }
        public int SaleOrderDocNo { get; set; }
        public DateTime SaleOrderDate { get; set; }
        public int AccCode { get; set; }
        public string AccName { get; set; }
        public int IsFixQty { get; set; }
        public string IsFixQtyT { get; set; }
        public int IsActive { get; set; }
        public string IsActiveT { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Remarks { get; set; }

        public decimal TaxableAmt { get; set; }

        public decimal SaleOrderAmt { get; set; }
        public decimal OtherAmt1 { get; set; }
        public decimal OtherAmt2 { get; set; }
        public decimal OtherAmt3 { get; set; }
        public decimal OtherAmt4 { get; set; }
        public decimal OtherAmt5 { get; set; }
        public decimal OtherPerc1 { get; set; }
        public decimal OtherPerc2 { get; set; }
        public decimal OtherPerc3 { get; set; }
        public decimal OtherPerc4 { get; set; }
        public decimal OtherPerc5 { get; set; }
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
    }
    public class SODetModel
    {
        public int SaleOrderCode { get; set; }
        public int AccCode { get; set; }
        public int SrNO { get; set; }
        public int RawCode { get; set; }
        public string RawDesc { get; set; }
        public decimal Qty { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public decimal? Tolerance { get; set; }
        public int IsHold { get; set; }
        public string IsHoldT { get; set; }
        public DateTime? DeliveryDateDetail { get; set; }
        
        
        

    }
    public class SOMasFiltterModel
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? AccCode { get; set; }
        public string RawCodeNew { get; set; }
        public int? IsActive { get; set; }
        public int? IsFixQty { get; set; }
        public string AccName { get; set; }

    }

    public class GetSOCodeModel
    {
        public int SaleOrderCode { get; set; }

    }

}
