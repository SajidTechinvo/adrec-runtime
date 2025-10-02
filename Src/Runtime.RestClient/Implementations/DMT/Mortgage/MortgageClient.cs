using ADREC.DTO.RestClientModels.DMT.Mortgage;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Mortgage;
using Runtime.RestClient.Interfaces.DMT;
using System.Net;

namespace Runtime.RestClient.Implementations.DMT.Mortgage
{
    internal class MortgageClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IMortgageClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<ElmsBankResponse>>>> FetchBanks(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<DmtPageResponse<ElmsBankResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsMortgage/FetchBanks?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<FetchMortgageProfileResponse>>> FetchMortgageProfile(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<FetchMortgageProfileResponse>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsMortgage/FetchMortgageProfile?args={args}", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<SearchMortgageResponse>>> SearchMortgages(List<Cookie> cookies,
                                                                                         string args, string bankid,
                                                                                         string contractNumber,
                                                                                         bool createUrlArgs,
                                                                                         int matchTypeId,
                                                                                         string municipalityId,
                                                                                         int pageNumber, int pageSize,
                                                                                         int propertyType,
                                                                                         int resultsPerPage,
                                                                                         int totalCount)
        {
            return await Post<DmtResponseWrapper<SearchMortgageResponse>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsMortgage/SearchMortgages?args={args}", new
            {
                bankid,
                contractNumber,
                createUrlArgs,
                matchTypeId,
                municipalityId,
                pageNumber,
                pageSize,
                propertyType,
                resultsPerPage,
                totalCount
            });
        }

        #endregion Methods
    }
}