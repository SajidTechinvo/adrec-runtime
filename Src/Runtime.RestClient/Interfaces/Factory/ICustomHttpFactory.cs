using System.Net;

namespace ADREC.RestClient.Interfaces.Factory
{
    public interface ICustomHttpFactory
    {
        HttpClient CreateWithCookies(List<Cookie> cookies, Uri baseUri);
    }
}