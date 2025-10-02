using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.DMTModel.ElmsServices
{
    public class StartEditUnitDetailRequest
    {
        [JsonPropertyName("unitId")]
        public long UnitId { get; set; }
    }

    public class SubmitEditUnitDetailRequest
    {
        [JsonPropertyName("unitArchiveNumber")]
        public string UnitArchiveNumber { get; set; }

        [JsonPropertyName("backOfficeResponse")]
        public string BackOfficeResponse { get; set; }
    }
}