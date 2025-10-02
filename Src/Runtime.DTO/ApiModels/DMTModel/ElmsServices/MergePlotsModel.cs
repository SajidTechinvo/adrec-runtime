using System.Text.Json.Serialization;

namespace ADREC.DTO.ApiModels.DMTModel.ElmsServices
{
    public class StartMergePlotsRequest
    {
        [JsonPropertyName("mergePlotsIdList")]
        public List<int> MergePlotsIdList { get; set; }
    }

    public class Decree
    {
        [JsonPropertyName("decreeNumber")]
        public string DecreeNumber { get; set; }

        [JsonPropertyName("decreeDate")]
        public DateTime DecreeDate { get; set; }

        [JsonPropertyName("decreeSourceId")]
        public int DecreeSourceId { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }
    }

    public class RegisterMergePlotsRequest
    {
        [JsonPropertyName("referenceNumber")]
        public string ReferenceNumber { get; set; }

        [JsonPropertyName("decreeNumber")]
        public string DecreeNumber { get; set; }

        [JsonPropertyName("decreeDate")]
        public string DecreeDate { get; set; }

        [JsonPropertyName("decreeSourceId")]
        public string DecreeSourceId { get; set; }

        [JsonPropertyName("sourceNameId")]
        public string SourceNameId { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("decree")]
        public Decree Decree { get; set; }
    }
}