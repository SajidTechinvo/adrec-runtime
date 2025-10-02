using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsDecree
{
    public class OwnerAllotmentNameResponse
    {
        [JsonPropertyName("decreeOrder")]
        public double DecreeOrder { get; set; }

        [JsonPropertyName("ownerName")]
        public string OwnerName { get; set; }

        [JsonPropertyName("plotNumber")]
        public string PlotNumber { get; set; }

        [JsonPropertyName("landUse")]
        public string LandUse { get; set; }

        [JsonPropertyName("districtName")]
        public string DistrictName { get; set; }

        [JsonPropertyName("familyBookNumber")]
        public string FamilyBookNumber { get; set; }

        [JsonPropertyName("cityNo")]
        public string CityNo { get; set; }

        [JsonPropertyName("communityId")]
        public int? CommunityId { get; set; }

        [JsonPropertyName("community")]
        public string Community { get; set; }

        [JsonPropertyName("allotmentNameId")]
        public int AllotmentNameId { get; set; }

        [JsonPropertyName("tradeLicense")]
        public object TradeLicense { get; set; }

        [JsonPropertyName("certificateNumber")]
        public object CertificateNumber { get; set; }

        [JsonPropertyName("applicantType")]
        public string ApplicantType { get; set; }

        [JsonPropertyName("allotmentStatus")]
        public string AllotmentStatus { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}