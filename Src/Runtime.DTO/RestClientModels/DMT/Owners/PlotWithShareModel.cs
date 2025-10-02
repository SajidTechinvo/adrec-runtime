using ADREC.DTO.RestClientModels.DMT.Plots;
using Runtime.DTO.RestClientModels.DMT.Owners;
using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Owners
{
    public class PlotWithShareResponse
    {
        [JsonPropertyName("owner")]
        public PlotOwnerResponse Owner { get; set; }

        [JsonPropertyName("ownerPlots")]
        public List<PlotDetailResponse> OwnerPlots { get; set; }

        [JsonPropertyName("ownerBlocks")]
        public List<object> OwnerBlocks { get; set; }

        [JsonPropertyName("businessEntityBlocks")]
        public List<object> BusinessEntityBlocks { get; set; }
    }
}