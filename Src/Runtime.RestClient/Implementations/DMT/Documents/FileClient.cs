using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.RestClient.Implementations.Factory;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using Runtime.RestClient.Interfaces.DMT;
using System.Net;
using System.Text.Json;

namespace Runtime.RestClient.Implementations.DMT.Documents
{
    internal class FileClient(DmtSettings settings, ICustomHttpFactory httpFactory, IHttpClientFactory clientFactory) : HttpBase(settings, httpFactory), IFileClient
    {
        #region Private Fields

        private readonly DmtSettings options = settings;
        private readonly IHttpClientFactory _client = clientFactory;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<WfiDocumentAttachmentResponse>>> UploadFileAsync(List<Cookie> cookies, byte[] file, string paramName, string fileName, string token)
        {
            return await Post<DmtResponseWrapper<WfiDocumentAttachmentResponse>>(cookies, $"{options.BaseUrl}/api/document/upload?token={token}", file, paramName, fileName);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WfiDocumentAttachmentResponse>>> DeleteFileAsync(List<Cookie> cookies, string token)
        {
            return await Post<DmtResponseWrapper<WfiDocumentAttachmentResponse>, object>(cookies, $"{options.BaseUrl}/api/document/delete?token={token}", new { });
        }

        public async Task<ErrorOr<FileResult>> DownloadFileAsync(string token)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{options.BaseUrl}/api/document/download?token={token}");
            var client = _client.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                return new FileResult()
                {
                    FileName = response.Content.Headers.ContentDisposition?.FileName?.Trim('"'),
                    Stream = await response.Content.ReadAsStreamAsync(),
                };
            }
            else
            {
                throw new Exception("An error occured while downloading the file");
            }
        }

        #endregion Methods
    }

    internal class FileMockClient : IFileClient
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

        public async Task<ErrorOr<DmtResponseWrapper<WfiDocumentAttachmentResponse>>> UploadFileAsync(List<Cookie> cookies, byte[] file, string paramName, string fileName, string token)
        {
            var content = await GetFileContent("Upload.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WfiDocumentAttachmentResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<WfiDocumentAttachmentResponse>>> DeleteFileAsync(List<Cookie> cookies, string token)
        {
            var content = await GetFileContent("Upload.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<WfiDocumentAttachmentResponse>>(content);
        }

        public Task<ErrorOr<FileResult>> DownloadFileAsync(string token)
        {
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}