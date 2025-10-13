using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.RestClient.Interfaces.Unit;
using System.Net;

namespace Runtime.API.Controllers.DMT.Lookup
{
    [Route("workflow")]
    public class WorkflowController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis,logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly IRedisCacheService _redis = redis;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region GET

        [HttpGet("")]
        public async Task<IActionResult> GetWorkflows()
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            return Ok(await _rest.Lookup.GetWorkflows(cookies));
        }

        [HttpGet("step-type")]
        public async Task<IActionResult> GetWorkflowStepType()
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            return Ok(await _rest.Lookup.GetWorkflowStepType(cookies));
        }

        [HttpGet("popular")]
        [ProducesResponseType(typeof(IEnumerable<object>), StatusCodes.Status200OK)]
        public IActionResult GetPopularWorkflows()
        {
            return Ok(new[]
            {
                new
                {
                    Title = "Land Use and Zoning",
                    Description = "Zoning guidelines and land-use classifications."
                },
                new
                {
                    Title = "Plot Subdivision & Merging",
                    Description = "Enables landowners to divide or merge plots."
                },
                new
                {
                    Title = "Real Estate Transactions & Approvals",
                    Description = "Facilitates property transactions, sales, and title transfers."
                }
            });
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}