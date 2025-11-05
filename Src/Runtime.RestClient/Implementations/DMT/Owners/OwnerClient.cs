using ADREC.DTO.RestClientModels.DMT.Owners;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.DTO.ApiModels.DMTModel;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Owners;
using Runtime.RestClient.Implementations.Factory;
using Runtime.RestClient.Interfaces.DMT.Common;
using System.Net;

namespace Runtime.RestClient.Implementations.DMT.Owners
{
    internal class OwnerClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IOwnerClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<CompanyResponse>>>> GetCompanies(
            List<Cookie> cookies, string args, string chamberOfCommerceNo, string matchTypeId, string ownerName, int pageNumber,
            int pageSize, int requestId, int totalCount, string tradeLicense)
        {
            return await Post<DmtResponseWrapper<DmtPageResponse<CompanyResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsOwner/SearchCompanies?args={args}", new
            {
                chamberOfCommerceNo,
                matchTypeId,
                ownerName,
                pageNumber,
                pageSize,
                requestId,
                totalCount,
                tradeLicense
            });
        }

        public async Task<ErrorOr<DmtResponseWrapper<PlotWithShareResponse>>> GetOwnerProfilePlotsWithShares(List<Cookie> cookies, string args, int id)
        {
            return await Post<DmtResponseWrapper<PlotWithShareResponse>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsOwner/FetchOwnerProfilePlotsWithShares?args={args}", new { id });
        }

        public async Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<OwnerResponse>>>> GetOwners(List<Cookie> cookies, string args,
            int requestId, string ownerName, string tribe, string nationalNumber, string nationalityId,
            string familyBookNumber, string cityNumber, string passPortNumber, string moiUnifiedNumber,
            string matchTypeId, int pageSize, int pageNumber, int totalCount)
        {
            return await Post<DmtResponseWrapper<DmtPageResponse<OwnerResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsOwner/SearchOwners?args={args}", new
            {
                requestId,
                ownerName,
                tribe,
                nationalNumber,
                nationalityId,
                familyBookNumber,
                cityNumber,
                passPortNumber,
                moiUnifiedNumber,
                matchTypeId,
                pageSize,
                pageNumber,
                totalCount
            });
        }

        public async Task<ErrorOr<DmtResponseWrapper<OwnerPlotResponse>>> OwnerPlots(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<OwnerPlotResponse>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsOwner/FetchOwnerProfilePlots?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<PlotOwnerResponse>>>> SearchAuthorizedOwners(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<List<PlotOwnerResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsOwner/SearchAuthorizedOwners?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<EditContactResponse>>> EditContact(List<Cookie> cookies, EditContactRequest model)
        {
            return await Post<DmtResponseWrapper<EditContactResponse>, EditContactRequest>(cookies, $"{_settings.BaseUrl}/api/elmsOwner/EditContactRequest", model);
        }

        #endregion Methods
    }
}