using System.Diagnostics.Contracts;

namespace Optimum.ERP.Models.Config
{
    public class SysconfgModel

    {
        public int CompanyID { get; set; }
        public string CName { get; set; }
        public DateTime StrtDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string City { get; set; }

        public string StateName { get; set; }
        public int StateCode { get; set; }
        public string Country { get; set; }
        public string PINCode { get; set; }
        public string GSTNumber { get; set; }
        public string Phone { get; set; }
        public int dbVersion { get; set; }
    }

    public class SftpSetting
    {
        public string Host { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class GetCStateCode()
    {
        public int StateCode { get; set; }
    }
}
