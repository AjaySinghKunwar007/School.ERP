using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Config
{
    public class EInvConfigModel
    {
        public string eInvURL { get; set; }
        public string eWayURL { get; set; }
        public string eInvGSTIN { get; set; }
        public string eInvCustomerName { get; set; }
        public string eInvBranch { get; set; }
        public string eInvUserName { get; set; }
        public string eInvPassword { get; set; }
        public string eInvCustomerId { get; set; }
        public string eInvAPIId { get; set; }
        public string eInvAPISecret { get; set; }
        public string eInvSource { get; set; }
        public string eInvEnvironment_type { get; set; }
        public string eWayCancelURL { get; set; }
        public int LocationCode { get; set; }
    }
}
