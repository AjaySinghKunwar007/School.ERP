namespace Optimum.ERP.Models.Masters
{
    public class DishTypeModel
    {
        public int DishTypeCode { get; set; }
        public string DishTypeName { get; set; }
        public string ShowSaleT { get; set; }
        public string ShowPurcT { get; set; }
        public string ShowPOST { get; set; }
        public int ShowSale { get; set; }
        public int ShowPurc { get; set; }
        public int ShowPOS { get; set; }
        public int LocationCode { get; set; }
    }
    public class DishTypeFilterModel
    {
        public int? DishTypeCode { get; set; }
        public string DishTypeName { get; set; }
        public int? CompanyCode { get; set; }
        public int? LocationCode { get; set; }
    }

}
