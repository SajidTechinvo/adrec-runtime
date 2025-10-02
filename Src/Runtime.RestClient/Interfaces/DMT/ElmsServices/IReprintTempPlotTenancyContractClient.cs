using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ErrorOr;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.ReprintTempPlotTenancyContract;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.Documents;
using Runtime.DTO.RestClientModels.DMT.Owners;
using System.Net;

namespace Runtime.RestClient.Interfaces.DMT.ElmsServices
{
    public interface IReprintTempPlotTenancyContractClient
    {
        Task<ErrorOr<DmtResponseWrapper<DocumentDownloadResponse>>> PrintContract(List<Cookie> cookies, string args, PrintContractReprintTempPlotTenancyContract model);

        Task<ErrorOr<DmtResponseWrapper<List<PlotOwnerResponse>>>> FetchNewOwners(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<List<PlotOwnerResponse>>>> GetRecipient(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<object>>> AddRecipient(List<Cookie> cookies, string args, AddRecipientRequest model);

        Task<ErrorOr<DmtResponseWrapper<ReprintTempPlotTenancyContractResponse>>> GetStepInfo(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalSubmit(List<Cookie> cookies, string args, BackOfficeModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PrintSubmit(List<Cookie> cookies, string args, CommentModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterSubmit(List<Cookie> cookies, string args, RegisterReprintTempPlotTenancyContract model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartReprintTempPlotTenancyContract model);
    }
}