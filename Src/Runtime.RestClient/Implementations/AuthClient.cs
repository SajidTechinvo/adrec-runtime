using ErrorOr;
using Runtime.Common.Errors;
using Runtime.Common.Settings;
using Runtime.DTO.ApiModels.Common;
using Runtime.DTO.RestClientModels.Common;
using Runtime.RestClient.Interfaces;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace Runtime.RestClient.Implementations
{
    internal class AuthClient(DmtSettings options) : IAuthClient
    {
        #region Methods

        public async Task<ErrorOr<List<Cookie>>> LoginAsync(string username, string password)
        {
            var cookieContainer = new CookieContainer();
            var handler = new HttpClientHandler
            {
                UseCookies = true,
                CookieContainer = cookieContainer
            };

            var client = new HttpClient(handler);

            var response = await client.PostAsync($"{options.BaseUrl}/api/Account/Login",
                            new StringContent(JsonSerializer.Serialize(new { username, password }), Encoding.UTF8, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                return cookieContainer.GetCookies(new Uri(options.BaseUrl)).Cast<Cookie>().ToList();
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

        public async Task<ErrorOr<UaePassUserInfoResponse>> GetUAEPassUserInfo(string code, string state)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.PostAsync($"{options.BaseUrl}/UaePass/UserInfo?code={code}&state={state}",
                            new StringContent(JsonSerializer.Serialize(new { }), Encoding.UTF8, "application/json"));

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Content.ReadAsStringAsync());
                return await response.Content.ReadFromJsonAsync<UaePassUserInfoResponse>();
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

        public async Task<ErrorOr<DmtResponseWrapper<SsoLoginResponse>>> DmtSsoLogin(DmtSsoLoginRequest model)
        {
            var httpClient = new HttpClient();

            var response = await httpClient.PostAsync($"{options.BaseUrl}/api/user/ssoLogin",
                            new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json"));

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<DmtResponseWrapper<SsoLoginResponse>>();
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

            throw new NotImplementedException();
        }

        #endregion Methods
    }

    public class AuthMockClient : IAuthClient
    {
        public Task<ErrorOr<DmtResponseWrapper<SsoLoginResponse>>> DmtSsoLogin(DmtSsoLoginRequest model)
        {
            throw new NotImplementedException();
        }

        public Task<ErrorOr<UaePassUserInfoResponse>> GetUAEPassUserInfo(string code, string state)
        {
            throw new NotImplementedException();
        }

        public async Task<ErrorOr<List<Cookie>>> LoginAsync(string username, string password)
        {
            await Task.Delay(50); // optional delay to simulate network call

            var list = new List<Cookie>()
            {
                new ("AuthToken", "mock-token-123", "/", "localhost"),
                new ("UserId", "user-abc", "/", "localhost")
            };

            return list;
        }
    }
}