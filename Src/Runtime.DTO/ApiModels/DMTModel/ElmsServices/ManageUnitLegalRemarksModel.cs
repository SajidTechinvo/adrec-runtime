using System.Text.Json.Serialization;

namespace ADREC.DTO.ApiModels.DMTModel.ElmsServices
{
    public class StartManageUnitLegalRemarks
    {
        [JsonPropertyName("unitId")]
        public long UnitId { get; set; }
    }

    public class RegisterManageUnitLegalRemarks
    {
        [JsonPropertyName("plotLegalRemarks")]
        public string PlotLegalRemarks { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }
    }

    public class ApproveManageUnitLegalRemarks
    {
        [JsonPropertyName("plotLegalRemarks")]
        public string PlotLegalRemarks { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }
    }
}