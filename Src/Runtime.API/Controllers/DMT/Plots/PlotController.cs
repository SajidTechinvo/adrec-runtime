using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.Common.Lookups;
using Runtime.RestClient.Interfaces.Unit;

namespace Runtime.API.Controllers.DMT.Plots
{
    [Route("plot")]
    public class PlotController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis, logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region GET

        [HttpGet("detail/{id}")]
        public async Task<IActionResult> GetPlotDetail(long id)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.Plot.GetPlotDetails(cookies, id);

            return result.Match(data => Ok(data.Result), Problem);
        }

        [HttpGet("owner/{id}")]
        public async Task<IActionResult> GetPlotOwner(long id)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.Plot.GetPlotOwners(cookies, id);

            return result.Match(data => Ok(data.Result), Problem);

        }

        [HttpGet("profile")]
        public async Task<IActionResult> FetchPlotProfile(string args)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.Plot.FetchPlotProfile(cookies, args);

            return result.Match(Ok, Problem);
        }

        [HttpGet("profile-services")]
        public async Task<IActionResult> FetchPlotProfileServices(string args)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.Plot.FetchPlotProfileServices(cookies, args);

            return result.Match(Ok, Problem);
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchPlots(
            int requestId, string municipality, string landuseId, string zone, string publicHouseNo,
            string sector, string roadId, string plotNumber, string plotFileNumber, SearchMatchType matchTypeId,
            int pageSize, string searchPlotFlags, string searchOwnerFlags, string ownerId, int pageNumber,
            int totalCount)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.Plot.SearchPlots(cookies, requestId, municipality, landuseId, zone,
                            publicHouseNo, sector, roadId, plotNumber, plotFileNumber, matchTypeId.ToString(), pageSize,
                            searchPlotFlags, searchOwnerFlags, ownerId, pageNumber, totalCount);

            return result.Match(data => Ok(data.Result), Problem);
        }

        [HttpGet("tenancy-contract/{id}")]
        public async Task<IActionResult> FetchPlotByTenancyContractId(string args, long id)
        {
            var cookies = await GetCookies(RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1]);

            var result = await _rest.Plot.FetchPlotByTenancyContractId(cookies, args, id);

            return result.Match(data => Ok(data.Result), Problem);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}