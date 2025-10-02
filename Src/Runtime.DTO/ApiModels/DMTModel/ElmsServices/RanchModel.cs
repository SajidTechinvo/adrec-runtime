using Runtime.DTO.ApiModels.Common;
using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.DMTModel.ElmsServices
{
    public class RanchLandClassificationRequest
    {
        [JsonPropertyName("municipalityId")]
        public int MunicipalityId { get; set; }

        [JsonPropertyName("requestTypeId")]
        public string RequestTypeId { get; set; }

        [JsonPropertyName("checkSweihanRanch")]
        public bool CheckSweihanRanch { get; set; }
    }

    public class AddRecipientRequest
    {
        [JsonPropertyName("OwnerIdList")]
        public List<long> OwnerIdList { get; set; }
    }

    public class StartRanchWorkflowRequest
    {
        [JsonPropertyName("_check0")]
        public string Check { get; set; }

        [JsonPropertyName("municipalityId")]
        public string MunicipalityId { get; set; }

        [JsonPropertyName("acceptServiceConditions")]
        public string AcceptServiceConditions { get; set; }
    }

    #region Submit Ranch Request

    public class RanchRequestUser
    {
        [JsonPropertyName("ownerId")]
        public int OwnerId { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("priorityValue")]
        public string PriorityValue { get; set; }
    }

    public class RanchRegistrationSubmitRequest
    {
        [JsonPropertyName("ranchAllotmentRequestTypeId")]
        public string RanchAllotmentRequestTypeId { get; set; }

        [JsonPropertyName("requestlandClassificationId")]
        public string RequestlandClassificationId { get; set; }

        [JsonPropertyName("requestorIncome")]
        public string RequestorIncome { get; set; }

        [JsonPropertyName("requestorFamilyCount")]
        public string RequestorFamilyCount { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("isSocialCase")]
        public string IsSocialCase { get; set; }

        [JsonPropertyName("entities")]
        public List<RanchRequestUser> Entities { get; set; }
    }

    public class HoldApplicationRequest
    {
        [JsonPropertyName("value")]
        public bool Value { get; set; }

        [JsonPropertyName("backOfficeResponse")]
        public string BackOfficeResponse { get; set; }
    }

    public class RegistrationCancelRequest
    {
        [JsonPropertyName("backOfficeResponse")]
        public string BackOfficeResponse { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("isAuditorOverriden")]
        public string IsAuditorOverriden { get; set; }

        [JsonPropertyName("hideCancelBtn")]
        public string HideCancelBtn { get; set; }
    }

    public class AssignmentSubmitRequest
    {
        [JsonPropertyName("assignPlot")]
        public string AssignPlot { get; set; }

        [JsonPropertyName("authorizedOwnerId")]
        public string AuthorizedOwnerId { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("plotId")]
        public int PlotId { get; set; }
    }

    public class ApprovalSubmitRequest
    {
        [JsonPropertyName("signature")]
        public FileRequestModel Signature { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }
    }

    public class ApprovalRejectRequest
    {
        [JsonPropertyName("backOfficeResponse")]
        public string BackOfficeResponse { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }
    }

    public class BackRequest
    {
        [JsonPropertyName("backOfficeResponse")]
        public string BackOfficeResponse { get; set; }

        [JsonPropertyName("isAuditorOverriden")]
        public string IsAuditorOverriden { get; set; }

        [JsonPropertyName("hideCancelBtn")]
        public string HideCancelBtn { get; set; }
    }

    public class ConfirmCollectingPaymentsSubmitRequest
    {
        [JsonPropertyName("isSkipPayment")]
        public bool IsSkipPayment { get; set; }

        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        [JsonPropertyName("exemptSocialAssistanceRecipient")]
        public string ExemptSocialAssistanceRecipient { get; set; }

        [JsonPropertyName("electricityNumber")]
        public string ElectricityNumber { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("contractDuration")]
        public string ContractDuration { get; set; }

        [JsonPropertyName("contractNumber")]
        public string ContractNumber { get; set; }

        [JsonPropertyName("contractDate")]
        public DateTime ContractDate { get; set; }

        [JsonPropertyName("contractStartDate")]
        public string ContractStartDate { get; set; }

        [JsonPropertyName("contractEndDate")]
        public string ContractEndDate { get; set; }

        [JsonPropertyName("contractRegistrationFees")]
        public string ContractRegistrationFees { get; set; }

        [JsonPropertyName("contractAmountInWords")]
        public string ContractAmountInWords { get; set; }

        [JsonPropertyName("unitType")]
        public string UnitType { get; set; }

        [JsonPropertyName("tenancyContractType")]
        public string TenancyContractType { get; set; }

        [JsonPropertyName("annualTenancyAmountPerUnit")]
        public string AnnualTenancyAmountPerUnit { get; set; }

        [JsonPropertyName("annualTenancyAmount")]
        public string AnnualTenancyAmount { get; set; }

        [JsonPropertyName("annualRentFeesAmountInWords")]
        public string AnnualRentFeesAmountInWords { get; set; }

        [JsonPropertyName("insuranceFeeAmount")]
        public string InsuranceFeeAmount { get; set; }

        [JsonPropertyName("insuranceFeeAmountInWords")]
        public string InsuranceFeeAmountInWords { get; set; }

        [JsonPropertyName("isFirstYearFreeOfPayment")]
        public int IsFirstYearFreeOfPayment { get; set; }

        [JsonPropertyName("isInsurancePayment")]
        public int IsInsurancePayment { get; set; }

        [JsonPropertyName("isSocialCase")]
        public int IsSocialCase { get; set; }

        [JsonPropertyName("tenancyContractId")]
        public int TenancyContractId { get; set; }

        [JsonPropertyName("plotId")]
        public int PlotId { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("endDate")]
        public DateTime EndDate { get; set; }

        [JsonPropertyName("rentPaymentStartDate")]
        public DateTime RentPaymentStartDate { get; set; }

        [JsonPropertyName("rentPaymentEndDate")]
        public DateTime RentPaymentEndDate { get; set; }

        [JsonPropertyName("paymentAmount")]
        public double PaymentAmount { get; set; }
    }

    public class BackOfficePaymentSubmitRequest
    {
        [JsonPropertyName("comments")]
        public string Comments { get; set; }
    }

    #endregion Submit Ranch Request
}