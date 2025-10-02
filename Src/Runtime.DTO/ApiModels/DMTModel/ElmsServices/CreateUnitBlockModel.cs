using System.Text.Json.Serialization;

namespace ADREC.DTO.ApiModels.DMTModel.ElmsServices
{
    public class StartCreateUnitBlock
    {
        [JsonPropertyName("_check0")]
        public string Check0 { get; set; }

        [JsonPropertyName("unitId")]
        public int UnitId { get; set; }
    }

    public class RegisterSubmitCreateUnitBlock
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