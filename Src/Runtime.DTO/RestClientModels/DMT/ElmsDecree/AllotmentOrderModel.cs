using ADREC.DTO.RestClientModels.DMT.Lookup;
using Runtime.DTO.RestClientModels.DMT.ElmsDecree;
using Runtime.DTO.RestClientModels.DMT.Lookup;
using System.Text.Json.Serialization;

namespace ADREC.DTO.RestClientModels.DMT.ElmsDecree
{
    public class AllotmentOrderResponse
    {
        [JsonPropertyName("acknowledgeDate")]
        public object AcknowledgeDate { get; set; }

        [JsonPropertyName("allotmentLetterId")]
        public int AllotmentLetterId { get; set; }

        [JsonPropertyName("allotmentNameGuid")]
        public string AllotmentNameGuid { get; set; }

        [JsonPropertyName("allotmentNameId")]
        public int AllotmentNameId { get; set; }

        [JsonPropertyName("applicantType")]
        public string ApplicantType { get; set; }

        [JsonPropertyName("birthday")]
        public object Birthday { get; set; }

        [JsonPropertyName("birthLocation")]
        public string BirthLocation { get; set; }

        [JsonPropertyName("chamberNumberId")]
        public string ChamberNumberId { get; set; }

        [JsonPropertyName("cityNo")]
        public string CityNo { get; set; }

        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        [JsonPropertyName("communityId")]
        public int CommunityId { get; set; }

        [JsonPropertyName("dbComments")]
        public string DbComments { get; set; }

        [JsonPropertyName("decreeOrder")]
        public double DecreeOrder { get; set; }

        [JsonPropertyName("districtId")]
        public int DistrictId { get; set; }

        [JsonPropertyName("documentId")]
        public object DocumentId { get; set; }

        [JsonPropertyName("familyBookNumber")]
        public string FamilyBookNumber { get; set; }

        [JsonPropertyName("familyPageNumber")]
        public string FamilyPageNumber { get; set; }

        [JsonPropertyName("holdByUserId")]
        public object HoldByUserId { get; set; }

        [JsonPropertyName("holdComments")]
        public string HoldComments { get; set; }

        [JsonPropertyName("holdDate")]
        public DateTime? HoldDate { get; set; }

        [JsonPropertyName("homePhoneNo")]
        public string HomePhoneNo { get; set; }

        [JsonPropertyName("isForPersonalUse")]
        public int IsForPersonalUse { get; set; }

        [JsonPropertyName("isRegardless")]
        public object IsRegardless { get; set; }

        [JsonPropertyName("isRentable")]
        public int IsRentable { get; set; }

        [JsonPropertyName("isSellable")]
        public int IsSellable { get; set; }

        [JsonPropertyName("landuseId")]
        public int LanduseId { get; set; }

        [JsonPropertyName("locationDescription")]
        public string LocationDescription { get; set; }

        [JsonPropertyName("migNote")]
        public double? MigNote { get; set; }

        [JsonPropertyName("migNoteL")]
        public string MigNoteL { get; set; }

        [JsonPropertyName("migNoteLm")]
        public string MigNoteLm { get; set; }

        [JsonPropertyName("mobileNo")]
        public string MobileNo { get; set; }

        [JsonPropertyName("municipalityId")]
        public int MunicipalityId { get; set; }

        [JsonPropertyName("nationalIdNumber")]
        public string NationalIdNumber { get; set; }

        [JsonPropertyName("ownerLetterName")]
        public string OwnerLetterName { get; set; }

        [JsonPropertyName("ownerLetterTitle")]
        public string OwnerLetterTitle { get; set; }

        [JsonPropertyName("ownerLetterTribe")]
        public string OwnerLetterTribe { get; set; }

        [JsonPropertyName("passportNumber")]
        public string PassportNumber { get; set; }

        [JsonPropertyName("plotId")]
        public object PlotId { get; set; }

        [JsonPropertyName("plotNumber")]
        public string PlotNumber { get; set; }

        [JsonPropertyName("poBox")]
        public string PoBox { get; set; }

        [JsonPropertyName("referenceNumber")]
        public string ReferenceNumber { get; set; }

        [JsonPropertyName("roadId")]
        public int RoadId { get; set; }

        [JsonPropertyName("roadName")]
        public string RoadName { get; set; }

        [JsonPropertyName("smarthubAssignedPlotId")]
        public object SmarthubAssignedPlotId { get; set; }

        [JsonPropertyName("stopByUserId")]
        public object StopByUserId { get; set; }

        [JsonPropertyName("stopComments")]
        public string StopComments { get; set; }

        [JsonPropertyName("stopDate")]
        public DateTime? StopDate { get; set; }

        [JsonPropertyName("tradeLicenseNumber")]
        public string TradeLicenseNumber { get; set; }

        [JsonPropertyName("workPhoneNo")]
        public string WorkPhoneNo { get; set; }

        [JsonPropertyName("municipality")]
        public MunicipalityResponse Municipality { get; set; }

        [JsonPropertyName("landUse")]
        public LandUsageResponse LandUse { get; set; }

        [JsonPropertyName("community")]
        public CommunityResponse Community { get; set; }

        [JsonPropertyName("district")]
        public DistrictResponse District { get; set; }

        [JsonPropertyName("road")]
        public RoadResponse Road { get; set; }

        [JsonPropertyName("letterAllotment")]
        public LetterAllotmentResponse LetterAllotment { get; set; }

        [JsonPropertyName("decree")]
        public DecreeResponse Decree { get; set; }

        [JsonPropertyName("conditions")]
        public string Conditions { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("stopDateFormat")]
        public object StopDateFormat { get; set; }

        [JsonPropertyName("duplicateOwnerAllotmentOrder")]
        public bool DuplicateOwnerAllotmentOrder { get; set; }

        [JsonPropertyName("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }
    }
}