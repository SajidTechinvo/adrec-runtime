using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.DMTModel.ElmsServices
{
    public class StartManagePlotCommentRequest
    {
        [JsonPropertyName("plotId")]
        public int PlotId { get; set; }

        [JsonPropertyName("changeType")]
        public string ChangeType { get; set; }
    }

    public class RegisterManagePlotCommentRequest
    {
        [JsonPropertyName("commentTypeId")]
        public string CommentTypeId { get; set; }

        [JsonPropertyName("commentTitle")]
        public string CommentTitle { get; set; }

        [JsonPropertyName("commentDate")]
        public string CommentDate { get; set; }

        [JsonPropertyName("isHoldConstructionPermitTransactions")]
        public string IsHoldConstructionPermitTransactions { get; set; }

        [JsonPropertyName("isHoldTawtheeqTransactions")]
        public string IsHoldTawtheeqTransactions { get; set; }

        [JsonPropertyName("commentText")]
        public string CommentText { get; set; }
    }
}