using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.MastersSchool
{
    public class BookMasModel
    {
        public int BookCode { get; set; }
        public string BookName { get; set; }
        public string BarCode { get; set; }
        public int AuthorCode { get; set; }
        public string AuthorName { get; set; }
        public string ISBN { get; set; }
        public int PublisherCode { get; set; }
        public string PublisherName { get; set; }
        public string Edition {  get; set; }
        public int BookClassificationCode { get; set; }
        public String BookClassificationName { get; set; }
        public int PublicationYear {  get; set; }
        public int NoOfPage { get; set; }
        public string SelfLocation { get; set; }
        public decimal MRP { get; set; }
        public string DigitalCopyLink { get; set; }
        public string Remarks { get; set; }

    }

    public class BookMasFilterModel
    {
        public int? BookCode { get; set; }
        public string BookName { get; set; }
        public int PublisherCode { get; set; }
        public int AuthorCode { get; set; }
        public int BookClassificationCode { get; set; }

    }
}
