using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.DMTModel.ElmsServices
{
    public class StartManagePlotLegalRemarks
    {
        [JsonPropertyName("plotId")]
        public int PlotId { get; set; }

        [JsonPropertyName("plotOwners")]
        public List<int> PlotOwners { get; set; }
    }

    public class RegisterManagePlotLegalRemarks
    {
        [JsonPropertyName("plotLegalRemarks")]
        public string PlotLegalRemarks { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }
    }

    public class ApproveManagePlotLegalRemarks
    {
        [JsonPropertyName("plotLegalRemarks")]
        public string PlotLegalRemarks { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }
    }
}