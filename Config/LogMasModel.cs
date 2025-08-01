using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Optimum.ERP.Models.Config
{
    public class LogMasModel
    {
        public int LogCode { get; set; }
        public DateTime LogDate { get; set; }
        public string OldDesc { get; set; }
        public string NewDesc { get; set; }
        public int UserCode { get; set; }
        public string ComputerName { get; set; }
        public string FormName { get; set; }
        public string USERNAME { get; set; }
        public string OperationName { get; set; }
        public int Operation { get; set; }
       
    }


    public class LogMasFiltterModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string FormName { get; set; }
        public int? Operation { get; set; }

    }
}
