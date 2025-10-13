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
    [Route("plot-demarcation")]
    public class PlotDemarcationController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis,logger)
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

            var result = await _rest.PlotDemarcation.StartWorkflow(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("step-info")]
        public async Task<IActionResult> GetStepInfo(string args)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.PlotDemarcation.GetStepInfo(cookies, args);

            return result.Match(Ok, Problem);
        }

        [HttpPost("registration-cancel")]
        public async Task<IActionResult> RegistrationCancel(string args, CommentModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.PlotDemarcation.RegistrationCancel(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("registration-submit")]
        public async Task<IActionResult> RegistrationSubmit(string args, RegisterPlotDemarcationRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.PlotDemarcation.RegistrationSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("print-appointment-slip")]
        public async Task<IActionResult> PrintAppointmentSlip(string args, PrintAppointmentSlipPlotDemarcationRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.PlotDemarcation.PrintAppointmentSlip(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("assign-survey-appointment-submit")]
        public async Task<IActionResult> AssignSurveyAppointmentSubmit(string args, AssignSurveyAppointmentSubmitPlotDemarcationRequest model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.PlotDemarcation.AssignSurveyAppointmentSubmit(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        [HttpPost("completion-approve")]
        public async Task<IActionResult> CompletionApprove(string args, BackOfficeModel model)
        {
            var token = RequestHelper.GetAuthorizationToken(HttpContext.Request).Split(" ")[1];

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(token);

            var result = await _rest.PlotDemarcation.CompletionApprove(cookies, args, model);

            return result.Match(Ok, Problem);
        }

        #endregion POST

        #endregion End Points

        #endregion Methods
    }
}