using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Masters
{
    public class DBMasModel
    {
        public int DBCode { get; set; }
        public String DBName { get; set; }
        public String Address1 { get; set; }
        public String Mobile { get; set; }

    }

    public class DBMasFillterModel
    {
        public int DBCode { get; set; }
        public String DBName { get; set; }

    }
}
