using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.DTO.ApiModels.DMTModel;
using Runtime.RestClient.Interfaces.Unit;
using System.Net;

namespace Runtime.API.Controllers.DMT
{
    [Route("partial-block")]
    public class PartialBlockController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis,logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly IRedisCacheService _redis = redis;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region POST

        [HttpPost("")]
        public async Task<IActionResult> AddPartialBlockTxnWorkflows(string args, AddPartialBlockWorkflowRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.PartialBlock.AddPartialBlockTxnWorkflows(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        #endregion POST

        #region GET

        [HttpGet("workflow/{id}")]
        public async Task<IActionResult> GetWorkflows(string args, long id)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.PartialBlock.GetWorkflows(cookies, args, id);

            return result.Match(Ok, Problem);
        }

        [HttpGet("workflow-types/{id}")]
        public async Task<IActionResult> GetWorkflowTypes(string args, long id)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.PartialBlock.GetWorkflowTypes(cookies, args, id);

            return result.Match(Ok, Problem);
        }

        [HttpPost("fetch-txn-workflows/{id}")]
        public async Task<IActionResult> FetchPartialBlockTxnWorkflows(string args, int id)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.PartialBlock.FetchPartialBlockTxnWorkflows(cookies, args, id);

            return result.Match(Ok, Problem);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}