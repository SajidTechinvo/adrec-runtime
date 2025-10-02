using ADREC.DTO.ApiModels.DMTModel;
using ADREC.DTO.RestClientModels.DMT.Plots;
using ADREC.DTO.RestClientModels.DMT.Plots.Common;
using ADREC.RestClient.Interfaces.DMT.Common;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Owners;
using Runtime.DTO.RestClientModels.DMT.Plots;
using Runtime.DTO.RestClientModels.DMT.Units;
using System.Net;

namespace ADREC.RestClient.Implementations.DMT.Plots
{
    internal class PlotClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IPlotClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<FetchPlotProfileResponse>>> FetchPlotProfile(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<FetchPlotProfileResponse>, object>(cookies,
                        $"{_settings.BaseUrl}/api/elmsplot/FetchPlotProfile", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<FetchPlotProfileServiceResponse>>>> FetchPlotProfileServices(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<DmtPageResponse<FetchPlotProfileServiceResponse>>, object>(cookies,
                       $"{_settings.BaseUrl}/api/ElmsPlot/FetchPlotProfileServices", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<GisPlotDetailResponse>>> GetGisPlotDetail(List<Cookie> cookies, long tpdPlotId, long municipalityId)
        {
            return await Post<DmtResponseWrapper<GisPlotDetailResponse>, object>(cookies,
                        $"{_settings.BaseUrl}/api/elmsplot/gisPlotDetail",
                        new
                        {
                            tpdPlotId,
                            municipalityId
                        });
        }

        public async Task<ErrorOr<DmtResponseWrapper<PlotDetailResponse>>> GetPlotDetails(List<Cookie> cookies, long id)
        {
            return await Post<DmtResponseWrapper<PlotDetailResponse>, object>(cookies,
                        $"{_settings.BaseUrl}/api/elmsplot/PlotDetails", new { id });
        }

        public async Task<ErrorOr<DmtResponseWrapper<PlotDetailResponse>>> FetchPlotByTenancyContractId(List<Cookie> cookies, string args, long id)
        {
            return await Post<DmtResponseWrapper<PlotDetailResponse>, object>(cookies,
                        $"{_settings.BaseUrl}/api/elmsplot/FetchPlotByTenancyContractId?args={args}", new { id });
        }

        public async Task<ErrorOr<DmtResponseWrapper<PlotOwnerResponse>>> GetPlotOwners(List<Cookie> cookies, long id)
        {
            return await Post<DmtResponseWrapper<PlotOwnerResponse>, object>(cookies,
                        $"{_settings.BaseUrl}/api/elmsplot/FetchPlotOwners", new { id });
        }

        public async Task<ErrorOr<DmtResponseWrapper<UnitDetailResponse>>> GetUnitDetails(List<Cookie> cookies, long id)
        {
            return await Post<DmtResponseWrapper<UnitDetailResponse>, object>(cookies,
                       $"{_settings.BaseUrl}/api/ElmsUnit/UnitDetails", new { id });
        }

        public async Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<PlotResponse>>>> SearchGisPlot(List<Cookie> cookies, SearchGisPlotRequest model)
        {
            return await Post<DmtResponseWrapper<DmtPageResponse<PlotResponse>>, SearchGisPlotRequest>(cookies,
                     $"{_settings.BaseUrl}/api/elmsplot/searchgisplots", model);
        }

        public async Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<SearchPlotResponse>>>> SearchPlots(
            List<Cookie> cookies, int requestId, string municipalityId, string landuseId, string districtId,
            string publicHouseNo, string communityId, string roadId, string plotNumber, string plotFileNumber,
            string matchTypeId, int pageSize, string searchPlotFlags, string searchOwnerFlags, string ownerId,
            int pageNumber, int totalCount)
        {
            return await Post<DmtResponseWrapper<DmtPageResponse<SearchPlotResponse>>, object>(cookies,
                        $"{_settings.BaseUrl}/api/elmsplot/searchplots",
                        new
                        {
                            requestId,
                            municipalityId,
                            landuseId,
                            districtId,
                            publicHouseNo,
                            communityId,
                            roadId,
                            plotNumber,
                            plotFileNumber,
                            matchTypeId,
                            pageSize,
                            searchPlotFlags,
                            searchOwnerFlags,
                            ownerId,
                            pageNumber,
                            totalCount
                        });
        }

        #endregion Methods
    }
}