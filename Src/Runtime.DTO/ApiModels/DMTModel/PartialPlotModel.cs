using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.DMTModel
{
    public class AddPartialBlockWorkflowRequest
    {
        [JsonPropertyName("partialBlockTxnWorkflows")]
        public List<PartialBlockTxnWorkflowModel> PartialBlockTxnWorkflows { get; set; }
    }

    public class PartialBlockTxnWorkflowModel
    {
        [JsonPropertyName("businessEntityBlockTxnId")]
        public int BusinessEntityBlockTxnId { get; set; }

        [JsonPropertyName("workflowId")]
        public int WorkflowId { get; set; }

        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }
    }
}