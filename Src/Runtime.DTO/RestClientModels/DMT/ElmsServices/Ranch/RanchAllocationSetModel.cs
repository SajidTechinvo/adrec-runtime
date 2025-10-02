using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsServices.Ranch
{
    public class RanchAllocationSetResponse
    {
        [JsonPropertyName("landClassificationId")]
        public int LandClassificationId { get; set; }

        [JsonPropertyName("municipalityId")]
        public int MunicipalityId { get; set; }

        [JsonPropertyName("nameA")]
        public string NameA { get; set; }

        [JsonPropertyName("nameE")]
        public string NameE { get; set; }

        [JsonPropertyName("randomAllotmentSetId")]
        public int RandomAllotmentSetId { get; set; }

        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}