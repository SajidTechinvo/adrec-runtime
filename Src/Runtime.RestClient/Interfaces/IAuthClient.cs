using ErrorOr;
using Runtime.DTO.ApiModels.Common;
using System.Net;

namespace Runtime.RestClient.Interfaces
{
    public interface IAuthClient
    {
        Task<ErrorOr<List<Cookie>>> LoginAsync(string username, string password);
        Task<ErrorOr<UAEPassLoginResponse>> GetUAEPassUser(string code, string state);
    }
}