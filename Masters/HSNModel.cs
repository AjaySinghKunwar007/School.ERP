using System.Security.Principal;

namespace Optimum.ERP.Models.Masters
{
    public class HSNModel
    {
        public int HSNCode { get; set; }
        public string HSNName { get; set; }
        public decimal GST { get; set; }
        public string HSNDesc { get; set; }
        public string UQC { get; set; } = "null";
        public int IsSync { get; set; }
        public int IsDeleted { get; set; }
        public int LocationCode { get; set; }
        public string LocationName { get; set; }
    }
    public class HSNFiltterModel
    {
        public int? HSNCode { get; set; }
        public string HSNName { get; set; }
        public int? LocationCode { get; set; }
        public int? companyCode { get; set; }
    }
}
