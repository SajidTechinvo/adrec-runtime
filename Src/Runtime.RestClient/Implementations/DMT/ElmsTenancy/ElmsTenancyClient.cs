using ADREC.DTO.RestClientModels.DMT.ElmsTenancy;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.ApiModels.DMTModel.ElmsTenancy;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsTenancy;
using Runtime.RestClient.Interfaces.DMT.ElmsTenancy;
using System.Net;

namespace ADREC.RestClient.Implementations.DMT.ElmsTenancy
{
    internal class ElmsTenancyClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IElmsTenancyClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<CalculateRentFeesResponse>>> CalculateRentFees(List<Cookie> cookies, string args, CalculateRentFeesRequest model)
        {
            return await Post<DmtResponseWrapper<CalculateRentFeesResponse>, CalculateRentFeesRequest>(cookies, $"{_settings.BaseUrl}/api/ElmsTenancy/CalculateRentFees?args={args}", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<LateRentPaymentResponse>>>> FetchLandLateRentPayments(List<Cookie> cookies, string args, int id)
        {
            return await Post<DmtResponseWrapper<List<LateRentPaymentResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsTenancy/FetchLandLateRentPayments?args={args}", new { id });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<TenancyContractResponse>>>> FetchTenancyContractList(List<Cookie> cookies, string args, int plotId, bool showAll, int tenancyContractCategory)
        {
            return await Post<DmtResponseWrapper<List<TenancyContractResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsTenancy/FetchTenancyContractList?args={args}", new { plotId, showAll, tenancyContractCategory });
        }

        public async Task<ErrorOr<DmtResponseWrapper<TenancyContractResponse>>> FetchTenancyContractDetails(List<Cookie> cookies, string args, int id)
        {
            return await Post<DmtResponseWrapper<TenancyContractResponse>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsTenancy/FetchTenancyContractDetails?args={args}", new { id });
        }

        public async Task<ErrorOr<DmtResponseWrapper<SearchTenancyContractResponse>>> SearchTenancyContracts(
           List<Cookie> cookies, string args, string contractNumber, string contractType, string matchTypeId,
           int pageNumber, int pageSize, string startDate)
        {
            return await Post<DmtResponseWrapper<SearchTenancyContractResponse>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsTenancy/SearchTenancyContracts?args={args}", new
            {
                contractNumber,
                contractType,
                matchTypeId,
                pageNumber,
                pageSize,
                startDate
            });
        }

        #endregion Methods
    }
}