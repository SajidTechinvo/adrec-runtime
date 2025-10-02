using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.Common
{
    public class DmtResponseWrapper<T>
    {
        [JsonPropertyName("result")]
        public T Result { get; set; }

        [JsonPropertyName("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonPropertyName("unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }

        [JsonPropertyName("__app")]
        public bool App { get; set; }

        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("error")]
        public DmtError Error { get; set; }
    }

    public class DmtError
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("details")]
        public object Details { get; set; }

        [JsonPropertyName("validationErrors")]
        public List<DmtValidationError> ValidationErrors { get; set; }
    }

    public class DmtValidationError
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("members")]
        public object Members { get; set; }

        [JsonPropertyName("messageAr")]
        public object MessageAr { get; set; }

        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }

        [JsonPropertyName("workflowConst")]
        public object WorkflowConst { get; set; }

        [JsonPropertyName("applicationNumber")]
        public object ApplicationNumber { get; set; }

        [JsonPropertyName("gspCode")]
        public object GspCode { get; set; }
    }

    public class DmtPageResponse<T>
    {
        [JsonPropertyName("items")]
        public List<T> Items { get; set; }

        [JsonPropertyName("sortBy")]
        public bool SortBy { get; set; }

        [JsonPropertyName("_sorting")]
        public object Sorting_ { get; set; }

        [JsonPropertyName("sorting")]
        public object Sorting { get; set; }

        [JsonPropertyName("pageSize")]
        public int PageSize { get; set; }

        [JsonPropertyName("pageNumber")]
        public int PageNumber { get; set; }

        [JsonPropertyName("totalCount")]
        public int TotalCount { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}