using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.DMTModel.ElmsServices
{
    public class RegisterAllowLandTrading
    {
        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("referenceNumber")]
        public string ReferenceNumber { get; set; }
    }

    public class EvaluateAllowLandTrading
    {
        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("plotEvaluationAmount")]
        public string PlotEvaluationAmount { get; set; }

        [JsonPropertyName("evaluationAmount")]
        public string EvaluationAmount { get; set; }
    }
}