using ErrorOr;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Units;
using Runtime.RestClient.Interfaces.DMT.ElmsUnits;
using System.Net;
using System.Text.Json;

namespace Runtime.RestClient.Implementations.DMT.ElmsUnits
{
    internal class UnitMockClient : IUnitClient
    {
        #region Private Methods

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "Units", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Methods

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<UnitResponse>>>> SearchUnits(
            List<Cookie> cookies, string args, int requestId, string createUrlArgs,
            string municipalityId, string districtId, string communityId, string roadId, string plotNumber,
            string landuseId, string buildingNumber, string flourNumber, string unitNumber, string unitClassificationId,
            MatchType matchTypeId, int pageSize, string searchPlotFlags, string searchOwnerFlags, string ownerId,
            int pageNumber, int totalCount)
        {
            var content = await GetFileContent("SearchUnit.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<DmtPageResponse<UnitResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<UnitDetailResponse>>> GetUnitDetails(List<Cookie> cookies, string args, long id)
        {
            var content = await GetFileContent("UnitDetailResponse.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<UnitDetailResponse>>(content);
        }

        #endregion Methods
    }
}