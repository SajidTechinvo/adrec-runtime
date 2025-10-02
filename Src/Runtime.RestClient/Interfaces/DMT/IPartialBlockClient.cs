using ErrorOr;
using Runtime.DTO.ApiModels.DMTModel;
using Runtime.DTO.RestClientModels.Common;
using Runtime.DTO.RestClientModels.DMT.PartialBlocks;
using System.Net;

namespace ADREC.RestClient.Interfaces.DMT
{
    public interface IPartialBlockClient
    {
        Task<ErrorOr<DmtResponseWrapper<List<PartialBlockWorkflowTypeResponse>>>> GetWorkflowTypes(List<Cookie> cookies, string args, long id);

        Task<ErrorOr<DmtResponseWrapper<List<PartialBlockWorkflowResponse>>>> GetWorkflows(List<Cookie> cookies, string args, long id);

        Task<ErrorOr<DmtResponseWrapper<List<AddPartialBlockTxnWorkflowResponse>>>> AddPartialBlockTxnWorkflows(List<Cookie> cookies, string args, AddPartialBlockWorkflowRequest model);

        Task<ErrorOr<DmtResponseWrapper<List<AddPartialBlockTxnWorkflowResponse>>>> FetchPartialBlockTxnWorkflows(List<Cookie> cookies, string args, int id);
    }
}