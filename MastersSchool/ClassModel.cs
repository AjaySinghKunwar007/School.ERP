using System.Security.Principal;

namespace Optimum.ERP.Models.Masters
{
    public class ClassModel
    {
        public int ClassCode { get; set; }
        public string ClassName { get; set; }
        public int SrNo { get; set; }
        public int NextClassCode { get; set; }
        public int FeeTerm { get; set; }

    }
    public class ClassFiltterModel
    {
        public int? ClassCode { get; set; }
        public string ClassName { get; set; }
    }
}
