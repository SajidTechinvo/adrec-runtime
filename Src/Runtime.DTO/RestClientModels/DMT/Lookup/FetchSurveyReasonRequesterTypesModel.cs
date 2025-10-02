using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Lookup
{
    public class FetchSurveyReasonRequesterTypesResponse
    {
        [JsonPropertyName("elmsSurveyRequestorTypeConst")]
        public string ElmsSurveyRequestorTypeConst { get; set; }

        [JsonPropertyName("surveyRequestorType")]
        public int SurveyRequestorType { get; set; }

        [JsonPropertyName("surveyRequestorTypeNameA")]
        public string SurveyRequestorTypeNameA { get; set; }

        [JsonPropertyName("surveyRequestorTypeNameE")]
        public string SurveyRequestorTypeNameE { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}