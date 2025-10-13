using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;
using Runtime.RestClient.Interfaces.Unit;
using System.Net;

namespace Runtime.API.Controllers.DMT.ElmsServices
{
    [Route("unassigned-allotment-temporary-plot")]
    public class UnassignedAllotmentTemporaryPlotController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis,logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly IRedisCacheService _redis = redis;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region POST

        [HttpPost("start")]
        public async Task<IActionResult> StartBackOfficeWorkflow(string args, StartUnassignedAllotmentTemporaryPlot model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.UnassignedAllotmentTemporaryPlot.StartWorkflow(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("pre-registration-submit")]
        public async Task<IActionResult> PreRegistrationSubmit(string args, CommentModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.UnassignedAllotmentTemporaryPlot.PreRegistrationSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("recipient")]
        public async Task<IActionResult> AddRecipient(string args, UnassignedAllotmentTemporaryPlotAddRecipient model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.UnassignedAllotmentTemporaryPlot.AddRecipient(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterWorkflow(string args, RegisterUnassignedAllotmentTemporaryPlot model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.UnassignedAllotmentTemporaryPlot.RegisterWorkflow(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("audit-owner-plot")]
        public async Task<IActionResult> AuditOwnerPlotsSubmit(string args, AuditUnassignedAllotmentTemporaryPlot model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.UnassignedAllotmentTemporaryPlot.AuditOwnerPlotsSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        #endregion POST

        #region GET

        [HttpGet("step-info")]
        public async Task<IActionResult> GetStepInfo(string args)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.UnassignedAllotmentTemporaryPlot.GetStepInfo(cookies, args);

            return result.Match(Ok, Problem);
        }

        #endregion GET

        #region DELETE

        [HttpDelete("recipient")]
        public async Task<IActionResult> RemoveRecipient(string args, UnassignedAllotmentTemporaryPlotAddRecipient model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.UnassignedAllotmentTemporaryPlot.RemoveRecipient(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        #endregion DELETE

        #endregion End Points

        #endregion Methods
    }
}