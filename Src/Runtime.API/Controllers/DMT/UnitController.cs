using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.RestClient.Interfaces.Unit;
using System.Net;

namespace Runtime.API.Controllers.DMT
{
    [Route("unit")]
    public class UnitController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly IRedisCacheService _redis = redis;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region GET

        [HttpGet("")]
        public async Task<IActionResult> SearchUnit(
            string args, int requestId, string createUrlArgs, string municipalityId, string districtId,
            string communityId, string roadId, string plotNumber, string landuseId, string buildingNumber,
            string flourNumber, string unitNumber, string unitClassificationId, MatchType matchTypeId, int pageSize,
            string searchPlotFlags, string searchOwnerFlags, string ownerId, int pageNumber, int totalCount)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            return (await _rest.Unit.SearchUnits(
                cookies, args, requestId, createUrlArgs, municipalityId, districtId, communityId, roadId,
                plotNumber, landuseId, buildingNumber, flourNumber, unitNumber, unitClassificationId, matchTypeId,
                pageSize, searchPlotFlags, searchOwnerFlags, ownerId, pageNumber, totalCount)).Match(Ok, Problem);
        }

        [HttpGet("detail/{id}")]
        public async Task<IActionResult> UnitDetails(string args, long id)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            return (await _rest.Unit.GetUnitDetails(cookies, args, id)).Match(Ok, Problem);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}