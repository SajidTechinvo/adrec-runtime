using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Errors;
using Runtime.Common.Errors.Exceptions;
using Runtime.Common.Settings;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using Runtime.RestClient.Implementations.Factory;
using Runtime.RestClient.Interfaces.DMT;
using System.Net;
using System.Text.Json;

namespace Runtime.RestClient.Implementations.DMT.Documents
{
    internal class FileClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IFileClient
    {
        #region Private Fields

        private readonly DmtSettings options = settings;
        private readonly ICustomHttpFactory _httpFactory = httpFactory;

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

        public async Task<ErrorOr<FileResult>> DownloadFileAsync(List<Cookie> cookies, string token)
        {
            var client = _httpFactory.CreateWithCookies(cookies, new Uri(options.BaseUrl));

            HttpResponseMessage response;
            try
            {


                response = await client.GetAsync($"{options.BaseUrl}/api/document/download?token={token}");
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
                    var errorContent = await response.Content.ReadAsStringAsync();

                    return response.StatusCode switch
                    {
                        HttpStatusCode.BadRequest => Errors.BadRequest(errorContent),
                        HttpStatusCode.MethodNotAllowed => Errors.MethodNotAllowed(),
                        HttpStatusCode.NotFound => Errors.NotFoundAPI(errorContent),
                        _ => Error.Failure("Unknown Error", errorContent),
                    };
                }
            }
            catch (HttpRequestException ex)
            {
                throw new GeneralException("Network error occurred during GET request.", ex);
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

        public Task<ErrorOr<FileResult>> DownloadFileAsync(List<Cookie> cookies, string token)
        {
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}