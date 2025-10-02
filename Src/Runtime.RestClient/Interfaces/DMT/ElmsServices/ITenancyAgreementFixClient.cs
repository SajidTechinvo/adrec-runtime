using ADREC.DTO.ApiModels.DMTModel.ElmsServices;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.Common;
using ADREC.DTO.RestClientModels.DMT.ElmsServices.TenancyAgreementFix;
using ErrorOr;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.ElmsServices.TenancyAgreementFix;
using System.Net;

namespace Runtime.RestClient.Interfaces.DMT.ElmsServices
{
    public interface ITenancyAgreementFixClient
    {
        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> ApprovalSubmit(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<TenancyAgreementFixResponse>>> GetStepInfo(List<Cookie> cookies, string args);

        Task<ErrorOr<DmtResponseWrapper<FetchTenancyContractFixDetailResponse>>> FetchTenancyContractDetails(List<Cookie> cookies, string args, long id);

        Task<ErrorOr<DmtResponseWrapper<DataFixAmountResponse>>> DataFixScreenFeeAmount(List<Cookie> cookies, string args, bool isNewContract);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> RegisterWorkflow(List<Cookie> cookies, string args, RegisterTenancyAgreementFix model);

        Task<ErrorOr<DmtResponseWrapper<WorkflowResponse>>> StartWorkflow(List<Cookie> cookies, string args, StartTenancyAgreementFix model);
    }
}