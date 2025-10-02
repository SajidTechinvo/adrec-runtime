using ADREC.DTO.RestClientModels.DMT.Plots;
using ADREC.DTO.RestClientModels.DMT.Profiles;
using ADREC.RestClient.Interfaces.DMT.Mocks;
using ErrorOr;
using Runtime.DTO.ApiModels.DMTModel.Profiles;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Plots;
using Runtime.DTO.RestClientModels.DMT.Profiles;
using System.Net;
using System.Text.Json;

namespace ADREC.RestClient.Implementations.DMT.Profiles
{
    internal class ProfileMockClient : IProfileClient
    {
        #region Private Methods

        private static async Task<string> GetFileContent(string fileName)
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(basePath, "Response", "Profiles", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }

            return await File.ReadAllTextAsync(filePath);
        }

        #endregion Private Methods

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<LandServicesAvailabilityResponse>>> CheckLandServicesAvailability(List<Cookie> cookies, string args)
        {
            var content = await GetFileContent("LandServicesAvailability.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<LandServicesAvailabilityResponse>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<MimsProfileResponse>>>> GetMimsProfile(List<Cookie> cookies)
        {
            var content = await GetFileContent("MimsProfile.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<MimsProfileResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<StartActionResponse>>>> GetStartActionResponse(List<Cookie> cookies)
        {
            var content = await GetFileContent("StartAction.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<StartActionResponse>>>(content);
        }

        public async Task<ErrorOr<DmtResponseWrapper<List<ActiveServiceResponse>>>> GetActiveServiceResponse(List<Cookie> cookies)
        {
            var content = await GetFileContent("ActiveService.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<ActiveServiceResponse>>>(content);
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

        public async Task<ErrorOr<DmtResponseWrapper<List<ServiceListingResponse>>>> GetPopularServiceResponse(List<Cookie> cookies)
        {
            var content = await GetFileContent("PopularServices.json");
            return JsonSerializer.Deserialize<DmtResponseWrapper<List<ServiceListingResponse>>>(content);
        }

        public async Task<ErrorOr<SwitchMimsProfileResponse>> SwitchMimsProfile(List<Cookie> cookies, SwitchProfileRequest model)
        {
            var content = await GetFileContent("SwitchMimsProfile.json");
            return new SwitchMimsProfileResponse()
            {
                Response = JsonSerializer.Deserialize<DmtResponseWrapper<SwitchMimsProfileModel>>(content),
                Cookies =
                [
                    new ("AuthToken", "mock-token-123", "/", "localhost"),
                    new ("UserId", "user-abc", "/", "localhost")
                ]
            };
        }

        #endregion Methods
    }
}