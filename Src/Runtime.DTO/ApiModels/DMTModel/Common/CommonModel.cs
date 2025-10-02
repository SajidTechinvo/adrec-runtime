using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.DMTModel.Common
{
    public class AddPlotRequest
    {
        [JsonPropertyName("plotId")]
        public long PlotId { get; set; }
    }

    public class BackOfficeModel
    {
        [JsonPropertyName("backOfficeResponse")]
        public string BackOfficeResponse { get; set; }
    }

    public class CommentModel
    {
        [JsonPropertyName("comments")]
        public string Comments { get; set; }
    }

    public class BackModel
    {
        [JsonPropertyName("backOfficeResponse")]
        public string BackOfficeResponse { get; set; }

        [JsonPropertyName("isAuditorOverriden")]
        public string IsAuditorOverriden { get; set; }

        [JsonPropertyName("hideCancelBtn")]
        public string HideCancelBtn { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }
    }
}