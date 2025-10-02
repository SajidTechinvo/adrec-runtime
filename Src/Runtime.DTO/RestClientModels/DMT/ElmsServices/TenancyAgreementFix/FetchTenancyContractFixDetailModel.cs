using ADREC.DTO.RestClientModels.DMT.Plots;
using Runtime.DTO.RestClientModels.DMT.ElmsTenancy;
using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.ElmsServices.TenancyAgreementFix
{
    public class FetchTenancyContractFixDetailResponse
    {
        [JsonPropertyName("errorMessage")]
        public object ErrorMessage { get; set; }

        [JsonPropertyName("tenancyContract")]
        public TenancyContractResponse TenancyContract { get; set; }

        [JsonPropertyName("plot")]
        public PlotDetailResponse Plot { get; set; }

        [JsonPropertyName("isRanch")]
        public bool IsRanch { get; set; }

        [JsonPropertyName("tenants")]
        public object Tenants { get; set; }

        [JsonPropertyName("owners")]
        public object Owners { get; set; }

        [JsonPropertyName("annualRentAmount")]
        public double AnnualRentAmount { get; set; }

        [JsonPropertyName("annualTenancyAmountPerUnit")]
        public double AnnualTenancyAmountPerUnit { get; set; }
    }
}