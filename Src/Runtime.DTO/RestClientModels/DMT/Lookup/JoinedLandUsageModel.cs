using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Lookup
{
    public class JoinedLandUsageResponse
    {
        [JsonPropertyName("buildingPercent")]
        public double BuildingPercent { get; set; }

        [JsonPropertyName("businessFlags")]
        public int? BusinessFlags { get; set; }

        [JsonPropertyName("colorCode")]
        public string ColorCode { get; set; }

        [JsonPropertyName("landuseConst")]
        public string LanduseConst { get; set; }

        [JsonPropertyName("landuseId")]
        public int LanduseId { get; set; }

        [JsonPropertyName("landuseNameA")]
        public string LanduseNameA { get; set; }

        [JsonPropertyName("landuseNameE")]
        public string LanduseNameE { get; set; }

        [JsonPropertyName("lucCode")]
        public string LucCode { get; set; }

        [JsonPropertyName("mepsIdentifier")]
        public string MepsIdentifier { get; set; }

        [JsonPropertyName("migNote")]
        public double? MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("municipalityId")]
        public int MunicipalityId { get; set; }

        [JsonPropertyName("parentLanduseId")]
        public int ParentLanduseId { get; set; }

        [JsonPropertyName("joinedLandUseA")]
        public string JoinedLandUseA { get; set; }

        [JsonPropertyName("joinedLandUseE")]
        public string JoinedLandUseE { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}