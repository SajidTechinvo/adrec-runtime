using System.Text.Json.Serialization;

namespace ADREC.DTO.ApiModels.DMTModel.ElmsServices
{
    public class StartManageOwnerPartialBlock
    {
        [JsonPropertyName("_check0")]
        public string Check0 { get; set; }

        [JsonPropertyName("ownerId")]
        public int OwnerId { get; set; }
    }
}