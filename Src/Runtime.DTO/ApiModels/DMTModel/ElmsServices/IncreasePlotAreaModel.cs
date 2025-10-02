using System.Text.Json.Serialization;

namespace ADREC.DTO.ApiModels.DMTModel.ElmsServices
{
    #region Register Submit Request

    public class IncreasePlotAreaRegisterRequest
    {
        [JsonPropertyName("referenceNumber")]
        public string ReferenceNumber { get; set; }

        [JsonPropertyName("requestedAreaDetails")]
        public string RequestedAreaDetails { get; set; }

        [JsonPropertyName("isSkipPayment")]
        public string IsSkipPayment { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }
    }

    #endregion Register Submit Request

    #region Assign Engineer Submit Response

    public class IncreasePlotAreaAssignEngineerRequest
    {
        [JsonPropertyName("engineerUserId")]
        public string EngineerUserId { get; set; }

        [JsonPropertyName("backOfficeResponse")]
        public string BackOfficeResponse { get; set; }
    }

    #endregion Assign Engineer Submit Response

    public class IncreasePlotAreaStudyRequest
    {
        [JsonPropertyName("grantedAreaDetails")]
        public string GrantedAreaDetails { get; set; }

        [JsonPropertyName("areaUnit")]
        public string AreaUnit { get; set; }

        [JsonPropertyName("extendedArea")]
        public string ExtendedArea { get; set; }

        [JsonPropertyName("backOfficeResponse")]
        public string BackOfficeResponse { get; set; }

        [JsonPropertyName("isEngineerChanged")]
        public bool IsEngineerChanged { get; set; }
    }

    public class IncreasePlotAreaEvaluationRequest
    {
        [JsonPropertyName("areaUnitPrice")]
        public string AreaUnitPrice { get; set; }

        [JsonPropertyName("isSkipPayment")]
        public string IsSkipPayment { get; set; }

        [JsonPropertyName("backOfficeResponse")]
        public string BackOfficeResponse { get; set; }

        [JsonPropertyName("extendedAreaPrice")]
        public string ExtendedAreaPrice { get; set; }

        [JsonPropertyName("extendedAreaPriceWordAmount")]
        public string ExtendedAreaPriceWordAmount { get; set; }
    }
}