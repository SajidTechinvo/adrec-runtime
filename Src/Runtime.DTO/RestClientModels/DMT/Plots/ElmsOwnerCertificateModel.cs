using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.Plots
{
    public class ElmsOwnerCertificateResponse
    {
        [JsonPropertyName("approveByUserId")]
        public int? ApproveByUserId { get; set; }

        [JsonPropertyName("approveDate")]
        public DateTime? ApproveDate { get; set; }

        [JsonPropertyName("cancelByUserId")]
        public object CancelByUserId { get; set; }

        [JsonPropertyName("cancelComments")]
        public string CancelComments { get; set; }

        [JsonPropertyName("cancelDate")]
        public object CancelDate { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("deliverByUserId")]
        public int? DeliverByUserId { get; set; }

        [JsonPropertyName("deliverDate")]
        public DateTime? DeliverDate { get; set; }

        [JsonPropertyName("expirationDate")]
        public DateTime? ExpirationDate { get; set; }

        [JsonPropertyName("mergeComments")]
        public string MergeComments { get; set; }

        [JsonPropertyName("migNote")]
        public double? MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("municipalitiesFlags")]
        public int? MunicipalitiesFlags { get; set; }

        [JsonPropertyName("ownerCertificateCount")]
        public double OwnerCertificateCount { get; set; }

        [JsonPropertyName("ownerCertificateGuid")]
        public string OwnerCertificateGuid { get; set; }

        [JsonPropertyName("ownerCertificateId")]
        public int OwnerCertificateId { get; set; }

        [JsonPropertyName("ownerCertificateTypeId")]
        public int OwnerCertificateTypeId { get; set; }

        [JsonPropertyName("ownerCertPrintId")]
        public string OwnerCertPrintId { get; set; }

        [JsonPropertyName("ownerId")]
        public int OwnerId { get; set; }

        [JsonPropertyName("plotCertificateData")]
        public string PlotCertificateData { get; set; }

        [JsonPropertyName("printByUserId")]
        public int? PrintByUserId { get; set; }

        [JsonPropertyName("printDate")]
        public DateTime? PrintDate { get; set; }

        [JsonPropertyName("certificateTypeA")]
        public string CertificateTypeA { get; set; }

        [JsonPropertyName("certificateTypeE")]
        public string CertificateTypeE { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }
}