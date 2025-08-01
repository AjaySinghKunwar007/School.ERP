namespace Optimum.ERP.Models.Masters
{
    public class GetDropdownDataModel
    {
        public string ValueField { get; set; }
        public string TextField { get; set; }
        public bool Value { get; set; }
    }
    public class GetPrintFormatDropdownDataModel
    {
        public string REPORTID { get; set; }
        public string FFormat { get; set; }
        public bool Value { get; set; }
    }

    public class GetMaxValueFromTable
    {
        public int MaxValue { get; set; }
        public string MaxValuechr { get; set; }
    }

    public class IsExistDataInTables
    {
        public string Name { get; set; }
        public int FieldValue { get; set; }
        public string FieldData{ get; set; }
        public int ReturnValue{ get; set; }
    }
}
