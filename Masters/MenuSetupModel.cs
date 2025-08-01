using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Masters
{
    public class MenuSetupModel
    {
        public int SoftwareCode { get; set; }
        public string MenuName { get; set; }
        public string MenuID { get; set; }
        public int ParentId { get; set; }
        public int ID { get; set; }
    }
}
