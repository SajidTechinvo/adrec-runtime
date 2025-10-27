using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Errors;
using Runtime.Common.Errors.Exceptions;
using Runtime.Common.Settings;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace Runtime.RestClient.Implementations.Factory
{
    internal class HttpBase(DmtSettings settings, ICustomHttpFactory httpFactory)
    {
        #region Private Fields

        private readonly ICustomHttpFactory _httpFactory = httpFactory;
        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        protected async Task<ErrorOr<Tout>> Post<Tout>(List<Cookie> cookies, string url, byte[] file, string paramName, string fileName)
        {
            var client = _httpFactory.CreateWithCookies(cookies, new Uri(_settings.BaseUrl));
            HttpResponseMessage response;

            try
            {
                using var content = new MultipartFormDataContent();

                new ByteArrayContent(file).Headers.Add("Content-Type", "application/octet-stream");

                content.Add(new ByteArrayContent(file), paramName, fileName);

                response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Tout>();
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
                throw new GeneralException("Network error occurred during POST request.", ex);
            }
            catch (Exception ex)
            {
                throw new GeneralException(ex.Message);
            }
        }

        protected async Task<ErrorOr<Tout>> Post<Tout, Tin>(List<Cookie> cookies, string url, Tin model)
        {
            var client = _httpFactory.CreateWithCookies(cookies, new Uri(_settings.BaseUrl));

            HttpResponseMessage response;
            try
            {
                var content = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");
                response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Tout>();
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();

                    return response.StatusCode switch
                    {
                        HttpStatusCode.BadRequest => Errors.BadRequest(errorContent),
                        HttpStatusCode.MethodNotAllowed => Errors.MethodNotAllowed(),
                        HttpStatusCode.NotFound => Errors.NotFoundAPI(errorContent),
                        HttpStatusCode.Unauthorized => Errors.UnauthorizedAPI(errorContent),
                        _ => Error.Failure("Unknown Error", errorContent),
                    };
                }
            }
            catch (HttpRequestException ex)
            {
                throw new GeneralException("Network error occurred during POST request.", ex);
            }
            catch (Exception ex)
            {
                throw new GeneralException("An error occurred during GET request. See Inner exception for details", ex);
            }
        }

        protected async Task<ErrorOr<Tout>> Get<Tout>(List<Cookie> cookies, string url)
        {
            var client = _httpFactory.CreateWithCookies(cookies, new Uri(_settings.BaseUrl));

            HttpResponseMessage response;
            try
            {
                response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Tout>();
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
                throw new GeneralException("Unexpected error occurred during GET request.", ex);
            }
        }

        protected async Task<ErrorOr<Tout>> Put<Tout, Tin>(List<Cookie> cookies, string url, Tin model)
        {
            var client = _httpFactory.CreateWithCookies(cookies, new Uri(_settings.BaseUrl));

            HttpResponseMessage response;
            try
            {
                var content = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");
                response = await client.PutAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Tout>();
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
                throw new GeneralException("Network error occurred during PUT request.", ex);
            }
            catch (Exception ex)
            {
                throw new GeneralException("Unexpected error occurred during PUT request.", ex);
            }
        }

        protected async Task<ErrorOr<Tout>> Delete<Tout>(List<Cookie> cookies, string url)
        {
            var client = _httpFactory.CreateWithCookies(cookies, new Uri(_settings.BaseUrl));

            HttpResponseMessage response;
            try
            {
                response = await client.DeleteAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Tout>();
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
                throw new GeneralException("Network error occurred during DELETE request.", ex);
            }
            catch (Exception ex)
            {
                throw new GeneralException("Unexpected error occurred during DELETE request.", ex);
            }
        }

        #endregion Methods
    }
}