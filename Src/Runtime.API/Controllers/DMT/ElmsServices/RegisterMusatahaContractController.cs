using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.DTO.ApiModels.DMTModel.ElmsPayment;
using Runtime.DTO.ApiModels.DMTModel.ElmsServices;
using Runtime.RestClient.Interfaces.Unit;
using System.Net;

namespace Runtime.API.Controllers.DMT.ElmsServices
{
    [Route("register-musataha-contract")]
    public class RegisterMusatahaContractController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis,logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly IRedisCacheService _redis = redis;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region POST

        [HttpPost("start")]
        public async Task<IActionResult> StartBackOfficeWorkflow(string args, StartRegisterMusatahaContract model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.RegisterMusatahaContract.StartWorkflow(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("registration-submit")]
        public async Task<IActionResult> RegisterBackOfficeWorkflow(string args, SubmitRegisterMusatahaContractRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.RegisterMusatahaContract.RegisterSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("approval-submit")]
        public async Task<IActionResult> ApprovalApprove(string args, ApproveRegisterMusatahaContract model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.RegisterMusatahaContract.ApprovalSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("print-payment-slip")]
        public async Task<IActionResult> PrintPaymentSlip(string args, PrintPaymentSlipRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.RegisterMusatahaContract.PrintPaymentSlip(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("payment-submit")]
        public async Task<IActionResult> PaymentSubmit(string args)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.RegisterMusatahaContract.PaymentSubmit(cookies, args);

            return result.Match(Ok, Problem);
        }

        [HttpPost("print-contract")]
        public async Task<IActionResult> PrintContract(string args)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.RegisterMusatahaContract.PrintContract(cookies, args);

            return result.Match(Ok, Problem);
        }

        [HttpPost("print-submit")]
        public async Task<IActionResult> PrintSubmit(string args, BackOfficeModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.RegisterMusatahaContract.PrintSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        #endregion POST

        #region GET

        [HttpGet("step-info")]
        public async Task<IActionResult> GetStepInfo(string args)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.RegisterMusatahaContract.GetStepInfo(cookies, args);

            return result.Match(Ok, Problem);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}