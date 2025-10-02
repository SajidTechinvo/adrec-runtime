using Runtime.DTO.RestClientModels.Common;
using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsServices.Common
{
    public class PlotShareResponse
    {
        [JsonPropertyName("approveByUserId")]
        public int? ApproveByUserId { get; set; }

        [JsonPropertyName("approveComments")]
        public string ApproveComments { get; set; }

        [JsonPropertyName("approveDate")]
        public DateTime? ApproveDate { get; set; }

        [JsonPropertyName("isHistory")]
        public bool? IsHistory { get; set; }

        [JsonPropertyName("landFileNumber")]
        public string LandFileNumber { get; set; }

        [JsonPropertyName("mergeComments")]
        public string MergeComments { get; set; }

        [JsonPropertyName("migNote")]
        public double? MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public object MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public object MigNoteLm { get; set; }

        [JsonPropertyName("ownerId")]
        public int? OwnerId { get; set; }

        [JsonPropertyName("percentOwnership")]
        public double? PercentOwnership { get; set; }

        [JsonPropertyName("plotPartitionId")]
        public object PlotPartitionId { get; set; }

        [JsonPropertyName("plotTransactionId")]
        public int? PlotTransactionId { get; set; }

        [JsonPropertyName("plotTransactionTypeId")]
        public object PlotTransactionTypeId { get; set; }

        [JsonPropertyName("plotTransactionUserOwnerId")]
        public int? PlotTransactionUserOwnerId { get; set; }

        [JsonPropertyName("priorityValue")]
        public int? PriorityValue { get; set; }

        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        [JsonPropertyName("removeByUserId")]
        public object RemoveByUserId { get; set; }

        [JsonPropertyName("removeDate")]
        public object RemoveDate { get; set; }

        [JsonPropertyName("rightsHoldTypeId")]
        public int? RightsHoldTypeId { get; set; }

        [JsonPropertyName("shareSign")]
        public object ShareSign { get; set; }

        [JsonPropertyName("shareStatus")]
        public int? ShareStatus { get; set; }

        [JsonPropertyName("updateComments")]
        public string UpdateComments { get; set; }

        [JsonPropertyName("rightsHoldTypeNameA")]
        public string RightsHoldTypeNameA { get; set; }

        [JsonPropertyName("rightsHoldTypeNameE")]
        public string RightsHoldTypeNameE { get; set; }

        [JsonPropertyName("plotTransactionTypeNameA")]
        public string PlotTransactionTypeNameA { get; set; }

        [JsonPropertyName("plotTransactionTypeNameE")]
        public string PlotTransactionTypeNameE { get; set; }

        [JsonPropertyName("rightsHoldType")]
        public RightsHoldTypeResponse RightsHoldType { get; set; }

        [JsonPropertyName("acquisitionType")]
        public AcquisitionTypeResponse AcquisitionType { get; set; }

        [JsonPropertyName("share")]
        public object Share { get; set; }

        [JsonPropertyName("shareComments")]
        public object ShareComments { get; set; }

        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        [JsonPropertyName("totalPercentOwnership")]
        public double TotalPercentOwnership { get; set; }

        [JsonPropertyName("totalPercentOwnershipString")]
        public object TotalPercentOwnershipString { get; set; }

        [JsonPropertyName("owner")]
        public object Owner { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}