using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.RestClient.Interfaces.Unit;
using System.Net;

namespace Runtime.API.Controllers.DMT.Lookup
{
    [Route("fetch-survey-reason-requester-types")]
    public class FetchSurveyReasonRequesterTypesController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis,logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly IRedisCacheService _redis = redis;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region POST

        /// <summary>
        /// Fetches survey reason requester types based on the provided arguments and ID.
        /// </summary>
        /// <param name="args">Additional arguments for the API.</param>
        /// <param name="id">The requester type ID.</param>
        /// <returns>A list of survey reason requester types.</returns>
        [HttpPost("{id}")]
        public async Task<IActionResult> FetchSurveyReasonRequesterTypes(long id, string args)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.Lookup.FetchSurveyReasonRequesterTypes(cookies, args, id);

            return result.Match(Ok, Problem);
        }

        #endregion POST

        #endregion End Points

        #endregion Methods
    }
}