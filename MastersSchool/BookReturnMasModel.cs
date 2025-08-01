using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.MastersSchool
{
    public class BookReturnMasModel
    {
        public int ReturnCode { get; set; }
        public int ReturnDocNo { get; set; }
        public int SeriesCode { get; set; }
        public string SeriesName { get; set; }
        public DateTime ReturnDate { get; set; }
        public int StudentCode { get; set; }
        public string StudentName { get; set; }
        public string Remarks { get; set; }
    }

    public class BookReturnDetModel
    {
        public int ReturnCode { get; set; }
        public int BookCode { get; set; }
        public int SrNo { get; set; }

        public string BookName { get; set; }
        public DateTime ReturnDate { get; set; }
        public int IssueCode { get; set; }
        public int IssueDocNo { get; set; }
        public DateTime IssueDate { get; set; }

    }

    public class BookReturnFilterModel
    {
        public int ReturnCode { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int? SeriesCode { get; set; }
        public int? StudentCode { get; set; }
        public string StudentName { get; set; }

    }


}
