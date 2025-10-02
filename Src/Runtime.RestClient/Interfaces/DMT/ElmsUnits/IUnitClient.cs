using ErrorOr;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Units;
using System.Net;

namespace Runtime.RestClient.Interfaces.DMT.ElmsUnits
{
    public interface IUnitClient
    {
        Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<UnitResponse>>>> SearchUnits(
            List<Cookie> cookies, string args, int requestId, string createUrlArgs, string municipalityId,
            string districtId, string communityId, string roadId, string plotNumber, string landuseId,
            string buildingNumber, string flourNumber, string unitNumber, string unitClassificationId,
            MatchType matchTypeId, int pageSize, string searchPlotFlags, string searchOwnerFlags, string ownerId,
            int pageNumber, int totalCount);

        Task<ErrorOr<DmtResponseWrapper<UnitDetailResponse>>> GetUnitDetails(List<Cookie> cookies, string args, long id);
    }
}