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
    [Route("demolition-and-convert-public-house-to-residential-land")]
    public class DemolitionAndConvertPublicHouseToResidentialLandController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis,logger)
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

            var result = await _rest.DemolitionAndConvertPublicHouseToResidentialLand.StartWorkflow(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("step-info")]
        public async Task<IActionResult> GetStepInfo(string args)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.DemolitionAndConvertPublicHouseToResidentialLand.GetStepInfo(cookies, args);

            return result.Match(Ok, Problem);
        }

        [HttpPost("registration-cancel")]
        public async Task<IActionResult> RegistrationCancel(string args, CommentModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.DemolitionAndConvertPublicHouseToResidentialLand.RegistrationCancel(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("registration-submit")]
        public async Task<IActionResult> RegistrationSubmit(string args, PublicHouseToResidentialLandRegistrationSubmitRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.DemolitionAndConvertPublicHouseToResidentialLand.RegistrationSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("audit-submit")]
        public async Task<IActionResult> AuditSubmit(string args, BackOfficeModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.DemolitionAndConvertPublicHouseToResidentialLand.AuditSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("audit-back")]
        public async Task<IActionResult> AuditBack(string args, CommentModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.DemolitionAndConvertPublicHouseToResidentialLand.AuditBack(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("inspection-submit")]
        public async Task<IActionResult> InspectionSubmit(string args, BackOfficeModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.DemolitionAndConvertPublicHouseToResidentialLand.InspectionSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("inspection-back")]
        public async Task<IActionResult> InspectionBack(string args, CommentModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.DemolitionAndConvertPublicHouseToResidentialLand.InspectionBack(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("tdp-audit-submit")]
        public async Task<IActionResult> TDPAuditSubmit(string args, BackOfficeModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.DemolitionAndConvertPublicHouseToResidentialLand.TDPAuditSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("tpd-approval-back")]
        public async Task<IActionResult> TPDApprovalBack(string args, CommentModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.DemolitionAndConvertPublicHouseToResidentialLand.TPDApprovalBack(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("completion-back")]
        public async Task<IActionResult> CompletionBack(string args, CommentModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.DemolitionAndConvertPublicHouseToResidentialLand.CompletionBack(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("completion-approve")]
        public async Task<IActionResult> CompletionApprove(string args, BackOfficeModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.DemolitionAndConvertPublicHouseToResidentialLand.CompletionApprove(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        #endregion POST

        #endregion End Points

        #endregion Methods
    }
}