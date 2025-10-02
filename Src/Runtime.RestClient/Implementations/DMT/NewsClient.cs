using ADREC.RestClient.Interfaces.DMT.Mocks;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT;
using System.Net;
using System.Text.Json;

namespace ADREC.RestClient.Implementations.DMT
{
    internal class NewsClient : INewsClient
    {
        #region Methods

        public async Task<DmtResponseWrapper<List<NewsResponse>>> GetNews(List<Cookie> cookies)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "News.json");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            var content = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<NewsResponse>>>(content);
        }

        #endregion Methods
    }

    internal class NewsMockClient : INewsClient
    {
        #region Private Methods

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Methods

        #region Methods

        public async Task<DmtResponseWrapper<List<NewsResponse>>> GetNews(List<Cookie> cookies)
        {
            var content = await GetFileContent("News.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<NewsResponse>>>(content);
        }

        #endregion Methods
    }
}