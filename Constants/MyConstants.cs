using Optimum.ERP.Models.Config;
using System.Reflection;

namespace Optimum.ERP.Models.Constants
{
    public class MyConstants
    {
        public const string Select = "--Select--";
        public const string All = "--ALL--";
        public const string ApiKey = "x-api-key";

        public static string GetDescription<T>(string typeCode)
        {
            return (from s in typeof(T).GetFields()
                    where s.GetValue(null).ToString() == typeCode
                    select new
                    {
                        Code = s.GetValue(null).ToString(),
                        Desciption = (s.HasAttribute(typeof(DescriptionAttribute)) ? s.GetCustomAttribute<DescriptionAttribute>().Description : s.GetValue(null).ToString())
                    }).SingleOrDefault()?.Desciption;
        }
        public partial class SoftwareTypeConst
        {
            public const int All = 1;
            public const int ERP = 2;
            public const int School = 3;
            public const int College = 4;
            public const int Retail = 5;
            public const int Restaurant = 6;
            public const int Billing = 7;
        }

        public partial class DropDownTypeConst
        {
            public const int Flat = 1;
            public const int List = 2;
        }
        public partial class DropDownSearchTypeConst
        {
            public const int WordWise = 1;
            public const int List = 2;
        }
        public class MessagesConst
        {
            public const string DataSaved = "Data Saved !!!";
            public const string DataUpdated = "Data Updated !!!";
            public const string DataDeleted = "Data Deleted.";
            public const string Error = "Error !!!";
            public const string Unauthorized = "You are not authorized.";
        }
        public partial class logbookOperation
        {
            public const int Add = 1;
            public const int Edit = 2;
            public const int Delete = 3;
            public const int Login = 4;
            public const int LogOff = 5;
        }

        public partial class FormNameConst
        {
            public const string ItemMas = "ItemMas";
            public const string AccMas = "AccMAs";
            public const string StudentMas = "StudentMas";
            public const string VouchMas = "VouchMas";
            public const string SaleMas = "SaleMas";
            public const string PurcMas = "PurcMas";
            public const string RGPMas = "RGPMas";
            public const string RRGPMas = "RRGPMas";
        }

       
    }
}
