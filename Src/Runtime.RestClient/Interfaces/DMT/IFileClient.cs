using ErrorOr;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.Common;
using System.Net;

namespace Runtime.RestClient.Interfaces.DMT
{
    public interface IFileClient
    {
        Task<ErrorOr<DmtResponseWrapper<WfiDocumentAttachmentResponse>>> UploadFileAsync(List<Cookie> cookies, byte[] file, string paramName, string fileName, string token);

        Task<ErrorOr<FileResult>> DownloadFileAsync(List<Cookie> cookies, string token);

        Task<ErrorOr<DmtResponseWrapper<WfiDocumentAttachmentResponse>>> DeleteFileAsync(List<Cookie> cookies, string token);
    }
}