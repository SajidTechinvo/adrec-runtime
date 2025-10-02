using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ErrorOr;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.PropertyMortgageRedemption;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;
using Runtime.DTO.RestClientModels.Common;
using System.Net;

namespace ADREC.RestClient.Interfaces.DMT.ElmsServices
{
    public interface IPropertyMortgageRedemptionClient
    {
        Task<ErrorOr<DmtResponseWrapper<PropertyMortgageRedemptionStepInfo>>> GetStepInfo(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> PrintStickerSubmit(List<Cookie> cookies, string args, CommentModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalSubmit(List<Cookie> cookies, string args, CommentModel model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterSubmit(List<Cookie> cookies, string args, RegisterPropertyMortgageRedemption model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartPropertyMortgageRedemption model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> UpdateArchiveSubmit(List<Cookie> cookies, string args, CommentModel model);
    }
}