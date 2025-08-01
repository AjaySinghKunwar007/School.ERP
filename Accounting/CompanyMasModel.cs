using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Accounting
{
    public class CompanyMasModel
    {
        public int IsItemMerge { get; set; }
        public string IsItemMergeT { get; set; }
        public string CompanyName { get; set; }
        public int CompanyCode { get; set; }
    }
    public class CompanyMasFilterModel
    {
        public string CompanyName { get; set; }
        public int CompanyCode { get; set; }
    }
}
