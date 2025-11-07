using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.RestClient.Interfaces.Unit;

namespace Runtime.API.Controllers.DMT.Profiles
{
    [Route("start-action")]
    public class StartActionController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis, logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region GET

        [HttpGet("")]
        public async Task<IActionResult> GetStartAction()
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            return (await _rest.Profile.GetStartActionResponse(cookies)).Match(Ok, Problem);
        }

        [HttpGet("my-services")]
        public async Task<IActionResult> GetMyServices()
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            return (await _rest.Profile.GetMyServiceResponse(cookies)).Match(data => Ok(data.Result), Problem);
        }

        [HttpGet("popular-services")]
        public async Task<IActionResult> GetPopularServices()
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            return (await _rest.Profile.GetPopularServiceResponse(cookies)).Match(success => Ok(success.Result.Take(10)), Problem);
        }

        [HttpGet("overview")]
        public async Task<IActionResult> GetServiceOverview(string args)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            return (await _rest.Profile.GetServiceOverview(cookies)).Match(Ok, Problem);
        }

        [HttpGet("detail")]
        public async Task<IActionResult> GetServiceDetail(string args)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            return (await _rest.Profile.GetServiceDetails(cookies)).Match(Ok, Problem);
        }

        [HttpGet("active-services")]
        public async Task<IActionResult> GetActiveServices()
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.Profile.GetActiveServiceResponse(cookies);

            return result.Match(data => Ok(data.Result), Problem);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}