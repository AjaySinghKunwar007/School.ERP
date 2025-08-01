using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Optimum.ERP.Models.Config;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Optimum.ERP.Models.Reports
{
    public class ReportViewModel
    {
        public char GridRowType { get; set; } = 'R';//T,G
    }

    public class SaleReport_billWiseDetails : ReportViewModel
    {
        public int? BillNo { get; set; }
        public DateTime BillDate { get; set; }
        public int? SrNo { get; set; }
        public string RawDesc { get; set; }
        public string UnitName { get; set; }
        public decimal? SaleRate { get; set; }
        public decimal? QTY { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Disc { get; set; }
        public decimal? DiscAmt { get; set; }
        public decimal? CGST { get; set; }
        public decimal? SGST { get; set; }
        public decimal? GSTAmount { get; set; }
        public decimal? BillAmt { get; set; }
        public string AccName { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string GSTIN { get; set; }
        public string SaleType { get; set; }
    }

    public class SaleReports_BillWiseSummary : ReportViewModel
    {
        public int? BillNo { get; set; }
        public DateTime BillDate { get; set; }
        public string AccName { get; set; }
        public decimal CGST { get; set; }
        public decimal CGSTAmt { get; set; }
        public decimal SGST { get; set; }
        public decimal SGSTAmt { get; set; }
        public decimal? BillAmt { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public string SaleType { get; set; }

    }
    public class SaleReports_DateWise : ReportViewModel
    {
        public DateTime SaleDate { get; set; }
        public decimal Amount { get; set; }
    }
    public class SaleReportGroupWiseModel : ReportViewModel
    {
        public int? BillNo { get; set; }
        public DateTime SaleDate { get; set; }
        public int? SrNo { get; set; }
        public string Accname { get; set; }
        public string RawGroupName { get; set; }
        public string rawDesc { get; set; }
        public string ItemCode { get; set; }
        public string Unit { get; set; }
        public decimal? Rate { get; set; }
        public decimal? QTY { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Disc { get; set; }
        public decimal? DiscAmt { get; set; }
        public decimal? CGSTAmt { get; set; }
        public decimal? SGSTAmt { get; set; }
        public decimal? GSTAmount { get; set; }
        public decimal? BillAmt { get; set; }
    }
    public class SaleReportPartywiseItemWiseModel : ReportViewModel
    {
        public int? BillNo { get; set; }
        public DateTime SaleDate { get; set; }
        public int? SrNo { get; set; }
        public string Accname { get; set; }
        public string RawGroupName { get; set; }
        public string rawDesc { get; set; }
        public string rawCodeNew { get; set; }
        public string UnitName { get; set; }
        public decimal? Rate { get; set; }
        public decimal? QTY { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Disc { get; set; }
        public decimal? DiscAmt { get; set; }
        public decimal? CGST { get; set; }
        public decimal? SGST { get; set; }
        public decimal? GSTAmount { get; set; }
        public decimal? BillAmt { get; set; }
    }
    public class SaleReportsFiltterModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int ReportType { get; set; }
        public string ReportName { get; set; }
        public int? AccCode { get; set; }
        public int? LocationCode { get; set; }
        public int? TypeCode { get; set; }
        public int? SeriesCode { get; set; }
        public int? RawGroupCode { get; set; }
        public int? RawCode { get; set; }
    }

    public class SaleRegisterModel : ReportViewModel
    {


    }

}
