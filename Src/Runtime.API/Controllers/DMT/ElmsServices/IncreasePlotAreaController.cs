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
    [Route("increase-plot-area")]
    public class IncreasePlotAreaController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis,logger)
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

            var result = await _rest.IncreasePlotArea.StartWorkflow(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("register-submit")]
        public async Task<IActionResult> RegisterSubmit(string args, IncreasePlotAreaRegisterRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.IncreasePlotArea.RegisterSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("assign-engineer")]
        public async Task<IActionResult> AssignEngineerSubmit(string args, IncreasePlotAreaAssignEngineerRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.IncreasePlotArea.AssignEngineerSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("study")]
        public async Task<IActionResult> StudySubmit(string args, IncreasePlotAreaStudyRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.IncreasePlotArea.StudySubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("urban-planning-approval")]
        public async Task<IActionResult> UrbanPlanningApprovalSubmit(string args, BackOfficeModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.IncreasePlotArea.UrbanPlanningApprovalSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("tpd-approval-submit")]
        public async Task<IActionResult> TPDApprovalSubmit(string args, BackOfficeModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.IncreasePlotArea.TPDApprovalSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("initial-site-plan-submit")]
        public async Task<IActionResult> UploadInitialSitePlanSubmit(string args, BackOfficeModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.IncreasePlotArea.UploadInitialSitePlanSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("noc-letter-submit")]
        public async Task<IActionResult> UploadNocLetterSubmit(string args, BackOfficeModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.IncreasePlotArea.UploadNocLetterSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("evaluation-submit")]
        public async Task<IActionResult> EvaluationSubmit(string args, IncreasePlotAreaEvaluationRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.IncreasePlotArea.EvaluationSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("gis-approval")]
        public async Task<IActionResult> GisApproval(string args, BackOfficeModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.IncreasePlotArea.GISApprovalLayerSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("property-registration-approval")]
        public async Task<IActionResult> PropertyRegistrationApproval(string args, BackOfficeModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.IncreasePlotArea.PropertyRegistrationApproval(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("engineer-back")]
        public async Task<IActionResult> EngineerBack(string args, CommentModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.IncreasePlotArea.EngineerBack(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("study-back")]
        public async Task<IActionResult> StudyBack(string args, CommentModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.IncreasePlotArea.StudyBack(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        #endregion POST

        #region GET

        [HttpGet("step-info")]
        public async Task<IActionResult> GetStepInfo(string args)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            return (await _rest.IncreasePlotArea.GetStepInfo(cookies, args)).Match(Ok, Problem);
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}