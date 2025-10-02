using ADREC.DTO.ApiModels.DMTModel.Common;
using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.RestClient.Interfaces.Unit;
using System.Net;

namespace Runtime.API.Controllers.DMT.Lookup
{
    [Route("fetch-authority-source-type")]
    public class FetchAuthoritySourceTypeController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly IRedisCacheService _redis = redis;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region POST

        [HttpPost("{requestId}")]
        public async Task<IActionResult> FetchAuthoritySourceTypeLookups(long requestId, string args)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.Lookup.FetchAuthoritySourceTypeLookups(cookies, args, requestId);

            return result.Match(Ok, Problem);
        }

        [HttpPost("fetch-by-type-id")]
        public async Task<IActionResult> FetchAuthoritySourcesByAuthoritySourceTypeId(string args, FetchAuthoritySourcesByAuthoritySourceTypeIdRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.Lookup.FetchAuthoritySourcesByAuthoritySourceTypeId(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        #endregion POST

        #endregion End Points

        #endregion Methods
    }
}