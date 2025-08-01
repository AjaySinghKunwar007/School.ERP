using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---Ajay
namespace Optimum.ERP.Models.Masters
{
    public class ColourMasModel
    {
        public int ColourCode { get; set; }
        public string ColourName { get; set; }
        public int ColourType { get; set; }
        public int? QtyUsed { get; set; }
        public int? MeterUsed { get; set; }
        public string ColourTypeT { get; set; }
        
    }
    public class ColourMasFilterModel
    {
        public string ColourName { get; set; }
    }
}
