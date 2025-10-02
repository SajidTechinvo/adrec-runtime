using ADREC.DTO.RestClientModels.DMT.ElmsTenancy;
using ErrorOr;
using Runtime.DTO.ApiModels.DMTModel.ElmsTenancy;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsTenancy;
using System.Net;

namespace Runtime.RestClient.Interfaces.DMT.ElmsTenancy
{
    public interface IElmsTenancyClient
    {
        Task<ErrorOr<DmtResponseWrapper<CalculateRentFeesResponse>>> CalculateRentFees(List<Cookie> cookies, string args, CalculateRentFeesRequest model);

        Task<ErrorOr<DmtResponseWrapper<List<LateRentPaymentResponse>>>> FetchLandLateRentPayments(List<Cookie> cookies, string args, int id);

        Task<ErrorOr<DmtResponseWrapper<List<TenancyContractResponse>>>> FetchTenancyContractList(List<Cookie> cookies, string args, int plotId, bool showAll, int tenancyContractCategory);

        Task<ErrorOr<DmtResponseWrapper<TenancyContractResponse>>> FetchTenancyContractDetails(List<Cookie> cookies, string args, int id);

        Task<ErrorOr<DmtResponseWrapper<SearchTenancyContractResponse>>> SearchTenancyContracts(
            List<Cookie> cookies, string args, string contractNumber, string contractType, string matchTypeId,
            int pageNumber, int pageSize, string startDate);
    }
}