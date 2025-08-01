namespace Optimum.ERP.Models.Masters
{
    public class UnitModel
    {
        public int UnitCode { get; set; }
        public string UnitName { get; set; }
        public string UnitShortName { get; set; }
        public int LocationCode { get; set; }
    }

    public class UnitFiltterModel
    {
        public int? UnitCode { get; set; }
        public string UnitName { get; set; }
        public int? LocationCode { get; set; }
        public int? CompanyCode { get; set; }
    }
}
