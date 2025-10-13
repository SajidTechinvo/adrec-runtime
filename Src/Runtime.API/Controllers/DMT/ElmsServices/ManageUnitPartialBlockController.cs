using ADREC.DTO.ApiModels.DMTModel.ElmsServices;
using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.RestClient.Interfaces.Unit;
using System.Net;

namespace Runtime.API.Controllers.DMT.ElmsServices
{
    [Route("manage-unit-partial-block")]
    public class ManageUnitPartialBlockController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis,logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly IRedisCacheService _redis = redis;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region POST

        [HttpPost("start")]
        public async Task<IActionResult> StartBackOfficeWorkflow(string args, StartManageUnitPartialBlock model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.ManageUnitPartialBlock.StartWorkflow(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("registration-submit")]
        public async Task<IActionResult> RegisterBackOfficeWorkflow(string args)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.ManageUnitPartialBlock.RegisterSubmit(cookies, args);

            return result.Match(Ok, Problem);
        }

        [HttpPost("approval-approve")]
        public async Task<IActionResult> ApprovalApprove(string args)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.ManageUnitPartialBlock.ApprovalApprove(cookies, args);

            return result.Match(Ok, Problem);
        }

        [HttpPost("approval-reject")]
        public async Task<IActionResult> ApprovalReject(string args, CommentModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.ManageUnitPartialBlock.ApprovalReject(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        #endregion POST

        #region GET

        [HttpGet("step-info")]
        public async Task<IActionResult> GetStepInfo(string args)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.ManageUnitPartialBlock.GetStepInfo(cookies, args);

            return result.Match(Ok, Problem);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}