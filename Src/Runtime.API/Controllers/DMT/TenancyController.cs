using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.DTO.ApiModels.DMTModel.ElmsTenancy;
using Runtime.RestClient.Interfaces.Unit;

namespace Runtime.API.Controllers.DMT
{
    [Route("tenancy")]
    public class TenancyController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis, logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region POST

        [HttpPost("calculate-rent-fees")]
        public async Task<IActionResult> CalculateRentFees(string args, CalculateRentFeesRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var applicationName = User.Claims.First(f => f.Type == "Application").Value;

            var cookies = await GetCookies(token, applicationName);

            var result = await _rest.Tenancy.CalculateRentFees(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        #endregion POST

        #region GET

        [HttpGet("late-rent-payment/{id}")]
        public async Task<IActionResult> LateRentPayments(string args, int id)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var applicationName = User.Claims.First(f => f.Type == "Application").Value;

            var cookies = await GetCookies(token, applicationName);

            var result = await _rest.Tenancy.FetchLandLateRentPayments(cookies, args, id);

            return result.Match(Ok, Problem);
        }

        [HttpGet("contracts-list/{plotId}")]
        public async Task<IActionResult> FetchTenancyContractList(string args, int plotId, bool showAll, int tenancyContractCategory)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var applicationName = User.Claims.First(f => f.Type == "Application").Value;

            var cookies = await GetCookies(token, applicationName);

            var result = await _rest.Tenancy.FetchTenancyContractList(cookies, args, plotId, showAll, tenancyContractCategory);

            return result.Match(Ok, Problem);
        }

        [HttpGet("contracts-detail/{id}")]
        public async Task<IActionResult> FetchTenancyContractDetails(string args, int id)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var applicationName = User.Claims.First(f => f.Type == "Application").Value;

            var cookies = await GetCookies(token, applicationName);

            var result = await _rest.Tenancy.FetchTenancyContractDetails(cookies, args, id);

            return result.Match(Ok, Problem);
        }

        [HttpGet("contracts")]
        public async Task<IActionResult> SearchTenancyContracts(string args, string contractNumber, string contractType,
                                                                string matchTypeId, int pageNumber, int pageSize,
                                                                string startDate)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var applicationName = User.Claims.First(f => f.Type == "Application").Value;

            var cookies = await GetCookies(token, applicationName);

            var result = await _rest.Tenancy.SearchTenancyContracts(cookies, args, contractNumber, contractType,
                                                                    matchTypeId, pageNumber, pageSize, startDate);

            return result.Match(Ok, Problem);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}