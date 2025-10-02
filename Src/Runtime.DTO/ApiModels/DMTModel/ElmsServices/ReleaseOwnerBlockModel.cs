using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.DMTModel.ElmsServices
{
    public class StartReleaseOwnerBlock
    {
        [JsonPropertyName("_check0")]
        public string Check0 { get; set; }

        [JsonPropertyName("blockId")]
        public int BlockId { get; set; }
    }
}