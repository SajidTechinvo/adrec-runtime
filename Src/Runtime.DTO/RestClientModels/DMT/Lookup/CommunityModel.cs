using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Lookup
{
    public class CommunityResponse
    {
        [JsonPropertyName("businessFlags")]
        public object BusinessFlags { get; set; }

        [JsonPropertyName("communityId")]
        public int CommunityId { get; set; }

        [JsonPropertyName("communityNameA")]
        public string CommunityNameA { get; set; }

        [JsonPropertyName("communityNameE")]
        public string CommunityNameE { get; set; }

        [JsonPropertyName("communityNumber")]
        public string CommunityNumber { get; set; }

        [JsonPropertyName("districtId")]
        public int DistrictId { get; set; }

        [JsonPropertyName("migNote")]
        public double? MigNote { get; set; }

        [JsonPropertyName("municipalityId")]
        public int MunicipalityId { get; set; }

        [JsonPropertyName("plotAppraisalGroupId")]
        public int? PlotAppraisalGroupId { get; set; }

        [JsonPropertyName("sectorId")]
        public double? SectorId { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}