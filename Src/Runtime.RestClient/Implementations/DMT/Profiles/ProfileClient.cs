using ADREC.DTO.RestClientModels.DMT.Plots;
using ADREC.DTO.RestClientModels.DMT.Profiles;
using ADREC.RestClient.Interfaces.DMT.Mocks;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Errors;
using Runtime.Common.Settings;
using Runtime.DTO.ApiModels.DMTModel.Profiles;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Plots;
using Runtime.DTO.RestClientModels.DMT.Profiles;
using Runtime.RestClient.Implementations.Factory;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace Runtime.RestClient.Implementations.DMT.Profiles
{
    internal class ProfileClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IProfileClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Private Methods

        public static async Task<string> GetFileContent(string name)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "Profiles", name);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            return await File.ReadAllTextAsync(filePath);
        }

        private static Cookie AreCookiesEqual(Cookie c1, IEnumerable<Cookie> existingCookies)
        {
            if (existingCookies.Any(c2 => c1.Name == c2.Name &&
                   c1.Domain == c2.Domain &&
                   c1.Path == c2.Path &&
                   c1.Secure == c2.Secure &&
                   c1.HttpOnly == c2.HttpOnly &&
                   c1.Value == c2.Value))
                return null;
            return c1;
        }

        private static List<Cookie> MergeCookies(IEnumerable<Cookie> existingCookies, IEnumerable<Cookie> newCookies)
        {
            var merged = new List<Cookie>();

            // Add all new cookies, replacing any existing ones
            foreach (var newCookie in newCookies)
            {
                var cookie = AreCookiesEqual(newCookie, existingCookies);
                if (cookie != null) merged.Add(cookie);
            }
            foreach (var oldCookie in existingCookies.Where(oldCookie => !merged.Any(c =>
                    c.Name == oldCookie.Name &&
                    c.Domain == oldCookie.Domain &&
                    c.Path == oldCookie.Path)))
            {

                merged.Add(oldCookie);

            }

            return merged;
        }

        #endregion Private Methods

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<LandServicesAvailabilityResponse>>> CheckLandServicesAvailability(List<Cookie> cookies, string args)
        {
            return await Get<DmtResponseWrapper<LandServicesAvailabilityResponse>>(cookies,
                $"{_settings.BaseUrl}/api/profiles/checkLandServicesAvailability?args={args}");
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<MimsProfileResponse>>>> GetMimsProfile(List<Cookie> cookies)
        {
            return await Post<DmtResponseWrapper<List<MimsProfileResponse>>, object>(cookies,
                $"{_settings.BaseUrl}/api/profiles/getMimsProfiles", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<ProfileResponse>>> GetProfile()
        {
            var content = await GetFileContent("Profile.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<ProfileResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<ServiceOverviewResponse>>> GetServiceOverview(List<Cookie> cookies)
        {
            var content = await GetFileContent("ServiceOverview.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<ServiceOverviewResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<ServiceDetailResponse>>> GetServiceDetails(List<Cookie> cookies)
        {
            var content = await GetFileContent("ServiceDetail.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<ServiceDetailResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<ServiceListingResponse>>>> GetMyServiceResponse(List<Cookie> cookies)
        {
            var content = await GetFileContent("MyService.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<ServiceListingResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<ActiveServiceResponse>>>> GetActiveServiceResponse(List<Cookie> cookies)
        {
            return await Post<DmtResponseWrapper<List<ActiveServiceResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/OneHub/GetActiveServices", new { });
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<ServiceListingResponse>>>> GetPopularServiceResponse(List<Cookie> cookies)
        {
            var content = await GetFileContent("PopularServices.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<ServiceListingResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<StartActionResponse>>>> GetStartActionResponse(List<Cookie> cookies)
        {
            return await Post<DmtResponseWrapper<List<StartActionResponse>>, object>(cookies, $"{_settings.BaseUrl}/api/profiles/fetchElmsStartActions", new { });
        }

        public async Task<ErrorOr<SwitchMimsProfileResponse>> SwitchMimsProfile(List<Cookie> cookies, SwitchProfileRequest model)
        {
            var baseUri = new Uri(_settings.BaseUrl);
            var cookieContainer = new CookieContainer();

            // Step 1: Add incoming cookies
            if (cookies != null)
            {
                foreach (var cookie in cookies)
                {
                    cookieContainer.Add(baseUri, cookie);
                }
            }

            var handler = new HttpClientHandler
            {
                UseCookies = true,
                CookieContainer = cookieContainer
            };

            using var client = new HttpClient(handler);

            // Step 2: Make the request
            var response = await client.PostAsync(
                $"{_settings.BaseUrl}/api/Profiles/SwitchMimsRole",
                new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json")
            );

            if (response.IsSuccessStatusCode)
            {
                // Step 3: Merge cookies from the response
                var responseCookies = cookieContainer
                                        .GetCookies(baseUri)
                                        .Cast<Cookie>()
                                        .ToList();

                var mergedCookies = MergeCookies(cookies ?? new List<Cookie>(), responseCookies);

                return new SwitchMimsProfileResponse
                {
                    Response = await response.Content.ReadFromJsonAsync<DmtResponseWrapper<SwitchMimsProfileModel>>(),
                    Cookies = mergedCookies
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
                    _ => Error.Failure("Unknown Error", errorContent)
                };
            }
        }

        #endregion Methods
    }
}