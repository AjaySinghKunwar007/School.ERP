using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.MastersSchool
{
    public class BookClassificationMasModel
    {
        public int BookClassificationCode { get; set; }
        public string BookClassificationName { get; set; }
        public string Remarks { get; set; }
    }

    public class BookClassificationMasFilterModel
    {
        public int BookClassificationCode { get; set; }
        public string BookClassificationName { get; set; }
    }
}
