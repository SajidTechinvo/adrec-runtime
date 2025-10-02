using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.Lookup
{
    public class AppraisalValueTypeModel
    {
        [JsonPropertyName("appraisalValueTypeId")]
        public int AppraisalValueTypeId { get; set; }

        [JsonPropertyName("appraisalValueTypeNameA")]
        public string AppraisalValueTypeNameA { get; set; }

        [JsonPropertyName("appraisalValueTypeNameE")]
        public string AppraisalValueTypeNameE { get; set; }

        [JsonPropertyName("migNote")]
        public double MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("municipalityId")]
        public int MunicipalityId { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}