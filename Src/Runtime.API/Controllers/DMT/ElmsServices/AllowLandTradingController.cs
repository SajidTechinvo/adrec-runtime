using ErrorOr;
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
    [Route("allow-land-trading")]
    public class AllowLandTradingController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis,logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly IRedisCacheService _redis = redis;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region POST

        [HttpPost("start")]
        public async Task<IActionResult> StartBackOfficeWorkflow(string args, AddPlotRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            return await _rest.AllowLandTrading.StartWorkflow(cookies, args, model).Match(Ok, Problem);
        }

        [HttpPost("registration-submit")]
        public async Task<IActionResult> RegistrationSubmit(string args, RegisterAllowLandTrading model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            return await _rest.AllowLandTrading.RegistrationSubmit(cookies, args, model).Match(Ok, Problem);
        }

        [HttpPost("evaluation-submit")]
        public async Task<IActionResult> EvaluationSubmit(string args, EvaluateAllowLandTrading model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            return await _rest.AllowLandTrading.EvaluationSubmit(cookies, args, model).Match(Ok, Problem);
        }

        [HttpPost("approval-submit")]
        public async Task<IActionResult> ApprovalSubmit(string args, CommentModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            return await _rest.AllowLandTrading.ApprovalSubmit(cookies, args, model).Match(Ok, Problem);
        }

        [HttpPost("payment-submit")]
        public async Task<IActionResult> PaymentSubmit(string args, CommentModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            return await _rest.AllowLandTrading.PaymentSubmit(cookies, args, model).Match(Ok, Problem);
        }

        #endregion POST

        #region GET

        [HttpGet("step-info")]
        public async Task<IActionResult> GetStepInfo(string args)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            return await _rest.AllowLandTrading.GetStepInfo(cookies, args).Match(Ok, Problem);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}