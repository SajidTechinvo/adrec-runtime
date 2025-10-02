using ADREC.DTO.RestClientModels.DMT.Owners;
using ErrorOr;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Owners;
using System.Net;

namespace ADREC.RestClient.Interfaces.DMT.Common
{
    public interface IOwnerClient
    {
        Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<OwnerResponse>>>> GetOwners(List<Cookie> cookies, string args, int requestId,
            string ownerName, string tribe, string nationalNumber, string nationalityId, string familyBookNumber,
            string cityNumber, string passPortNumber, string moiUnifiedNumber, string matchTypeId, int pageSize,
            int pageNumber, int totalCount);

        Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<CompanyResponse>>>> GetCompanies(
            List<Cookie> cookies, string args, string chamberOfCommerceNo, string matchTypeId, string ownerName, int pageNumber,
            int pageSize, int requestId, int totalCount, string tradeLicense);

        Task<ErrorOr<DmtResponseWrapper<List<PlotOwnerResponse>>>> SearchAuthorizedOwners(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<OwnerPlotResponse>>> OwnerPlots(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<PlotWithShareResponse>>> GetOwnerProfilePlotsWithShares(List<Cookie> cookies, string args, int id);
    }
}