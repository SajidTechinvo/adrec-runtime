using ADREC.RestClient.Interfaces;
using ErrorOr;
using Runtime.Common.Errors;
using Runtime.Common.Lookups;
using System.Net;
using System.Text;
using System.Text.Json;

namespace Runtime.RestClient.Implementations
{
    internal class FetchClient(IHttpClientFactory clientFactory) : IFetchClient
    {
        #region Private Fields

        private readonly IHttpClientFactory _client = clientFactory;

        #endregion Private Fields

        #region Private Methods

        private static ErrorOr<HttpMethod> GetHttpMethod(ApiMethod method)
        {
            return method switch
            {
                ApiMethod.GET => (ErrorOr<HttpMethod>)HttpMethod.Get,
                ApiMethod.POST => (ErrorOr<HttpMethod>)HttpMethod.Post,
                ApiMethod.PUT => (ErrorOr<HttpMethod>)HttpMethod.Put,
                ApiMethod.DELETE => (ErrorOr<HttpMethod>)HttpMethod.Delete,
                _ => (ErrorOr<HttpMethod>)Errors.MethodNotAllowed(),
            };
        }

        #endregion Private Methods

        #region Methods

        public async Task<ErrorOr<dynamic>> GetData(ApiMethod method, string url, Dictionary<string, string> headers = null, string body = null)
        {
            var verb = GetHttpMethod(method);
            if (verb.IsError) return verb.Errors;

            var request = new HttpRequestMessage(verb.Value, url);
            var client = _client.CreateClient();

            if (headers is not null)
            {
                foreach (var header in headers)
                {
                    request.Headers.Add(header.Key, header.Value);
                }
            }

            if (!string.IsNullOrWhiteSpace(body))
                request.Content = new StringContent(body, Encoding.UTF8, "application/json");

            var response = await client.SendAsync(request);
            var res = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return JsonSerializer.Deserialize<dynamic>(res);
            }
            else if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return Errors.NotFoundAPI(res);
            }
            else if (response.StatusCode == HttpStatusCode.MethodNotAllowed)
            {
                return Errors.MethodNotAllowed();
            }
            else
            {
                throw new Exception(res);
            }
        }

        #endregion Methods
    }
}