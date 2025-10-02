using ADREC.DTO.ApiModels.DMTModel;
using ADREC.DTO.RestClientModels.DMT.Plots;
using ADREC.DTO.RestClientModels.DMT.Plots.Common;
using ErrorOr;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Owners;
using Runtime.DTO.RestClientModels.DMT.Plots;
using Runtime.DTO.RestClientModels.DMT.Units;
using System.Net;

namespace ADREC.RestClient.Interfaces.DMT.Common
{
    public interface IPlotClient
    {
        Task<ErrorOr<DmtResponseWrapper<FetchPlotProfileResponse>>> FetchPlotProfile(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<FetchPlotProfileServiceResponse>>>> FetchPlotProfileServices(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<GisPlotDetailResponse>>> GetGisPlotDetail(List<Cookie> cookies, long tpdPlotId, long municipalityId);

        Task<ErrorOr<DmtResponseWrapper<PlotDetailResponse>>> GetPlotDetails(List<Cookie> cookies, long id);

        Task<ErrorOr<DmtResponseWrapper<PlotOwnerResponse>>> GetPlotOwners(List<Cookie> cookies, long id);

        Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<PlotResponse>>>> SearchGisPlot(List<Cookie> cookies, SearchGisPlotRequest model);

        Task<ErrorOr<DmtResponseWrapper<UnitDetailResponse>>> GetUnitDetails(List<Cookie> cookies, long id);

        Task<ErrorOr<DmtResponseWrapper<PlotDetailResponse>>> FetchPlotByTenancyContractId(List<Cookie> cookies, string args, long id);

        Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<SearchPlotResponse>>>> SearchPlots(
            List<Cookie> cookies, int requestId, string municipalityId, string landuseId, string districtId,
            string publicHouseNo, string communityId, string roadId, string plotNumber, string plotFileNumber,
            string matchTypeId, int pageSize, string searchPlotFlags, string searchOwnerFlags, string ownerId,
            int pageNumber, int totalCount);
    }
}