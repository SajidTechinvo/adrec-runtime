using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Plots
{
    public class ServiceListingResponse
    {
        [JsonPropertyName("workflowConst")]
        public string WorkflowConst { get; set; }

        [JsonPropertyName("workflowNameE")]
        public string WorkflowNameE { get; set; }

        [JsonPropertyName("workflowNameA")]
        public string WorkflowNameA { get; set; }

        [JsonPropertyName("workflowId")]
        public int WorkflowId { get; set; }

        [JsonPropertyName("isMostlyUsedService")]
        public bool IsMostlyUsedService { get; set; }

        [JsonPropertyName("isFavorite")]
        public bool IsFavorite { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
}