using System.Text.Json.Serialization;

namespace ADREC.DTO.ApiModels.DMTModel
{
    public class SearchGisPlotRequest
    {
        [JsonPropertyName("requestId")]
        public int RequestId { get; set; }

        [JsonPropertyName("municipalityId")]
        public string MunicipalityId { get; set; }

        [JsonPropertyName("districtId")]
        public string DistrictId { get; set; }

        [JsonPropertyName("communityId")]
        public string CommunityId { get; set; }

        [JsonPropertyName("roadId")]
        public string RoadId { get; set; }

        [JsonPropertyName("pageSize")]
        public int PageSize { get; set; }

        [JsonPropertyName("pageNumber")]
        public int PageNumber { get; set; }

        [JsonPropertyName("totalCount")]
        public int TotalCount { get; set; }
    }
}