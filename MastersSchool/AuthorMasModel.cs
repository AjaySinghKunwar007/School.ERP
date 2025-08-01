using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.MastersSchool
{
    public class AuthorMasModel
    {
       public int AuthorCode { get; set; }
        public string AuthorName { get; set; }
    }

    public class AuthorMasFillterModel
    {
        public int? AuthorCode { get; set; }
        public string AuthorName { get; set; }

    }
}
