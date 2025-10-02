using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.DMTModel.ElmsServices
{
    public class StartPropertyMortgageRedemption
    {
        [JsonPropertyName("selectedPlotMortgageId")]
        public int SelectedPlotMortgageId { get; set; }
    }

    public class RegisterPropertyMortgageRedemption
    {
        [JsonPropertyName("videoUrl")]
        public string VideoUrl { get; set; }

        [JsonPropertyName("mortgageContractNumber")]
        public string MortgageContractNumber { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("plotIds")]
        public List<string> PlotIds { get; set; }
    }
}