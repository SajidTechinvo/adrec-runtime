using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.ElmsTenancy
{
    public class SearchTenancyContractItem
    {
        [JsonPropertyName("contractNumber")]
        public string ContractNumber { get; set; }

        [JsonPropertyName("tenancyContractId")]
        public string TenancyContractId { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("isRenew")]
        public int IsRenew { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }

    public class SearchTenancyContractResponse
    {
        [JsonPropertyName("totalCount")]
        public int TotalCount { get; set; }

        [JsonPropertyName("items")]
        public List<SearchTenancyContractItem> Items { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}