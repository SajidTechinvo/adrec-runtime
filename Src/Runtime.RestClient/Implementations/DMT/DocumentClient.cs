using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Errors;
using Runtime.Common.Errors.Exceptions;
using Runtime.Common.Settings;
using Runtime.DTO.RestClientModels.Common;
using Runtime.RestClient.Interfaces.DMT;
using System.Net;

namespace Runtime.RestClient.Implementations.DMT
{
    internal class DocumentClient(DmtSettings settings, ICustomHttpFactory httpFactory) : IDocumentClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;
        private readonly ICustomHttpFactory _httpFactory = httpFactory;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<FileResult>> DownloadFileAsync(List<Cookie> cookies, string args)
        {
            var client = _httpFactory.CreateWithCookies(cookies, new Uri(_settings.BaseUrl));

            HttpResponseMessage response;
            try
            {


                response = await client.GetAsync($"{_settings.BaseUrl}/api/Document/GetPlotThumbnail?args={args}");
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
            catch (Exception ex)
            {
                throw new GeneralException("Unexpected error occurred during GET request. See inner exception for details.", ex);
            }
        }
        #endregion Methods
    }
}
