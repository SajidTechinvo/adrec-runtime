using ADREC.DTO.ApiModels.DMTModel.Common;
using ADREC.DTO.RestClientModels.DMT.Lookup;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Lookup;
using Runtime.RestClient.Interfaces.DMT.Common;
using System.Net;

namespace Runtime.RestClient.Implementations.DMT.Common
{
    internal class LookupClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), ILookupClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        public async Task<ErrorOr<DmtResponseWrapper<List<MunicipalityResponse>>>> SearchMunicipalities(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<List<MunicipalityResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsLookup/SearchMunicipalities?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<ResidentialLandJoinedLandUseResponse>>>> ResidentialLandJoinedLandUse(List<Cookie> cookies, string args, long id)
        {
            return await Post<DmtResponseWrapper<List<ResidentialLandJoinedLandUseResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/elmsLookup/FetchResidentialLandJoinedLandUseLookups?args={args}", new { Id = id.ToString() });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<DistrictResponse>>>> SearchDistricts(List<Cookie> cookies, long id)
        {
            return await Post<DmtResponseWrapper<List<DistrictResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsLookup/searchDistricts", new { id = id.ToString() });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<LandUsageResponse>>>> SearchLandUsage(List<Cookie> cookies, long id, int? request_id)
        {
            return await Post<DmtResponseWrapper<List<LandUsageResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsLookup/searchLanduses", new { id = id.ToString(), request_id });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<LandUsageByIdResponse>>>> FetchLanduseById(List<Cookie> cookies, long id, int? request_id)
        {
            return await Post<DmtResponseWrapper<List<LandUsageByIdResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsLookup/FetchLanduseById", new { id });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<CommunityResponse>>>> SearchCommunities(List<Cookie> cookies, long id)
        {
            return await Post<DmtResponseWrapper<List<CommunityResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsLookup/searchCommunities", new { id = id.ToString() });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<RoadResponse>>>> SearchRoads(List<Cookie> cookies, long id)
        {
            return await Post<DmtResponseWrapper<List<RoadResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsLookup/searchRoads", new { id = id.ToString() });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<NationalityResponse>>>> SearchNationalities(List<Cookie> cookies, string args, long id)
        {
            return await Post<DmtResponseWrapper<List<NationalityResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/elmslookup/searchNationalities?args={args}", new { requestId = id });
        }

        public async Task<ErrorOr<DmtResponseWrapper<AmountInWordResponse>>> GetAmountInWords(List<Cookie> cookies, decimal value)
        {
            return await Post<DmtResponseWrapper<AmountInWordResponse>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsLookup/AmountInWords", new { value });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<MasterConstResponse>>>> GetMasterConst(List<Cookie> cookies, string @const)
        {
            return await Post<DmtResponseWrapper<List<MasterConstResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/lookup/GetLookupByMasterConst", new { Const = @const });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<PlotAllocationTypeResponse>>>> GetPlotAllocationTypes(List<Cookie> cookies)
        {
            return await Post<DmtResponseWrapper<List<PlotAllocationTypeResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/elmsLookup/FetchPlotAllocationTypes", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<JoinedLandUsageResponse>>>> GetJoinedLandUsage(List<Cookie> cookies, long id)
        {
            return await Post<DmtResponseWrapper<List<JoinedLandUsageResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/elmsLookup/FetchJoinedLandUseLookups", new { id });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<AppraisalValueTypeModel>>>> GetAppraisalValueTypes(List<Cookie> cookies)
        {
            return await Post<DmtResponseWrapper<List<AppraisalValueTypeModel>>, object>(cookies, $"{_settings.BaseUrl}/api/elmsLookup/FetchAppraisalValueTypeLookups", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<WorkflowStepTypeResponse>>>> GetWorkflowStepType(List<Cookie> cookies)
        {
            return await Post<DmtResponseWrapper<List<WorkflowStepTypeResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/lookup/searchWorkflowStepType", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<UserMunicipalityModel>>>> GetUserMunicipality(List<Cookie> cookies)
        {
            return await Post<DmtResponseWrapper<List<UserMunicipalityModel>>, object>(cookies, $"{_settings.BaseUrl}/api/lookup/getUserMunicipality", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<WorkflowResponse>>>> GetWorkflows(List<Cookie> cookies)
        {
            return await Post<DmtResponseWrapper<List<WorkflowResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/lookup/getWorkflows", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<object>>> GetRejectionReasons(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<object>, object>(cookies, $"{_settings.BaseUrl}/api/lookup/getRejectionReasons?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<MasterConstResponse>>>> GetUnifiedRejectionReasons(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<List<MasterConstResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/lookup/getWorkflows?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<UnitClassificationResponse>>>> SearchUnitClassifications(List<Cookie> cookies, string args, long requestId)
        {
            return await Post<DmtResponseWrapper<List<UnitClassificationResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/elmslookup/SearchUnitClassifications?args={args}", new { requestId });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<FetchSurveyReasonTypesResponse>>>> FetchSurveyReasonTypes(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<List<FetchSurveyReasonTypesResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/elmsLookup/FetchSurveyReasonTypes?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<FetchWorkflowFeesResponse>>>> FetchWorkflowFees(List<Cookie> cookies, string args, long id)
        {
            return await Post<DmtResponseWrapper<List<FetchWorkflowFeesResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/elmsLookup/FetchWorkflowFees?args={args}", new { id });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<FetchSurveyReasonRequesterTypesResponse>>>> FetchSurveyReasonRequesterTypes(List<Cookie> cookies, string args, long id)
        {
            return await Post<DmtResponseWrapper<List<FetchSurveyReasonRequesterTypesResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/elmsLookup/FetchSurveyReasonRequesterTypes?args={args}", new { id });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<FetchAuthoritySourceTypeResponse>>>> FetchAuthoritySourceTypeLookups(List<Cookie> cookies, string args, long requestId)
        {
            return await Post<DmtResponseWrapper<List<FetchAuthoritySourceTypeResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/elmslookup/FetchAuthoritySourceTypeLookups?args={args}", new { requestId });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<FetchAuthoritySourcesByAuthoritySourceTypeIdResponse>>>> FetchAuthoritySourcesByAuthoritySourceTypeId(List<Cookie> cookies, string args, FetchAuthoritySourcesByAuthoritySourceTypeIdRequest model)
        {
            return await Post<DmtResponseWrapper<List<FetchAuthoritySourcesByAuthoritySourceTypeIdResponse>>, FetchAuthoritySourcesByAuthoritySourceTypeIdRequest>(cookies, $"{_settings.BaseUrl}/api/elmslookup/FetchAuthoritySourcesByAuthoritySourceTypeId?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<FetchCommentTypeResponse>>>> FetchCommentTypes(List<Cookie> cookies, string args, long requestId)
        {
            return await Post<DmtResponseWrapper<List<FetchCommentTypeResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/elmslookup/fetchCommentTypes?args={args}", new { requestId });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<InsuranceCompanyResponse>>>> SearchInsuranceCompany(List<Cookie> cookies, int? request_id)
        {
            return await Post<DmtResponseWrapper<List<InsuranceCompanyResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/elmslookup/searchInsuranceCompany", new { requestId = request_id });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<EmirateResponse>>>> SearchEmirates(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<List<EmirateResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/lookup/searchEmirates?args={args}", new { });
        }
    }
}