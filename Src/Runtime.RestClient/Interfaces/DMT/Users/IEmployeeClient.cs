using ADREC.DTO.RestClientModels.DMT.Users;
using ErrorOr;
using Runtime.DTO.RestClientModels.Common;
using System.Net;

namespace Runtime.RestClient.Interfaces.DMT.Users
{
    public interface IEmployeeClient
    {
        Task<ErrorOr<DmtResponseWrapper<EmployeeLocationResponse>>> GetEmployeeLocation(List<Cookie> cookies, string args);
    }
}