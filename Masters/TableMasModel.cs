using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Masters
{
    public class TableMasModel
    {
        public int TableCode { get; set; }
        public string TableName { get; set; }
        public string FloorName { get; set; }
        public int FloorCode { get; set; }
        public int MaxCover { get; set; }
        public int Status { get; set; }
        public int TSrNo { get; set; }
        public int IsActive { get; set; }
    }

    public class TableMasFiltterModel
    {
        public int? TableCode { get; set; }
        public String TableName { get; set; }
    }
}
