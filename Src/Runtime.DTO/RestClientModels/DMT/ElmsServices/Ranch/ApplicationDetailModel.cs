using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.ElmsServices.Ranch
{
    public class ApplicationDetailActionUser
    {
        [JsonPropertyName("userNameE")]
        public string UserNameE { get; set; }

        [JsonPropertyName("userNameA")]
        public string UserNameA { get; set; }

        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        [JsonPropertyName("userEmail")]
        public string UserEmail { get; set; }

        [JsonPropertyName("userPhone")]
        public string UserPhone { get; set; }

        [JsonPropertyName("userGender")]
        public string UserGender { get; set; }
    }

    public class ApplicationDetailModel
    {
        [JsonPropertyName("applicationId")]
        public int ApplicationId { get; set; }

        [JsonPropertyName("applicationNumber")]
        public string ApplicationNumber { get; set; }

        [JsonPropertyName("applicationCreatedDate")]
        public object ApplicationCreatedDate { get; set; }

        [JsonPropertyName("applicationReferenceNumber")]
        public string ApplicationReferenceNumber { get; set; }

        [JsonPropertyName("urlArgs")]
        public object UrlArgs { get; set; }
    }

    public class AttachmentList
    {
        [JsonPropertyName("attachmentId")]
        public int AttachmentId { get; set; }

        [JsonPropertyName("documentId")]
        public int DocumentId { get; set; }

        [JsonPropertyName("attachmentTitle")]
        public string AttachmentTitle { get; set; }

        [JsonPropertyName("attachmentDate")]
        public string AttachmentDate { get; set; }

        [JsonPropertyName("downloadUrl")]
        public string DownloadUrl { get; set; }
    }

    public class ApplicationDetailDocument
    {
        [JsonPropertyName("documentNameA")]
        public string DocumentNameA { get; set; }

        [JsonPropertyName("documentNameE")]
        public string DocumentNameE { get; set; }

        [JsonPropertyName("attachmentList")]
        public List<AttachmentList> AttachmentList { get; set; }

        [JsonPropertyName("documentType")]
        public string DocumentType { get; set; }

        [JsonPropertyName("nonComplyNotes")]
        public object NonComplyNotes { get; set; }
    }

    public class ApplicationDetailOwner
    {
        [JsonPropertyName("ownerId")]
        public string OwnerId { get; set; }

        [JsonPropertyName("ownerNameE")]
        public string OwnerNameE { get; set; }

        [JsonPropertyName("ownerNameA")]
        public string OwnerNameA { get; set; }

        [JsonPropertyName("familyNameA")]
        public string FamilyNameA { get; set; }

        [JsonPropertyName("familyNameE")]
        public string FamilyNameE { get; set; }

        [JsonPropertyName("nationalId")]
        public string NationalId { get; set; }

        [JsonPropertyName("moiNumber")]
        public string MoiNumber { get; set; }

        [JsonPropertyName("archiveNumber")]
        public object ArchiveNumber { get; set; }

        [JsonPropertyName("nationalityE")]
        public object NationalityE { get; set; }

        [JsonPropertyName("nationalityA")]
        public object NationalityA { get; set; }

        [JsonPropertyName("specialNationality")]
        public object SpecialNationality { get; set; }

        [JsonPropertyName("cityE")]
        public string CityE { get; set; }

        [JsonPropertyName("cityA")]
        public string CityA { get; set; }

        [JsonPropertyName("propertyCard")]
        public string PropertyCard { get; set; }

        [JsonPropertyName("documents")]
        public object Documents { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }

    public class ApplicationDetailPlot
    {
        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("allocationTypeE")]
        public string AllocationTypeE { get; set; }

        [JsonPropertyName("allocationTypeA")]
        public string AllocationTypeA { get; set; }

        [JsonPropertyName("area")]
        public string Area { get; set; }

        [JsonPropertyName("communityNameE")]
        public string CommunityNameE { get; set; }

        [JsonPropertyName("communityNameA")]
        public string CommunityNameA { get; set; }

        [JsonPropertyName("constructionStatus")]
        public string ConstructionStatus { get; set; }

        [JsonPropertyName("districtNameE")]
        public string DistrictNameE { get; set; }

        [JsonPropertyName("districtNameA")]
        public string DistrictNameA { get; set; }

        [JsonPropertyName("expatOwnershipPercentage")]
        public string ExpatOwnershipPercentage { get; set; }

        [JsonPropertyName("municipalityNameE")]
        public string MunicipalityNameE { get; set; }

        [JsonPropertyName("municipalityNameA")]
        public string MunicipalityNameA { get; set; }

        [JsonPropertyName("investmentAreaNameE")]
        public string InvestmentAreaNameE { get; set; }

        [JsonPropertyName("investmentAreaNameA")]
        public string InvestmentAreaNameA { get; set; }

        [JsonPropertyName("landUseE")]
        public string LandUseE { get; set; }

        [JsonPropertyName("landUseA")]
        public string LandUseA { get; set; }

        [JsonPropertyName("plotId")]
        public string PlotId { get; set; }

        [JsonPropertyName("plotNumber")]
        public string PlotNumber { get; set; }

        [JsonPropertyName("plotFileNumber")]
        public object PlotFileNumber { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }

        [JsonPropertyName("owners")]
        public List<object> Owners { get; set; }
    }

    public class ApplicationDetailResponse
    {
        [JsonPropertyName("application")]
        public ApplicationDetailModel Application { get; set; }

        [JsonPropertyName("owners")]
        public List<ApplicationDetailOwner> Owners { get; set; }

        [JsonPropertyName("plot")]
        public ApplicationDetailPlot Plot { get; set; }

        [JsonPropertyName("steps")]
        public List<ApplicationDetailStep> Steps { get; set; }

        [JsonPropertyName("documents")]
        public List<ApplicationDetailDocument> Documents { get; set; }
    }

    public class ApplicationDetailStep
    {
        [JsonPropertyName("stepConst")]
        public string StepConst { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("actionDate")]
        public string ActionDate { get; set; }

        [JsonPropertyName("actionUser")]
        public ApplicationDetailActionUser ActionUser { get; set; }

        [JsonPropertyName("actionUserRole")]
        public string ActionUserRole { get; set; }
    }
}