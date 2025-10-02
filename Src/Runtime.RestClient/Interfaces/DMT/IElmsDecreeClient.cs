using ADREC.DTO.RestClientModels.DMT.ElmsDecree;
using ErrorOr;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsDecree;
using System.Net;

namespace Runtime.RestClient.Interfaces.DMT
{
    public interface IElmsDecreeClient
    {
        Task<ErrorOr<DmtResponseWrapper<AllotmentOrderResponse>>> FetchAllotmentName(List<Cookie> cookies, string args, int id);

        Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<OwnerAllotmentNameResponse>>>> SearchOwnerAllotmentName(
            List<Cookie> cookies, string args, string cityNo, string familyBookNumber, string fullName,
            string matchTypeId, string nationalNumber, int pageNumber, int pageSize, int totalCount, string tribe);
    }
}