using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Masters
{
    public class CustomerMasModel
    {
        public int CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public int AccCode{ get; set; }
        public int LocationCode{ get; set; }
        public string AccName { get; set; }
    }

    public class CustomerMasFiltterModel
    {
        public int CustomerCode { get; set; }
        public int? CompanyCode { get; set; }
        public int? LocationCode { get; set; }
        public string CustomerName { get; set; }
        public string MobileNo { get; set; }
      
    }
}
