using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Masters
{
    public class AccGroupModel
    {
        public int AccGroupCode { get; set; }
        public string AccGroupName { get; set; }
        public int UpperGroupCode { get; set; }
        public int? RefNo { get; set; }  // Add On 
        public string GroupType { get; set; } // Add On 
        public string BTypeT { get; set; } // Add On 
        public string TypeT { get; set; } // Add On 
        public string PrintSummary { get; set; } //Add On
        public string btype { get; set; }
        public int type { get; set; }
        public int refno { get; set; }
        public string grptype { get; set; }
        public decimal PrintTotalOnly { get; set; }
        public int IsDeleted { get; set; }
        public int IsSyncy { get; set; }
        public int LocationCode { get; set; }
        public string LocationName { get; set; }

    }

    public class AccGroupFiltterModel
    {
        public int? AccGroupCode { get; set; }
        public string AccGroupName { get; set; }
        public int? LocationCode { get; set; }
        public int? CompanyCode { get; set; }
    }

}

