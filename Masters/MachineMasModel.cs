using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Masters
{
    public class MachineMasModel
    {
        public int MachineCode { get; set; }
        public string MachineName { get; set; }
        public int? OpColour { get; set; }
        public int? OpBlack { get; set; }
       
    }
    public class MachineMasFilterModel
    {
        public string MachineName { get; set; }
    }
}
