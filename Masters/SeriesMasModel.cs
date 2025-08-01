using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Masters
{
    public class SeriesMasModel
    {
        public int SeriesCode { get; set; }
        public int SeriesTypeCode { get; set; }
        public string SeriesTypeName { get; set; } // AddOn
        public string SeriesName { get; set; }
        public string SeriesPrintName { get; set; }
        public string SeriesSuffix { get; set; }
        public string SeriesPrefix { get; set; }
        public int DefaultName { get; set; }
        public string EInvName { get; set; }
        public string DefaultNameT { get; set; } //Add On
        public string PrintFormat { get; set; }

    }


    public class SeriesMasFiltterModel
    {
        public int? SeriesCode { get; set; }
        public int SeriesTypeCode { get; set; }
        public string SeriesName { get; set; }
    }

}





