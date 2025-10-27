using ErrorOr;
using Runtime.DTO.RestClientModels.Common;
using System.Net;

namespace Runtime.RestClient.Interfaces.DMT
{
    public interface IDocumentClient
    {
        Task<ErrorOr<FileResult>> DownloadFileAsync(List<Cookie> cookies, string args);

    }
}
