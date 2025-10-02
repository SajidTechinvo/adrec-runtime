using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Plots
{
    public class StartActionResponse
    {
        [JsonPropertyName("workflowTypeConst")]
        public string WorkflowTypeConst { get; set; }

        [JsonPropertyName("workflowTypeConstAr")]
        public string WorkflowTypeConstAr { get; set; }

        [JsonPropertyName("workflowConst")]
        public string WorkflowConst { get; set; }

        [JsonPropertyName("workflowConstAr")]
        public string WorkflowConstAr { get; set; }

        [JsonPropertyName("workflowId")]
        public int WorkflowId { get; set; }

        [JsonPropertyName("workflowTypeId")]
        public int WorkflowTypeId { get; set; }

        [JsonPropertyName("isMostlyUsedService")]
        public bool IsMostlyUsedService { get; set; }

        [JsonPropertyName("isFavorite")]
        public bool IsFavorite { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }

    public class ActiveServiceResponse
    {
        [JsonPropertyName("workflowTypeConst")]
        public string WorkflowTypeConst { get; set; }

        [JsonPropertyName("workflowTypeConstAr")]
        public string WorkflowTypeConstAr { get; set; }

        [JsonPropertyName("services")]
        public List<StartActionResponse> Services { get; set; }
    }
}