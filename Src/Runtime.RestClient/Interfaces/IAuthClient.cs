using ErrorOr;
using System.Net;

namespace ADREC.RestClient.Interfaces
{
    public interface IAuthClient
    {
        Task<ErrorOr<List<Cookie>>> LoginAsync(string username, string password);
    }
}