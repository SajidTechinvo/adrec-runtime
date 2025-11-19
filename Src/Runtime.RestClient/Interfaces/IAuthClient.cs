using ErrorOr;
using Runtime.DTO.ApiModels.Common;
using Runtime.DTO.RestClientModels.Common;
using System.Net;

namespace Runtime.RestClient.Interfaces
{
    public interface IAuthClient
    {
        Task<ErrorOr<List<Cookie>>> LoginAsync(string username, string password);

        Task<ErrorOr<UaePassUserInfoResponse>> GetUAEPassUserInfo(string code, string state);

        Task<ErrorOr<DmtResponseWrapper<SsoLoginResponse>>> DmtSsoLogin(DmtSsoLoginRequest model);
    }
}