using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsDecree
{
    public class LetterAllotmentResponse
    {
        [JsonPropertyName("allotmentLetterId")]
        public int AllotmentLetterId { get; set; }

        [JsonPropertyName("allotmentLetterName")]
        public string AllotmentLetterName { get; set; }

        [JsonPropertyName("decreeId")]
        public int DecreeId { get; set; }

        [JsonPropertyName("migNote")]
        public object MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("municipalityId")]
        public int MunicipalityId { get; set; }

        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}