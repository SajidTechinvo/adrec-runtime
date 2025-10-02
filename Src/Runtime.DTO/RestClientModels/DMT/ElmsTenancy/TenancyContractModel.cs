using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsTenancy
{
    public class TenancyContractResponse
    {
        [JsonPropertyName("activityTypeA")]
        public string ActivityTypeA { get; set; }

        [JsonPropertyName("annualTenancyAmount")]
        public double AnnualTenancyAmount { get; set; }

        [JsonPropertyName("annualTenancyAmountPerUnit")]
        public double AnnualTenancyAmountPerUnit { get; set; }

        [JsonPropertyName("approveByUserId")]
        public int? ApproveByUserId { get; set; }

        [JsonPropertyName("approveComment")]
        public string ApproveComment { get; set; }

        [JsonPropertyName("approveDate")]
        public DateTime? ApproveDate { get; set; }

        [JsonPropertyName("cancelByUserId")]
        public int? CancelByUserId { get; set; }

        [JsonPropertyName("cancelComment")]
        public string CancelComment { get; set; }

        [JsonPropertyName("cancelDate")]
        public DateTime? CancelDate { get; set; }

        [JsonPropertyName("contractDate")]
        public DateTime ContractDate { get; set; }

        [JsonPropertyName("contractNumber")]
        public string ContractNumber { get; set; }

        [JsonPropertyName("contractNumberOfYears")]
        public int? ContractNumberOfYears { get; set; }

        [JsonPropertyName("electricityNumber")]
        public string ElectricityNumber { get; set; }

        [JsonPropertyName("endDate")]
        public DateTime EndDate { get; set; }

        [JsonPropertyName("firstPaymentNoOfYears")]
        public int? FirstPaymentNoOfYears { get; set; }

        [JsonPropertyName("insuranceAmount")]
        public double? InsuranceAmount { get; set; }

        [JsonPropertyName("insuranceCompanyAddress")]
        public string InsuranceCompanyAddress { get; set; }

        [JsonPropertyName("insuranceCompanyEmirateId")]
        public object InsuranceCompanyEmirateId { get; set; }

        [JsonPropertyName("insuranceCompanyLicNumber")]
        public string InsuranceCompanyLicNumber { get; set; }

        [JsonPropertyName("insuranceCompanyNameA")]
        public string InsuranceCompanyNameA { get; set; }

        [JsonPropertyName("insuranceCompanyNameE")]
        public string InsuranceCompanyNameE { get; set; }

        [JsonPropertyName("isFirstYearFreeOfPayment")]
        public bool? IsFirstYearFreeOfPayment { get; set; }

        [JsonPropertyName("isRenew")]
        public bool IsRenew { get; set; }

        [JsonPropertyName("isRetired")]
        public bool? IsRetired { get; set; }

        [JsonPropertyName("isSocialCase")]
        public bool? IsSocialCase { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("plotId")]
        public int? PlotId { get; set; }

        [JsonPropertyName("plotTransactionId")]
        public int? PlotTransactionId { get; set; }

        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        [JsonPropertyName("requestLandClassificationId")]
        public int? RequestLandClassificationId { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("tenancyContractCategory")]
        public int? TenancyContractCategory { get; set; }

        [JsonPropertyName("tenancyContractClass")]
        public int? TenancyContractClass { get; set; }

        [JsonPropertyName("tenancyContractGuid")]
        public string TenancyContractGuid { get; set; }

        [JsonPropertyName("tenancyContractId")]
        public int? TenancyContractId { get; set; }

        [JsonPropertyName("tenancyContractType")]
        public int? TenancyContractType { get; set; }

        [JsonPropertyName("tenancyFirstRentAppPaymentId")]
        public int? TenancyFirstRentAppPaymentId { get; set; }

        [JsonPropertyName("tenancyInsuranceAppPaymentId")]
        public object TenancyInsuranceAppPaymentId { get; set; }

        [JsonPropertyName("terminationByUserId")]
        public object TerminationByUserId { get; set; }

        [JsonPropertyName("terminationComment")]
        public string TerminationComment { get; set; }

        [JsonPropertyName("terminationDate")]
        public object TerminationDate { get; set; }

        [JsonPropertyName("unitType")]
        public string UnitType { get; set; }

        [JsonPropertyName("wasteFeeAppPaymentId")]
        public object WasteFeeAppPaymentId { get; set; }

        [JsonPropertyName("insuranceCompanyEmirate")]
        public object InsuranceCompanyEmirate { get; set; }

        [JsonPropertyName("applicationPayment")]
        public object ApplicationPayment { get; set; }

        [JsonPropertyName("paymentExpiryDate")]
        public object PaymentExpiryDate { get; set; }

        [JsonPropertyName("gcsCheques")]
        public List<object> GcsCheques { get; set; }

        [JsonPropertyName("contractPayment")]
        public List<ContractPaymentResponse> ContractPayment { get; set; }

        [JsonPropertyName("contractDateFormat")]
        public string ContractDateFormat { get; set; }

        [JsonPropertyName("contractDuartion")]
        public int? ContractDuartion { get; set; }

        [JsonPropertyName("startDateFormat")]
        public string StartDateFormat { get; set; }

        [JsonPropertyName("endDateFormat")]
        public string EndDateFormat { get; set; }

        [JsonPropertyName("terminationDateFormat")]
        public string TerminationDateFormat { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("contractStatusValue")]
        public int? ContractStatusValue { get; set; }

        [JsonPropertyName("unitTypeValue")]
        public string UnitTypeValue { get; set; }

        [JsonPropertyName("annualTenancyAmountInWords")]
        public string AnnualTenancyAmountInWords { get; set; }

        [JsonPropertyName("ranchTenancyRegistrationFee")]
        public double? RanchTenancyRegistrationFee { get; set; }

        [JsonPropertyName("amountInWords")]
        public string AmountInWords { get; set; }

        [JsonPropertyName("totalContractAmount")]
        public double? TotalContractAmount { get; set; }

        [JsonPropertyName("ranchTenancyRegistrationFeeInWord")]
        public object RanchTenancyRegistrationFeeInWord { get; set; }

        [JsonPropertyName("ranchInsuranceFee")]
        public double? RanchInsuranceFee { get; set; }

        [JsonPropertyName("ranchInsuranceFeeInWord")]
        public object RanchInsuranceFeeInWord { get; set; }

        [JsonPropertyName("skipPayment")]
        public object SkipPayment { get; set; }

        [JsonPropertyName("isTerminated")]
        public object IsTerminated { get; set; }

        [JsonPropertyName("rentAmountFees")]
        public object RentAmountFees { get; set; }

        [JsonPropertyName("enableAnnualTenancyAmountPerUnit")]
        public bool EnableAnnualTenancyAmountPerUnit { get; set; }

        [JsonPropertyName("isRenewValue")]
        public int? IsRenewValue { get; set; }

        [JsonPropertyName("insuranceCompanyId")]
        public object InsuranceCompanyId { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}