using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.DTO.ApiModels.DMTModel.ElmsPayment;
using Runtime.RestClient.Interfaces.Unit;

namespace Runtime.API.Controllers.DMT.ElmsPayment
{
    [Route("payment")]
    public class PaymentController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis, logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region POST

        [HttpPost("print-payment-slip")]
        public async Task<IActionResult> PrintPaymentSlip(string args, PrintPaymentSlipRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var applicationName = User.Claims.First(f => f.Type == "Application").Value;

            var cookies = await GetCookies(token, applicationName);

            var result = await _rest.Payment.PrintPaymentSlip(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("override-payment")]
        public async Task<IActionResult> OverridePayment(string args, OverridePaymentRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var applicationName = User.Claims.First(f => f.Type == "Application").Value;

            var cookies = await GetCookies(token, applicationName);

            var result = await _rest.Payment.OverridePayment(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("verify-payment")]
        public async Task<IActionResult> VerifyPayment(string args, VerifyPaymentRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var applicationName = User.Claims.First(f => f.Type == "Application").Value;

            var cookies = await GetCookies(token, applicationName);

            var result = await _rest.Payment.VerifyPayment(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        #endregion POST

        #endregion End Points

        #endregion Methods
    }
}