using System;

namespace Optimum.ERP.Models.Masters
{
    public class RawMasModel
    {
        public int RawCode { get; set; }
        public string RawDesc { get; set; }
        public string RawName { get; set; }
        public string RawCodeNew { get; set; }
        public decimal Rate { get; set; }
        public string DepartmentName { get; set; } //Add On
        public string DishHeadName { get; set; } //Add On
        public string DishTypeName { get; set; } //Add On
        public string UnitName { get; set; }  //Add On
        public string  HSNName { get; set; } // Add On
        public decimal  GST { get; set; } // Add On
        public int ItemGroupCode { get; set; }
        public int UnitCode  { get; set; }
        public int? DishHeadCode { get; set; }
        public int? KitchenCode { get; set; }
        public decimal HD { get; set; }
        public int ActiveItem  { get; set; }
        public int Discountable { get; set; }
        public int ChangableRate { get; set; }
        public decimal PurcRate  { get; set; }
        public int? HSNCode { get; set; }
        public int IsDeleted { get; set; }
        public string OldRawCode { get; set; }
        public int RawGroupCode { get; set; }
        public string RawGroupName { get; set; }

        //Add On Data
        public decimal OpStock { get; set; }
        public int IsCombo { get; set; }
        public decimal RateTakeaway { get; set; }
        public int Recipe { get; set; }
        public string PicturePath { get; set; }
        public int IsTaxExtra { get; set; }
        public decimal Cess { get; set; }
        public decimal Disc { get; set; }
        public int? StartTime_HH { get; set; }
        public int? StartTime_MM { get; set; }
        public int? EndTime_HH { get; set; }
        public int? EndTime_MM { get; set; }
        public decimal MRP { get; set; }
        public decimal MinQty { get; set; }
        public decimal MaxQty { get; set; }
        public int RowColor { get; set; }
        public int Food_Type { get; set; }
        public int Recommended { get; set; }
        public string AlternateName1 { get; set; }
        public string AlternateName2 { get; set; }
        public string AlternateName3 { get; set; }
        public string AlternateName4 { get; set; }
        public int? ShowInApp { get; set; }
        public int SaleRate2 { get; set; }
        public int? RawSrNo { get; set; }
        public int Pack { get; set; }
        public int IsSync { get; set; }
        public decimal ProfitMargin { get; set; }
        public string ItLocation { get; set; }
        public string ItField1 { get; set; }
        public string ItField2 { get; set; }
        public string ItField3 { get; set; }
        public string ItField4 { get; set; }
        public string ItField5 { get; set; }
        public string ItField6 { get; set; }
        public string ItField7 { get; set; }
        public string ItField8 { get; set; }
        public string ItField9 { get; set; }
        public string ItField10 { get; set; }
        public int BestUse { get; set; }
        public int BulkQty { get; set; }
        public decimal BulkRate { get; set; }
        public decimal? RateWholeSale { get; set; }
        public int UserCode { get; set; }
        public int IsActive { get; set; }
        public DateTime UpdateDate { get; set; }
        public int LocationCode { get; set; }
        public string LocationName { get; set; }


    }
    public class RawMasFiltterModel
    {
         public int? RawCode { get; set; }
         public string RawDesc { get; set; }
         public int? DishHeadCode { get; set; }
         public  int?  RawGroupCode { get; set; }
         public int? IsActive { get; set; }
         public int? HSNCode { get; set; }
        public int? KitchenCode { get; set; }
        public int? SoftwareCode { get; set; }
        public int? LocationCode { get; set; }
        public int? companyCode { get; set; }
    } 
}
