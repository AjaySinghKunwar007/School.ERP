using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Masters
{
    public class StateMasModel
    {
        public int StateCode { get; set; }
        public string StateName { get; set; }
        public string StateCodeNew { get; set; }
    }
    public class StateMasFiltterModel
    {
        public int? StateCode { get; set; }
        public string StateName { get; set; }
    }
}
