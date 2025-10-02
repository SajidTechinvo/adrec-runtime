using ADREC.DTO.RestClientModels.DMT.ElmsDecree;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsDecree;
using Runtime.RestClient.Interfaces.DMT;
using System.Net;
using System.Text.Json;

namespace ADREC.RestClient.Implementations.DMT.ElmsDecree
{
    internal class ElmsDecreeClient(DmtSettings settings, ICustomHttpFactory factory) : HttpBase(settings, factory), IElmsDecreeClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<OwnerAllotmentNameResponse>>>> SearchOwnerAllotmentName(
            List<Cookie> cookies, string args, string cityNo, string familyBookNumber, string fullName,
            string matchTypeId, string nationalNumber, int pageNumber, int pageSize, int totalCount, string tribe)
        {
            return await Post<DmtResponseWrapper<DmtPageResponse<OwnerAllotmentNameResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsDecree/SearchOwnerAllotmentName?args={args}", new
            {
                cityNo,
                familyBookNumber,
                fullName,
                matchTypeId,
                nationalNumber,
                pageNumber,
                pageSize,
                totalCount,
                tribe
            });
        }

        public async Task<ErrorOr<DmtResponseWrapper<AllotmentOrderResponse>>> FetchAllotmentName(List<Cookie> cookies, string args, int id)
        {
            return await Post<DmtResponseWrapper<AllotmentOrderResponse>, object>(cookies, $"{_settings.BaseUrl}/api/ElmsDecree/FetchAllotmentName?args={args}", new
            {
                id
            });
        }

        #endregion Methods
    }

    internal class ElmsDecreeMockClient : IElmsDecreeClient
    {
        #region Private Fields

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "ElmsDecree", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<DmtPageResponse<OwnerAllotmentNameResponse>>>> SearchOwnerAllotmentName(List<Cookie> cookies, string args, string cityNo, string familyBookNumber, string fullName, string matchTypeId, string nationalNumber, int pageNumber, int pageSize, int totalCount, string tribe)
        {
            var content = await GetFileContent("SearchOwnerAllotmentName.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<DmtPageResponse<OwnerAllotmentNameResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<AllotmentOrderResponse>>> FetchAllotmentName(List<Cookie> cookies, string args, int id)
        {
            var content = await GetFileContent("FetchAllotmentName.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<AllotmentOrderResponse>>(content);
        }

        #endregion Methods
    }
}