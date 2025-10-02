using ADREC.DTO.ApiModels.DMTModel.Common;
using ADREC.DTO.RestClientModels.DMT.Lookup;
using ErrorOr;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Lookup;
using System.Net;

namespace Runtime.RestClient.Interfaces.DMT.Common
{
    public interface ILookupClient
    {
        Task<ErrorOr<DmtResponseWrapper<List<InsuranceCompanyResponse>>>> SearchInsuranceCompany(List<Cookie> cookies, int? request_id);

        Task<ErrorOr<DmtResponseWrapper<AmountInWordResponse>>> GetAmountInWords(List<Cookie> cookies, decimal value);

        Task<ErrorOr<DmtResponseWrapper<List<AppraisalValueTypeModel>>>> GetAppraisalValueTypes(List<Cookie> cookies);

        Task<ErrorOr<DmtResponseWrapper<List<CommunityResponse>>>> SearchCommunities(List<Cookie> cookies, long id);

        Task<ErrorOr<DmtResponseWrapper<List<DistrictResponse>>>> SearchDistricts(List<Cookie> cookies, long id);

        Task<ErrorOr<DmtResponseWrapper<List<FetchAuthoritySourcesByAuthoritySourceTypeIdResponse>>>> FetchAuthoritySourcesByAuthoritySourceTypeId(List<Cookie> cookies, string args, FetchAuthoritySourcesByAuthoritySourceTypeIdRequest model);

        Task<ErrorOr<DmtResponseWrapper<List<FetchAuthoritySourceTypeResponse>>>> FetchAuthoritySourceTypeLookups(List<Cookie> cookies, string args, long requestId);

        Task<ErrorOr<DmtResponseWrapper<List<FetchCommentTypeResponse>>>> FetchCommentTypes(List<Cookie> cookies, string args, long requestId);

        Task<ErrorOr<DmtResponseWrapper<List<FetchSurveyReasonRequesterTypesResponse>>>> FetchSurveyReasonRequesterTypes(List<Cookie> cookies, string args, long id);

        Task<ErrorOr<DmtResponseWrapper<List<FetchSurveyReasonTypesResponse>>>> FetchSurveyReasonTypes(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<List<FetchWorkflowFeesResponse>>>> FetchWorkflowFees(List<Cookie> cookies, string args, long id);

        Task<ErrorOr<DmtResponseWrapper<List<JoinedLandUsageResponse>>>> GetJoinedLandUsage(List<Cookie> cookies, long id);

        Task<ErrorOr<DmtResponseWrapper<List<LandUsageByIdResponse>>>> FetchLanduseById(List<Cookie> cookies, long id, int? request_id);

        Task<ErrorOr<DmtResponseWrapper<List<LandUsageResponse>>>> SearchLandUsage(List<Cookie> cookies, long id, int? request_id);

        Task<ErrorOr<DmtResponseWrapper<List<MasterConstResponse>>>> GetMasterConst(List<Cookie> cookies, string @const);

        Task<ErrorOr<DmtResponseWrapper<List<MasterConstResponse>>>> GetUnifiedRejectionReasons(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<List<MunicipalityResponse>>>> SearchMunicipalities(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<List<NationalityResponse>>>> SearchNationalities(List<Cookie> cookies, string args, long id);

        Task<ErrorOr<DmtResponseWrapper<List<PlotAllocationTypeResponse>>>> GetPlotAllocationTypes(List<Cookie> cookies);

        Task<ErrorOr<DmtResponseWrapper<List<ResidentialLandJoinedLandUseResponse>>>> ResidentialLandJoinedLandUse(List<Cookie> cookies, string args, long id);

        Task<ErrorOr<DmtResponseWrapper<List<RoadResponse>>>> SearchRoads(List<Cookie> cookies, long id);

        Task<ErrorOr<DmtResponseWrapper<List<UnitClassificationResponse>>>> SearchUnitClassifications(List<Cookie> cookies, string args, long requestId);

        Task<ErrorOr<DmtResponseWrapper<List<UserMunicipalityModel>>>> GetUserMunicipality(List<Cookie> cookies);

        Task<ErrorOr<DmtResponseWrapper<List<WorkflowResponse>>>> GetWorkflows(List<Cookie> cookies);

        Task<ErrorOr<DmtResponseWrapper<List<WorkflowStepTypeResponse>>>> GetWorkflowStepType(List<Cookie> cookies);

        Task<ErrorOr<DmtResponseWrapper<object>>> GetRejectionReasons(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<List<EmirateResponse>>>> SearchEmirates(List<Cookie> cookies, string args);
    }
}