using ADREC.DTO.RestClientModels.DMT.Plots;
using ADREC.DTO.RestClientModels.DMT.Profiles;
using ErrorOr;
using Runtime.DTO.ApiModels.DMTModel.Profiles;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Plots;
using Runtime.DTO.RestClientModels.DMT.Profiles;
using System.Net;

namespace ADREC.RestClient.Interfaces.DMT.Mocks
{
    public interface IProfileClient
    {
        Task<ErrorOr<DmtResponseWrapper<LandServicesAvailabilityResponse>>> CheckLandServicesAvailability(List<Cookie> cookies, string args);

        Task<ErrorOr<SwitchMimsProfileResponse>> SwitchMimsProfile(List<Cookie> cookies, SwitchProfileRequest model);

        Task<ErrorOr<DmtResponseWrapper<List<MimsProfileResponse>>>> GetMimsProfile(List<Cookie> cookies);

        Task<ErrorOr<DmtResponseWrapper<ProfileResponse>>> GetProfile();

        Task<ErrorOr<DmtResponseWrapper<List<ActiveServiceResponse>>>> GetActiveServiceResponse(List<Cookie> cookies);

        Task<ErrorOr<DmtResponseWrapper<List<StartActionResponse>>>> GetStartActionResponse(List<Cookie> cookies);

        Task<ErrorOr<DmtResponseWrapper<List<ServiceListingResponse>>>> GetMyServiceResponse(List<Cookie> cookies);

        Task<ErrorOr<DmtResponseWrapper<List<ServiceListingResponse>>>> GetPopularServiceResponse(List<Cookie> cookies);

        Task<ErrorOr<DmtResponseWrapper<ServiceOverviewResponse>>> GetServiceOverview(List<Cookie> cookies);

        Task<ErrorOr<DmtResponseWrapper<ServiceDetailResponse>>> GetServiceDetails(List<Cookie> cookies);
    }
}