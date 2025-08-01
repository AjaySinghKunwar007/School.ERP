using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Optimum.ERP.Models.Reports;

namespace Optimum.ERP.Models.ExamSchool
{
    public class ClassSubjectModel
    {
        public int ClassSubjectCode { get; set; }
        public int ClassCode { get; set; }
        public string  ClassName { get; set; }
        public int SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int MaxMarks { get; set; }
        public int PassMarks { get; set; }
        public int ExamCode { get; set; }
        public string  ExamName { get; set; }
        public int IsOptional { get; set; }
        public string IsOptionalT { get; set; }
        public int Position { get; set; }

    }
    public class ClassSubjectFilterModel
    {
        public int? ClassSubjectCode { get; set; }
        public string SubjectName { get; set; }

        public int? ExamCode { get; set; }
        public string ExamName { get; set; }

        public string ClassName { get; set; }
        public int? ClassCode { get; set; }
    }
}
