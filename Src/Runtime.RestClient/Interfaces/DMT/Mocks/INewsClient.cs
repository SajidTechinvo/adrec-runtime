using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT;
using System.Net;

namespace ADREC.RestClient.Interfaces.DMT.Mocks
{
    public interface INewsClient
    {
        Task<DmtResponseWrapper<List<NewsResponse>>> GetNews(List<Cookie> cookies);
    }
}