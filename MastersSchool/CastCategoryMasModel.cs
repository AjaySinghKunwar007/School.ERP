using System.Security.Principal;

namespace Optimum.ERP.Models.Masters
{
    public class CastCategoryModel
    {
        public int CastCategoryCode { get; set; }
        public string CastCategoryName { get; set; }

    }
    public class CastCategoryFiltterModel
    {
        public int? CastCategoryCode { get; set; }
        public string CastCategoryName { get; set; }
    }
}
