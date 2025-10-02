using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ErrorOr;
using Runtime.DTO.RestClientModels.Common;
using System.Net;

namespace ADREC.RestClient.Interfaces.DMT.Common
{
    public interface IApplicationClient
    {
        Task<ErrorOr<DmtResponseWrapper<List<ElmsUserResponse>>>> SearchElmsEngineerList(List<Cookie> cookies, string args, long id);
    }
}