using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Lookup
{
    public class FetchSurveyReasonTypesResponse
    {
        [JsonPropertyName("elmsSurveyReasonTypeConst")]
        public string ElmsSurveyReasonTypeConst { get; set; }

        [JsonPropertyName("surveyReasonType")]
        public int SurveyReasonType { get; set; }

        [JsonPropertyName("surveyReasonTypeNameA")]
        public string SurveyReasonTypeNameA { get; set; }

        [JsonPropertyName("surveyReasonTypeNameE")]
        public string SurveyReasonTypeNameE { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}