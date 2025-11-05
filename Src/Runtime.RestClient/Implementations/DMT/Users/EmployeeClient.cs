using ADREC.DTO.RestClientModels.DMT.Users;
using ADREC.RestClient.Interfaces.Factory;
using ErrorOr;
using Runtime.Common.Settings;
using Runtime.DTO.RestClientModels.Common;
using Runtime.RestClient.Implementations.Factory;
using Runtime.RestClient.Interfaces.DMT.Users;
using System.Net;

namespace Runtime.RestClient.Implementations.DMT.Users
{
    internal class EmployeeClient(DmtSettings settings, ICustomHttpFactory httpFactory) : HttpBase(settings, httpFactory), IEmployeeClient
    {
        #region Private Fields

        private readonly DmtSettings _settings = settings;

        #endregion Private Fields

        #region Methods

        public async Task<ErrorOr<DmtResponseWrapper<EmployeeLocationResponse>>> GetEmployeeLocation(List<Cookie> cookies, string args)
        {
            return await Post<DmtResponseWrapper<EmployeeLocationResponse>, object>(cookies, $"{_settings.BaseUrl}/api/user/getEmployeeLocation?args={args}", new { });
        }

        #endregion Methods
    }
}