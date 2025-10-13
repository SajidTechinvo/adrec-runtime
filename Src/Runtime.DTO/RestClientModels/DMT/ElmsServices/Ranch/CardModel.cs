using System.Text.Json.Serialization;

namespace Runtime.DTO.RestClientModels.DMT.ElmsServices.Ranch
{
    public class RanchCardActionUser
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

    public class RanchCardApplication
    {
        [JsonPropertyName("applicationId")]
        public int ApplicationId { get; set; }

        [JsonPropertyName("applicationNumber")]
        public string ApplicationNumber { get; set; }

        [JsonPropertyName("applicationCreatedDate")]
        public string ApplicationCreatedDate { get; set; }

        [JsonPropertyName("applicationReferenceNumber")]
        public object ApplicationReferenceNumber { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }

    public class RanchCardOwnersList
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

    public class RanchCardPlot
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

    public class RanchCardResponse
    {
        [JsonPropertyName("application")]
        public RanchCardApplication Application { get; set; }

        [JsonPropertyName("municipalityNameE")]
        public string MunicipalityNameE { get; set; }

        [JsonPropertyName("municipalityNameA")]
        public string MunicipalityNameA { get; set; }

        [JsonPropertyName("requestTypeE")]
        public string RequestTypeE { get; set; }

        [JsonPropertyName("requestTypeA")]
        public string RequestTypeA { get; set; }

        [JsonPropertyName("ranchTypeE")]
        public string RanchTypeE { get; set; }

        [JsonPropertyName("ranchTypeA")]
        public string RanchTypeA { get; set; }

        [JsonPropertyName("daysRemaining")]
        public int? DaysRemaining { get; set; }

        [JsonPropertyName("highestPriorityOwnerId")]
        public int? HighestPriorityOwnerId { get; set; }

        [JsonPropertyName("plot")]
        public RanchCardPlot Plot { get; set; }

        [JsonPropertyName("ownersList")]
        public List<RanchCardOwnersList> OwnersList { get; set; }

        [JsonPropertyName("steps")]
        public List<RanchCardStep> Steps { get; set; }
    }

    public class RanchCardStep
    {
        [JsonPropertyName("stepConst")]
        public string StepConst { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("actionDate")]
        public string ActionDate { get; set; }

        [JsonPropertyName("actionUser")]
        public RanchCardActionUser ActionUser { get; set; }

        [JsonPropertyName("actionUserRole")]
        public object ActionUserRole { get; set; }
    }


}