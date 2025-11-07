using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;
using Runtime.RestClient.Interfaces.Unit;

namespace Runtime.API.Controllers.DMT.ElmsServices
{
    [Route("clearance-certificate")]
    public class ClearanceCertificateController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis, logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region POST

        [HttpPost("start")]
        public async Task<IActionResult> StartBackOfficeWorkflow(string args, StartClearanceCertificate model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.ClearanceCertificate.StartWorkflow(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("register-submit")]
        public async Task<IActionResult> RegisterSubmit(string args, RegisterClearanceCertificate model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.ClearanceCertificate.RegisterSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("register-cancel")]
        public async Task<IActionResult> RegisterCancel(string args, BackModel model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.ClearanceCertificate.RegisterCancel(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("approval-submit")]
        public async Task<IActionResult> ApprovalSubmit(string args, CommentModel model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.ClearanceCertificate.ApprovalSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("approval-reject")]
        public async Task<IActionResult> ApprovalReject(string args, BackModel model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.ClearanceCertificate.ApprovalReject(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("print")]
        public async Task<IActionResult> Print(string args)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.ClearanceCertificate.Print(cookies, args);

            return result.Match(Ok, Problem);
        }

        [HttpPost("print-submit")]
        public async Task<IActionResult> Print(string args, CommentModel model)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.ClearanceCertificate.PrintSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        #endregion POST

        #region GET

        [HttpGet("step-info")]
        public async Task<IActionResult> GetStepInfo(string args)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.ClearanceCertificate.GetStepInfo(cookies, args);

            return result.Match(Ok, Problem);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}