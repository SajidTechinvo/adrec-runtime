using Microsoft.AspNetCore.Http;
using System.Diagnostics;

namespace Runtime.Common.Helpers
{
    public static class RequestHelper
    {
        #region Methods

        public static string GetAuthorizationToken(HttpRequest request)
        {
            try
            {
                return request.Headers.Authorization;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        #endregion Methods
    }
}