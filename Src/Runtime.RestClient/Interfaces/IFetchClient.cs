using ErrorOr;
using Runtime.Common.Lookups;

namespace ADREC.RestClient.Interfaces
{
    public interface IFetchClient
    {
        Task<ErrorOr<dynamic>> GetData(ApiMethod method, string url, Dictionary<string, string> headers = null, string body = null);
    }
}