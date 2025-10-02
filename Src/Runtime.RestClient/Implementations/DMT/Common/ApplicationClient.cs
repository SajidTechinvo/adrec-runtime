using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.RestClient.Interfaces.DMT.Common;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.RestClientModels.Common;
using System.Net;
using System.Text.Json;

namespace ADREC.RestClient.Implementations.DMT.Common
{
    internal class ApplicationClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IApplicationClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<List<ElmsUserResponse>>>> SearchElmsEngineerList(List<Cookie> cookies, string args, long id)
        {
            return await Post<DmtResponseWrapper<List<ElmsUserResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/elmsApplication/SearchElmsEngineerList?args={args}", new { id });
        }

        #endregion Methods
    }

    internal class ApplicationMockClient : IApplicationClient
    {
        #region Private Methods

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "Application", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Methods

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<List<ElmsUserResponse>>>> SearchElmsEngineerList(List<Cookie> cookies, string args, long id)
        {
            var content = await GetFileContent("SearchElmsEngineerList.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<ElmsUserResponse>>>(content);
        }

        #endregion Methods
    }
}