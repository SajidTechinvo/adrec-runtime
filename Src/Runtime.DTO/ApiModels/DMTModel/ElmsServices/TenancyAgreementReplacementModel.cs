using System.Text.Json.Serialization;

namespace ADREC.DTO.ApiModels.DMTModel.ElmsServices
{
    public class RegisterTenancyAgreementReplacement
    {
        [JsonPropertyName("skipPayment")]
        public string SkipPayment { get; set; }

        [JsonPropertyName("backOfficeResponse")]
        public string BackOfficeResponse { get; set; }
    }
}