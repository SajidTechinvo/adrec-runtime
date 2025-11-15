using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.DTO.ApiModels.DMTModel.Profiles;
using Runtime.RestClient.Interfaces.Unit;
using System.Net;
using System.Security.Claims;

namespace Runtime.API.Controllers.DMT.Profiles
{
    [Route("mims-profile")]
    public class ProfileController(IRedisCacheService redis, ILogger logger, IRestClientUnit rest) : ApiController(redis, logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly IRedisCacheService _redis = redis;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region POST

        [HttpPost("switch")]
        public async Task<IActionResult> SwitchMimsProfile(SwitchProfileRequest model)
        {
            var email = User.Claims.First(f => f.Type.Equals(ClaimTypes.Email)).Value;

            var cookies = await _redis.GetCacheValueAsync<List<Cookie>>(email);

            var result = await _rest.Profile.SwitchMimsProfile(cookies, model);

            if (result.IsError)
                return Problem(result.Errors);

            var switchResponse = result.Value;

            await _redis.SetCacheValueAsync(email, switchResponse.Cookies);

            return Ok(switchResponse.Response);
        }

        #endregion POST

        #region GET

        [HttpGet("")]
        public async Task<IActionResult> GetMimsProfile()
        {
            var email = User.Claims.First(f => f.Type.Equals(ClaimTypes.Email)).Value;

            var cookies = await GetCookies(email);

            var result = await _rest.Profile.GetMimsProfile(cookies);

            return result.Match(Ok, Problem);
        }

        [AllowAnonymous]
        [HttpGet("profile")]
        public async Task<IActionResult> GetProfile()
        {
            var result = await _rest.Profile.GetProfile();
            return result.Match(Ok, Problem);
        }

        [HttpGet("performance")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        public IActionResult GetMyPerformance()
        {
            return Ok(new
            {
                Critical = 1,
                Actions = 5,
                Active = 11
            });
        }

        [HttpGet("favorites")]
        [ProducesResponseType(typeof(IEnumerable<object>), StatusCodes.Status200OK)]
        public IActionResult GetFavorites()
        {
            return Ok(new[]
            {
                new
                {
                    Title = "Eid Holiday",
                    Description = "Useful calendar for your planning.",
                    Tags = new[] { "Management", "Vacation" }
                },
                new
                {
                    Title = "ADRC Performance Awards 2025",
                    Description = "Latest updates on date and times.",
                    Tags = new[] { "Performance", "Community", "Event" }
                },
                new
                {
                    Title = "Management Faculty",
                    Description = "eLearning dedicated to improving your management skills",
                    Tags = new[] { "eLearning", "Management" }
                }
            });
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}