
namespace Optimum.ERP.Models.Masters
{
    public class DishHeadModel
    {
        public int DishHeadCode { get; set; }
        public int DishHeadSrNo { get; set; }
        public string DishHeadName { get; set; }
        public string DishHeadDesc { get; set; }
        public string DishTypeName { get; set; }
        public decimal Tax { get; set; }
        public int TaxAsVat { get; set; }
        public string AskQtyT { get; set; }
        public string ShowInPOST { get; set; }
        public string ShowInPurcT { get; set; }
        public int AskQty { get; set; }
        public int ShowInPOS { get; set; }
        public int ShowInPurchase { get; set; }
        public int ShowInApp { get; set; }
        public int DishTypeCode { get; set; }
        public int IsDeleted { get; set; }
        public int LocationCode { get; set; }

    }

    public class DishHeadFiltterModels
    {
        public int? DishHeadCode { get; set; }
        public string DishHeadName { get; set; }
        public int? DishTypeCode { get; set; }
        public int? CompanyCode { get; set; }
        public int? LocationCode { get; set; }
    }

}
