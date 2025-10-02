using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.DMTModel.ElmsServices
{
    public class StartCreatePlotBlock
    {
        [JsonPropertyName("_check0")]
        public string Check0 { get; set; }

        [JsonPropertyName("plotId")]
        public int PlotId { get; set; }
    }

    public class RegisterCreatePlotBlock
    {
        [JsonPropertyName("authoritySourceTypeId")]
        public string AuthoritySourceTypeId { get; set; }

        [JsonPropertyName("authoritySourceName")]
        public string AuthoritySourceName { get; set; }

        [JsonPropertyName("blockEndDate")]
        public DateTime BlockEndDate { get; set; }

        [JsonPropertyName("otherSourceName")]
        public string OtherSourceName { get; set; }

        [JsonPropertyName("blockComments")]
        public string BlockComments { get; set; }

        [JsonPropertyName("authoritySourceId")]
        public string AuthoritySourceId { get; set; }
    }
}