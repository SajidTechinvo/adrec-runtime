using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.DMTModel.ElmsServices
{
    public class StartRegisterMusatahaContract
    {
        [JsonPropertyName("_check0")]
        public string Check0 { get; set; }

        [JsonPropertyName("acceptServiceConditions")]
        public string AcceptServiceConditions { get; set; }

        [JsonPropertyName("plotId")]
        public int PlotId { get; set; }
    }

    public class SubmitRegisterMusatahaContractRequest
    {
        [JsonPropertyName("contractDuration")]
        public string ContractDuration { get; set; }

        [JsonPropertyName("tenancyRemarks")]
        public string TenancyRemarks { get; set; }

        [JsonPropertyName("numberOfYearsPayRent")]
        public string NumberOfYearsPayRent { get; set; }

        [JsonPropertyName("insuranceCompanyId")]
        public string InsuranceCompanyId { get; set; }

        [JsonPropertyName("insuranceCompanyLicNumber")]
        public string InsuranceCompanyLicNumber { get; set; }

        [JsonPropertyName("insuranceCompanyEmirateId")]
        public string InsuranceCompanyEmirateId { get; set; }

        [JsonPropertyName("insuranceCompanyAddress")]
        public string InsuranceCompanyAddress { get; set; }

        [JsonPropertyName("insuranceFeeAmount")]
        public string InsuranceFeeAmount { get; set; }

        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        [JsonPropertyName("contractTypeText")]
        public string ContractTypeText { get; set; }

        [JsonPropertyName("contractNumber")]
        public string ContractNumber { get; set; }

        [JsonPropertyName("contractDate")]
        public string ContractDate { get; set; }

        [JsonPropertyName("contractStartDate")]
        public string ContractStartDate { get; set; }

        [JsonPropertyName("contractEndDate")]
        public string ContractEndDate { get; set; }

        [JsonPropertyName("annualTenancyAmount")]
        public string AnnualTenancyAmount { get; set; }

        [JsonPropertyName("rentFeesWordAmount")]
        public string RentFeesWordAmount { get; set; }

        [JsonPropertyName("paymentStartDate")]
        public string PaymentStartDate { get; set; }

        [JsonPropertyName("rentFees")]
        public string RentFees { get; set; }

        [JsonPropertyName("toBePaidTenancyPeriodWordAmount")]
        public string ToBePaidTenancyPeriodWordAmount { get; set; }

        [JsonPropertyName("plotId")]
        public int PlotId { get; set; }

        [JsonPropertyName("isRentFreeFirstYear")]
        public bool IsRentFreeFirstYear { get; set; }

        [JsonPropertyName("isSkipPayment")]
        public bool IsSkipPayment { get; set; }

        [JsonPropertyName("totalNumberOfYears")]
        public string TotalNumberOfYears { get; set; }
    }

    public class ApproveRegisterMusatahaContract
    {
        [JsonPropertyName("backOfficeResponse")]
        public string BackOfficeResponse { get; set; }

        [JsonPropertyName("isShouldPayFines")]
        public bool IsShouldPayFines { get; set; }

        [JsonPropertyName("isSchoolFees")]
        public bool IsSchoolFees { get; set; }
    }
}