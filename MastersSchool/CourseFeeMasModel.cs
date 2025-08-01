using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.MastersSchool
{
    public class CourseFeeMasModel
    {
        public int CourseFeeCode { get; set; }
        public int CourseCode { get; set; }
        public string CourseName { get; set; }
        public string CourseDisplayName { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public decimal FeeAmt { get; set; }
        public string Active { get; set; }
    }
    public class CourseFeeDetModel
    {
        public int? CourseFeeCode { get; set; }
        public int SrNo { get; set; }
        public int FeeCode { get; set; }
        public string FeeName { get; set; }
        public decimal Amount { get; set; }

    }

    public class CourseFeeMasFillterModel
    {
        public int? CourseCode { get; set; }
    }
}
