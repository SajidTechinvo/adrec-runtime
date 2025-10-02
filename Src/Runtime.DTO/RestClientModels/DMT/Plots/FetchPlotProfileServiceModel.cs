using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Plots
{
    public class FetchPlotProfileServiceResponse
    {
        [JsonPropertyName("workflowTypeConst")]
        public string WorkflowTypeConst { get; set; }

        [JsonPropertyName("workflowConst")]
        public string WorkflowConst { get; set; }

        [JsonPropertyName("workflowId")]
        public int WorkflowId { get; set; }

        [JsonPropertyName("workflowTypeId")]
        public int WorkflowTypeId { get; set; }

        [JsonPropertyName("isMostlyUsedService")]
        public bool IsMostlyUsedService { get; set; }

        [JsonPropertyName("permissionId")]
        public int PermissionId { get; set; }

        [JsonPropertyName("permissionConst")]
        public string PermissionConst { get; set; }

        [JsonPropertyName("isOwnerElmsAudited")]
        public bool IsOwnerElmsAudited { get; set; }

        [JsonPropertyName("workflowGroupId")]
        public int WorkflowGroupId { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}