using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.ElmsServices.Common
{
    public class UnitUsageTypeResponse
    {
        [JsonPropertyName("businessFlags")]
        public object BusinessFlags { get; set; }

        [JsonPropertyName("nameA")]
        public string NameA { get; set; }

        [JsonPropertyName("nameE")]
        public string NameE { get; set; }

        [JsonPropertyName("parentPropertyUsageTypeId")]
        public int ParentPropertyUsageTypeId { get; set; }

        [JsonPropertyName("propertyUsageTypeId")]
        public int PropertyUsageTypeId { get; set; }

        [JsonPropertyName("tawPropertyCode")]
        public object TawPropertyCode { get; set; }

        [JsonPropertyName("tawUnitCode")]
        public object TawUnitCode { get; set; }

        [JsonPropertyName("joinedPropertyUsageTypeNameA")]
        public string JoinedPropertyUsageTypeNameA { get; set; }

        [JsonPropertyName("joinedPropertyUsageTypeNameE")]
        public string JoinedPropertyUsageTypeNameE { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}