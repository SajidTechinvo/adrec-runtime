using System.Text.Json.Serialization;

namespace ADREC.DTO.ApiModels.DMTModel.ElmsServices
{
    public class RegisterPlotDemarcationRequest
    {
        [JsonPropertyName("surveyReasonType")]
        public string SurveyReasonType { get; set; }

        [JsonPropertyName("surveyRequestorType")]
        public string SurveyRequestorType { get; set; }

        [JsonPropertyName("personName")]
        public string PersonName { get; set; }

        [JsonPropertyName("personPhoneNo")]
        public string PersonPhoneNo { get; set; }

        [JsonPropertyName("contractorCompanyName")]
        public string ContractorCompanyName { get; set; }

        [JsonPropertyName("contractorCompanyPhoneNo")]
        public string ContractorCompanyPhoneNo { get; set; }

        [JsonPropertyName("consultantCompanyName")]
        public string ConsultantCompanyName { get; set; }

        [JsonPropertyName("consultantCompanyPhoneNo")]
        public string ConsultantCompanyPhoneNo { get; set; }

        [JsonPropertyName("personDesignation")]
        public string PersonDesignation { get; set; }

        [JsonPropertyName("referenceNumber")]
        public string ReferenceNumber { get; set; }

        [JsonPropertyName("workflowfeeId")]
        public string WorkflowfeeId { get; set; }

        [JsonPropertyName("backOfficeResponse")]
        public string BackOfficeResponse { get; set; }

        [JsonPropertyName("surveyRequesterType")]
        public string SurveyRequesterType { get; set; }
    }

    public class PrintAppointmentSlipPlotDemarcationRequest
    {
        [JsonPropertyName("appointmentDate")]
        public DateTime AppointmentDate { get; set; }

        [JsonPropertyName("surveyTeamId")]
        public string SurveyTeamId { get; set; }

        [JsonPropertyName("municipalityBranchId")]
        public string MunicipalityBranchId { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }
    }

    public class AssignSurveyAppointmentSubmitPlotDemarcationRequest
    {
        [JsonPropertyName("appointmentDate")]
        public string AppointmentDate { get; set; }

        [JsonPropertyName("surveyTeamId")]
        public string SurveyTeamId { get; set; }

        [JsonPropertyName("municipalityBranchId")]
        public string MunicipalityBranchId { get; set; }

        [JsonPropertyName("backOfficeResponse")]
        public string BackOfficeResponse { get; set; }
    }
}