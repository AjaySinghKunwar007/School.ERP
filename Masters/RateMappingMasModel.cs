using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Masters
{
    public class RateMappingMasModel
    {
        public  int PartyWiseRateCode { get; set; }
        public int RawCode { get; set; }
        public string RawName { get; set; }
        public int AccCode { get; set; }
        public string AccName { get; set; }
        public string ColourName { get; set; }
        public int DishHeadCode { get; set; }
        public string DishHeadName { get; set; }
        public string UnitName { get; set; }
        public int UnitCode { get; set; }
        public decimal? Rate { get; set; }
        public decimal? AddLess { get; set; }
        public int ColourCode { get; set; }
        public decimal? Rate1 { get; set; }
        public decimal? Rate2 { get; set; }
        public decimal? Rate3 { get; set; }
        public decimal? Rate4 { get; set; }
        public decimal? Rate5 { get; set; }
        public decimal? Rate6 { get; set; }
        public int? From2 { get; set; }
        public int? From3 { get; set; }
        public int? From4 { get; set; }
        public int? From5 { get; set; }
        public int? From6 { get; set; }
        public int? To1 { get; set; }
        public int? To2 { get; set; }
        public int? To3 { get; set; }
        public int? To4 { get; set; }
        public int? To5 { get; set; }



    }
    public class RateMappingMasFilterModel
    {
        public string SearchName { get; set; }
        public int? OrderBy { get; set; }
        public int? AccCode { get; set; }
        public int? RawCode { get; set; }
        public int? ColourCode { get; set; }
        public int? DishHeadCode { get; set; }

    }
}
