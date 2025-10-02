using ADREC.DTO.ApiModels.DMTModel;
using ADREC.DTO.RestClientModels.DMT.Plots;
using ADREC.DTO.RestClientModels.DMT.Plots.Common;
using ADREC.RestClient.Interfaces.DMT.Common;
using ErrorOr;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Owners;
using Runtime.DTO.RestClientModels.DMT.Plots;
using Runtime.DTO.RestClientModels.DMT.Units;
using System.Net;
using System.Text.Json;

namespace ADREC.RestClient.Implementations.DMT.Plots
{
    internal class PlotMockClient : IPlotClient
    {
        #region Private Methods

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "Plots", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Methods

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<FetchPlotProfileResponse>>> FetchPlotProfile(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("FetchPlotProfile.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<FetchPlotProfileResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<FetchPlotProfileServiceResponse>>>> FetchPlotProfileServices(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("FetchPlotProfileService.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<DmtPageResponse<FetchPlotProfileServiceResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<GisPlotDetailResponse>>> GetGisPlotDetail(List<Cookie> cookies, long tpdPlotId, long municipalityId)
        {
            var content = await GetFileContent("GisPlotDetail.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<GisPlotDetailResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<PlotDetailResponse>>> GetPlotDetails(List<Cookie> cookies, long id)
        {
            var content = await GetFileContent("PlotDetail.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<PlotDetailResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<PlotDetailResponse>>> FetchPlotByTenancyContractId(List<Cookie> cookies, string args, long id)
        {
            var content = await GetFileContent("PlotDetail.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<PlotDetailResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<PlotOwnerResponse>>> GetPlotOwners(List<Cookie> cookies, long id)
        {
            var content = await GetFileContent("PlotOwner.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<PlotOwnerResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<UnitDetailResponse>>> GetUnitDetails(List<Cookie> cookies, long id)
        {
            var content = await GetFileContent("UnitDetail.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<UnitDetailResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<PlotResponse>>>> SearchGisPlot(List<Cookie> cookies, SearchGisPlotRequest model)
        {
            var content = await GetFileContent("SearchGisPlot.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<DmtPageResponse<PlotResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<SearchPlotResponse>>>> SearchPlots(
            List<Cookie> cookies, int requestId, string municipalityId, string landuseId, string districtId,
            string publicHouseNo, string communityId, string roadId, string plotNumber, string plotFileNumber,
            string matchTypeId, int pageSize, string searchPlotFlags, string searchOwnerFlags, string ownerId,
            int pageNumber, int totalCount)
        {
            var content = await GetFileContent("SearchPlots.json");

            return JsonSerializer.Deserialize<DmtResponseWrapper<DmtPageResponse<SearchPlotResponse>>>(content);
        }

        #endregion Methods
    }
}