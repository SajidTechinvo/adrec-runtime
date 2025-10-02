using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.DMTModel.ElmsTenancy
{
    public class CalculateRentFeesRequest
    {
        [JsonPropertyName("tenancyContractTypeId")]
        public int TenancyContractTypeId { get; set; }

        [JsonPropertyName("ranchLandClassificationId")]
        public int RanchLandClassificationId { get; set; }

        [JsonPropertyName("plotId")]
        public int PlotId { get; set; }
    }
}