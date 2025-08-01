using Optimum.ERP.Models.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Masters
{
    public class VoucherModel
    {
        public int VoucherCode { get; set; }
        public string VName { get; set; }
        public string VShortName { get; set; }
        public int SeriesPrint { get; set; }
        public int AskPrint { get; set; }
       
    }
}





