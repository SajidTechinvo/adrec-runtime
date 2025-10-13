using ErrorOr;
using Runtime.DTO.ApiModels;

namespace Runtime.RestClient.Interfaces
{
    public interface IPageInfoClient
    {
        Task<ErrorOr<PageInfoResponse>> GetPage(string token, string slug);
    }
}