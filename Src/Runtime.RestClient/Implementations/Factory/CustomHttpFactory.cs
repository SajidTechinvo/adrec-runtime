using ADREC.RestClient.Interfaces.Factory;
using System.Net;

namespace Runtime.RestClient.Implementations.Factory
{
    internal class CustomHttpFactory : ICustomHttpFactory
    {
        #region Methods

        public HttpClient CreateWithCookies(List<Cookie> cookies, Uri baseUri)
        {
            var container = new CookieContainer();
            if (cookies != null)
            {
                foreach (var cookie in cookies)
                {
                    container.Add(baseUri, cookie);
                }
            }

            var handler = new HttpClientHandler
            {
                UseCookies = true,
                CookieContainer = container
            };

            return new HttpClient(handler);
        }

        #endregion Methods
    }
}