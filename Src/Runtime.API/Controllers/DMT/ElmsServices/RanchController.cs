using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;
using Runtime.RestClient.Interfaces.Unit;

namespace Runtime.API.Controllers.DMT.ElmsServices
{
    [Route("ranch")]
    public class RanchController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis, logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region POST

        [HttpPost("land-classification")]
        public async Task<IActionResult> SearchRanchLandClassifications(string args, [FromQuery] RanchLandClassificationRequest model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.Ranch.SearchRanchLandClassifications(cookies, args, model);

            return result.Match(data => Ok(data.Result), Problem);
        }

        [HttpPost("start")]
        public async Task<IActionResult> StartBackOfficeWorkflow(string args, StartRanchWorkflowRequest model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.Ranch.StartWorkflow(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("registration-submit")]
        public async Task<IActionResult> RegistrationSubmit(string args, RanchRegistrationSubmitRequest model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            return await _rest.Ranch.RegistrationSubmit(cookies, args, model).Match(Ok, Problem);
        }

        [HttpPost("hold-application")]
        public async Task<IActionResult> HoldApplication(string args, HoldApplicationRequest model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            return await _rest.Ranch.HoldApplication(cookies, args, model).Match(Ok, Problem);
        }

        [HttpPost("registration-cancel")]
        public async Task<IActionResult> RegistrationCancel(string args, RegistrationCancelRequest model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            return await _rest.Ranch.RegistrationCancel(cookies, args, model).Match(Ok, Problem);
        }

        [HttpPost("recipient")]
        public async Task<IActionResult> AddRecipients(string args, AddRecipientRequest model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            return await _rest.Ranch.AddRecipients(cookies, args, model).Match(Ok, Problem);
        }

        [HttpPost("recipient-remove")]
        public async Task<IActionResult> RemoveRecipients(string args, AddRecipientRequest model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            return await _rest.Ranch.RemoveRecipients(cookies, args, model).Match(Ok, Problem);
        }

        [HttpPost("assign-plot")]
        public async Task<IActionResult> AssignPlot(string args, long plotId)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            return await _rest.Ranch.AssignPlot(cookies, args, plotId).Match(Ok, Problem);
        }

        [HttpPost("assignment-back")]
        public async Task<IActionResult> AssignmentBack(string args, BackRequest model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            return await _rest.Ranch.AssignmentBack(cookies, args, model).Match(Ok, Problem);
        }

        [HttpPost("assignment-reject")]
        public async Task<IActionResult> AssignmentReject(string args, BackOfficeModel model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.Ranch.AssignmentReject(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("assignment-submit")]
        public async Task<IActionResult> AssignmentSubmit(string args, AssignmentSubmitRequest model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            return await _rest.Ranch.AssignmentSubmit(cookies, args, model).Match(Ok, Problem);
        }

        [HttpPost("approval-submit")]
        public async Task<IActionResult> ApprovalSubmit(string args, ApprovalSubmitRequest model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            return await _rest.Ranch.ApprovalSubmit(cookies, args, model).Match(Ok, Problem);
        }

        [HttpPost("approval-reject")]
        public async Task<IActionResult> ApprovalReject(string args, ApprovalRejectRequest model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            return await _rest.Ranch.ApprovalReject(cookies, args, model).Match(Ok, Problem);
        }

        [HttpPost("approval-back")]
        public async Task<IActionResult> ApprovalBack(string args, BackRequest model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            return await _rest.Ranch.ApprovalBack(cookies, args, model).Match(Ok, Problem);
        }

        [HttpPost("confirm-collecting-payments-submit")]
        public async Task<IActionResult> ConfirmCollectingPaymentsSubmit(string args, ConfirmCollectingPaymentsSubmitRequest model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            return await _rest.Ranch.ConfirmCollectingPaymentsSubmit(cookies, args, model).Match(Ok, Problem);
        }

        [HttpPost("print-ranch")]
        public async Task<IActionResult> Print(string args)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            return await _rest.Ranch.Print(cookies, args).Match(Ok, Problem);
        }

        [HttpPost("print-ranch-submit")]
        public async Task<IActionResult> PrintSubmit(string args, ApprovalSubmitRequest model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            return await _rest.Ranch.PrintSubmit(cookies, args, model).Match(Ok, Problem);
        }

        [HttpPost("back-office-payment-submit")]
        public async Task<IActionResult> BackOfficePaymentSubmit(string args, BackOfficePaymentSubmitRequest model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.Ranch.BackOfficePaymentSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        #endregion POST

        #region GET

        [HttpGet("step-info")]
        public async Task<IActionResult> GetStepInfo(string args)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            return await _rest.Ranch.GetStepInfo(cookies, args).Match(Ok, Problem);
        }

        [HttpGet("random-allotment-sets")]
        public async Task<IActionResult> SearchRandomAllotmentSets(string args, bool isRanch, long municipalityId)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            return await _rest.Ranch.SearchRandomAllotmentSets(cookies, args, isRanch, municipalityId).Match(Ok, Problem);
        }

        [HttpGet("cards")]
        public async Task<IActionResult> GetRanchCards(int pageSize, int pageNumber)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.Ranch.GetRanchCards(cookies, pageSize, pageNumber);

            return result.Match(Ok, Problem);
        }

        [HttpGet("application-detail")]
        public async Task<IActionResult> GetApplicationDetails(string args)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.Ranch.GetApplicationDetails(cookies, args);

            return result.Match(Ok, Problem);
        }

        [HttpGet("applicants")]
        public async Task<IActionResult> GetApplicants(string args)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.Ranch.GetApplicants(cookies, args);

            return result.Match(Ok, Problem);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}