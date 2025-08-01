using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Masters
{
    public class DiscountMasModel
    {
        public int DiscountCode { get; set; }
        public String DiscountName { get; set; }
        public String DishTypeName { get; set; }
        public int DishTypeCode { get; set; }
        public decimal Rate { get; set; }
        public int LocationCode { get; set; }


    }


    public class DiscountMasFiltterModel
    {
        public int DiscountCode { get; set; }
        public String DiscountName { get; set; }
        public int? LocationCode { get; set; }
        public int? CompanyCode { get; set; }

    }
}
