using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum.ERP.Models.Reports
{
    public class StockReportSummaryModel : ReportViewModel
    {
        public string AccName { set; get; }
        public int? SNo { set; get; }
        public string Desc { set; get; }
        public string RawDesc { set; get; }
        public string RawGroupName { set; get; }
        public string UnitName { set; get; }
        public decimal? Opening { set; get; }
        public decimal? Inward { set; get; }
        public decimal? Outward { set; get; }
        public decimal? Closing { set; get; }
    }

    public class StockReportDetailModel : ReportViewModel
    {
        public string InvNo { get; set; }
        public int? SNo { get; set; }
        public string InvDate { get; set; }
        public string AccName { get; set; }
        public string Desc { get; set; }
        public string RawDesc { get; set; }
        public string RawGroupName { get; set; }
        public string LocationName { get; set; }
        public int? RawCode { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Inward { get; set; }
        public decimal? Outward { get; set; }
        public decimal? Balance { get; set; }
        public string UnitName { get; set; }
        public string SeriesName { get; set; }

    }

    public class StockReportClosingDataModel : ReportViewModel
    {
        public int? SNo { get; set; }
        public string Desc { get; set; }
        public int RawCode { get; set; }
        public string RawDesc { get; set; }
        public decimal? Closing { get; set; }
        public decimal? Qty { get; set; }
        public string UnitName { get; set; }
        public string LocationName { get; set; }

    }

    public class StockReportFilterModel
    {
        public int? LocationCode { set; get; }
        public int? RawCode { set; get; }
        public int? RawGroupCode { set; get; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string ReportType { get; set; }
    }
}




