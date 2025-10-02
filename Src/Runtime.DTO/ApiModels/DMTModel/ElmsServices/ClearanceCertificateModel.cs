using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.DMTModel.ElmsServices
{
    public class StartClearanceCertificate
    {
        [JsonPropertyName("_check0")]
        public string Check0 { get; set; }

        [JsonPropertyName("acceptServiceConditions")]
        public string AcceptServiceConditions { get; set; }

        [JsonPropertyName("plotId")]
        public int PlotId { get; set; }
    }

    public class RegisterClearanceCertificate
    {
        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("constructioPermitsCert")]
        public string ConstructioPermitsCert { get; set; }

        [JsonPropertyName("townPlanningCert")]
        public string TownPlanningCert { get; set; }

        [JsonPropertyName("clearanceBuildingCert")]
        public bool ClearanceBuildingCert { get; set; }

        [JsonPropertyName("clearanceTownCert")]
        public bool ClearanceTownCert { get; set; }
    }
}