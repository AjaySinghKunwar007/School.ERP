using System.Security.Principal;

namespace Optimum.ERP.Models.Masters
{
    public class CategoryModel
    {
        public int CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public int FeeCode { get; set; }
        public int Disc { get; set; }
        public int DiscountType { get; set; }
        public int FeeBillCreate { get; set; }
        public int PendingFeeSMS { get; set; }
        public int DiscountAmt { get; set; }
        public string DiscountTypeT { get; set; }
        public string FeeBillCreateT { get; set; }
        public string PendingFeeSMST { get; set; }

    }
    public class CategoryFiltterModel
    {
        public int? CategoryCode { get; set; }
        public string CategoryName { get; set; }
    }
}
