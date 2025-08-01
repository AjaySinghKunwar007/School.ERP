using System.Text.Json.Serialization;

namespace Optimum.ERP.Models.Config
{
    public class GridColumnModel
    {
        [JsonIgnore]
        public bool IsPrimaryKey { get; set; }

        public string PropertyName { get; set; }

        public string DisplayName { get; set; }

        [JsonIgnore]
        public bool Visible { get; set; }

        public int DisplayIndex { get; set; }

        public int Width { get; set; }

        public short? DecimalPlaces { get; set; }
        public string Alignment { get; set; } = "Left";
        public string FormatString { get; set; }
    }
}
