using ADREC.DTO.RestClientModels.DMT.Users;
using ErrorOr;
using Runtime.DTO.RestClientModels.Common;
using System.Net;

namespace Runtime.RestClient.Interfaces.DMT.Users
{
    public interface IInboxClient
    {
        Task<ErrorOr<DmtResponseWrapper<BackOfficeInboxResponse>>> GetBackOfficeDrafts(
            List<Cookie> cookies, int pageSize, int pageNumber, string applicationNumber, string referenceNumber,
            string districtId, string communityId, string workflowId, string workflowStepId, string workflowStatusId,
            string workflowStepTypeId, string nationalNumber, string tradeLicenseNumber, DateTime startDate,
            DateTime endDate, string sorting, string municipalityId);

        Task<ErrorOr<DmtResponseWrapper<BackOfficeInboxResponse>>> GetBackOfficeInbox(
            List<Cookie> cookies, int pageSize, int pageNumber, string applicationNumber, string referenceNumber,
            string districtId, string communityId, string workflowId, string workflowStepId, string workflowStatusId,
            string workflowStepTypeId, string nationalNumber, string tradeLicenseNumber, DateTime startDate,
            DateTime endDate, string sorting, string municipalityId);
    }
}