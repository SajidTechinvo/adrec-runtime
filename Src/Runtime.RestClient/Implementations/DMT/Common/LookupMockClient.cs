using ADREC.DTO.ApiModels.DMTModel.Common;
using ADREC.DTO.RestClientModels.DMT.Lookup;
using ErrorOr;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Lookup;
using Runtime.RestClient.Interfaces.DMT.Common;
using System.Net;
using System.Text.Json;

namespace ADREC.RestClient.Implementations.DMT.Common
{
    internal class LookupMockClient : ILookupClient
    {
        #region Private Methods

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "Lookup", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Methods

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<List<DistrictResponse>>>> SearchDistricts(List<Cookie> cookies, long id)
        {
            var content = await GetFileContent("District.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<DistrictResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<LandUsageResponse>>>> SearchLandUsage(List<Cookie> cookies, long id, int? request_id)
        {
            var content = await GetFileContent("LandUsage.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<LandUsageResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<LandUsageByIdResponse>>>> FetchLanduseById(List<Cookie> cookies, long id, int? request_id)
        {
            var content = await GetFileContent("LandUsageById.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<LandUsageByIdResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<MunicipalityResponse>>>> SearchMunicipalities(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("Municipality.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<MunicipalityResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<CommunityResponse>>>> SearchCommunities(List<Cookie> cookies, long id)
        {
            var content = await GetFileContent("Community.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<CommunityResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<RoadResponse>>>> SearchRoads(List<Cookie> cookies, long id)
        {
            var content = await GetFileContent("Roads.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<RoadResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<NationalityResponse>>>> SearchNationalities(List<Cookie> cookies, string args, long id)
        {
            var content = await GetFileContent("Nationality.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<NationalityResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<AmountInWordResponse>>> GetAmountInWords(List<Cookie> cookies, decimal value)
        {
            var content = await GetFileContent("AmountInWords.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<AmountInWordResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<MasterConstResponse>>>> GetMasterConst(List<Cookie> cookies, string @const)
        {
            var content = await GetFileContent("MasterConst.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<MasterConstResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<PlotAllocationTypeResponse>>>> GetPlotAllocationTypes(List<Cookie> cookies)
        {
            var content = await GetFileContent("PlotAllocationType.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<PlotAllocationTypeResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<JoinedLandUsageResponse>>>> GetJoinedLandUsage(List<Cookie> cookies, long id)
        {
            var content = await GetFileContent("JoinedLandUsage.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<JoinedLandUsageResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<AppraisalValueTypeModel>>>> GetAppraisalValueTypes(List<Cookie> cookies)
        {
            var content = await GetFileContent("AppraisalValueType.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<AppraisalValueTypeModel>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<WorkflowStepTypeResponse>>>> GetWorkflowStepType(List<Cookie> cookies)
        {
            var content = await GetFileContent("WorkflowStepType.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<WorkflowStepTypeResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<UserMunicipalityModel>>>> GetUserMunicipality(List<Cookie> cookies)
        {
            var content = await GetFileContent("UserMunicipality.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<UserMunicipalityModel>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<WorkflowResponse>>>> GetWorkflows(List<Cookie> cookies)
        {
            var content = await GetFileContent("Workflow.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<WorkflowResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<ResidentialLandJoinedLandUseResponse>>>> ResidentialLandJoinedLandUse(List<Cookie> cookies, string args, long id)
        {
            var content = await GetFileContent("ResidentialLandJoinedLandUse.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<ResidentialLandJoinedLandUseResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<object>>> GetRejectionReasons(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("RejectionReasons.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<object>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<EmirateResponse>>>> SearchEmirates(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("Emirates.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<EmirateResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<MasterConstResponse>>>> GetUnifiedRejectionReasons(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("UnifiedRejectionReasons.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<MasterConstResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<UnitClassificationResponse>>>> SearchUnitClassifications(List<Cookie> cookies, string args, long requestId)
        {
            var content = await GetFileContent("SearchUnitClassifications.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<UnitClassificationResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<FetchSurveyReasonTypesResponse>>>> FetchSurveyReasonTypes(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("FetchSurveyReasonTypes.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<FetchSurveyReasonTypesResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<FetchWorkflowFeesResponse>>>> FetchWorkflowFees(List<Cookie> cookies, string args, long id)
        {
            var content = await GetFileContent("FetchWorkflowFees.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<FetchWorkflowFeesResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<FetchSurveyReasonRequesterTypesResponse>>>> FetchSurveyReasonRequesterTypes(List<Cookie> cookies, string args, long id)
        {
            var content = await GetFileContent("FetchSurveyReasonRequesterTypes.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<FetchSurveyReasonRequesterTypesResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<FetchAuthoritySourceTypeResponse>>>> FetchAuthoritySourceTypeLookups(List<Cookie> cookies, string args, long requestId)
        {
            var content = await GetFileContent("FetchAuthoritySourceTypeLookups.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<FetchAuthoritySourceTypeResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<FetchAuthoritySourcesByAuthoritySourceTypeIdResponse>>>> FetchAuthoritySourcesByAuthoritySourceTypeId(List<Cookie> cookies, string args, FetchAuthoritySourcesByAuthoritySourceTypeIdRequest model)
        {
            var content = await GetFileContent("FetchAuthoritySourcesByAuthoritySourceTypeId.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<FetchAuthoritySourcesByAuthoritySourceTypeIdResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<FetchCommentTypeResponse>>>> FetchCommentTypes(List<Cookie> cookies, string args, long requestId)
        {
            var content = await GetFileContent("ManagePlotComment.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<FetchCommentTypeResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<InsuranceCompanyResponse>>>> SearchInsuranceCompany(List<Cookie> cookies, int? request_id)
        {
            var content = await GetFileContent("InsuranceCompanies.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<InsuranceCompanyResponse>>>(content);
        }

        #endregion Methods
    }
}