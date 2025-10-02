using System.Text.Json.Serialization;

namespace ADREC.DTO.ApiModels.DMTModel.ElmsServices
{
    public class StartTenancyAgreementFix
    {
        [JsonPropertyName("tenancyContractId")]
        public string TenancyContractId { get; set; }

        [JsonPropertyName("plotId")]
        public int PlotId { get; set; }

        [JsonPropertyName("isRenew")]
        public int IsRenew { get; set; }
    }

    public class RegisterTenancyAgreementFix
    {
        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("contractType")]
        public string ContractType { get; set; }

        [JsonPropertyName("contractDate")]
        public string ContractDate { get; set; }

        [JsonPropertyName("startDate")]
        public string StartDate { get; set; }

        [JsonPropertyName("endDate")]
        public string EndDate { get; set; }

        [JsonPropertyName("unitType")]
        public string UnitType { get; set; }

        [JsonPropertyName("tenancyRemarks")]
        public string TenancyRemarks { get; set; }

        [JsonPropertyName("terminateDate")]
        public string TerminateDate { get; set; }

        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }
    }
}