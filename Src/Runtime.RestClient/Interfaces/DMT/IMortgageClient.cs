using ADREC.DTO.RestClientModels.DMT.Mortgage;
using ErrorOr;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Mortgage;
using System.Net;

namespace Runtime.RestClient.Interfaces.DMT
{
    public interface IMortgageClient
    {
        Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<ElmsBankResponse>>>> FetchBanks(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<FetchMortgageProfileResponse>>> FetchMortgageProfile(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<SearchMortgageResponse>>> SearchMortgages(List<Cookie> cookies, string args,
                                                                                  string bankid, string contractNumber,
                                                                                  bool createUrlArgs, int matchTypeId,
                                                                                  string municipalityId, int pageNumber,
                                                                                  int pageSize, int propertyType,
                                                                                  int resultsPerPage, int totalCount);
    }
}