namespace Optimum.ERP.Models.Masters
{
    public class TypeMasModel
    {
        public int Typecode { get; set; } //STypeCode
        public string Typename { get; set; } //Stypename
        public string TypeDesc { get; set; } //StypeDesc
        public string TypeT { get; set; } //AddOn
        public string RegionT { get; set; } //AddOn
        public string TaxOnT { get; set; } //AddOn
        public decimal TaxPerc1 { get; set; }
        public decimal TaxPerc2 { get; set; }
        public string TypeAccName { get; set; } //AddOn
        public string Type { get; set; }
        public int Region { get; set; }

        public int TypeAccCode { get; set; }
        public int GSTAccCode1 { get; set; }
        public int GSTAccCode2 { get; set; }
        public int Issync { get; set; }
        public int TaxOn { get; set; }
        public int? LocationCode { get; set; }
        public int IsDeleted { get; set; }
    }

    public class TypeMasFiltterModel
    {
        public int? Typecode { get; set; }
        public int? LocationCode { get; set; }
        public int? CompanyCode { get; set; }
        public string TypeName { get; set; }
        public int? Type { get; set; }
        
    }
}
