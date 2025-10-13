using ADREC.DTO.ApiModels.DMTModel.ElmsServices;
using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Helpers;
using Runtime.DTO.ApiModels.DMTModel.Common;
using Runtime.RestClient.Interfaces.Unit;
using System.Net;

namespace Runtime.API.Controllers.DMT.ElmsServices
{
    [Route("public-house-to-residential-land")]
    public class PublicHouseToResidentialLandController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis,logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly IRedisCacheService _redis = redis;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region POST

        [HttpPost("start")]
        public async Task<IActionResult> StartWorkflow(string args, AddPlotRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.PublicHouseToResidentialLand.StartWorkflow(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("audit")]
        public async Task<IActionResult> AuditSubmit(string args, BackOfficeModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.PublicHouseToResidentialLand.AuditWorkflow(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("audit-back")]
        public async Task<IActionResult> AuditBack(string args, CommentModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.PublicHouseToResidentialLand.AuditBack(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("tpd-audit-submit")]
        public async Task<IActionResult> TDPAuditSubmit(string args, BackOfficeModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.PublicHouseToResidentialLand.TDPAuditSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("completion-approve")]
        public async Task<IActionResult> CompletionApprove(string args, BackOfficeModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.PublicHouseToResidentialLand.CompletionApprove(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("inspection")]
        public async Task<IActionResult> InspectionSubmit(string args, BackOfficeModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.PublicHouseToResidentialLand.InspectionSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("inspection-back")]
        public async Task<IActionResult> InspectionSubmit(string args, CommentModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.PublicHouseToResidentialLand.InspectionBack(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("register-submit")]
        public async Task<IActionResult> RegisterSubmit(string args, PublicHouseToResidentialLandRegistrationSubmitRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.PublicHouseToResidentialLand.RegistrationSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        #endregion POST

        #region GET

        [HttpGet("step-info")]
        public async Task<IActionResult> GetStepInfo(string args)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            return (await _rest.PublicHouseToResidentialLand.GetStepInfo(cookies, args)).Match(Ok, Problem);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}