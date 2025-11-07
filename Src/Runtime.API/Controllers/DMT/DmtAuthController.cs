using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Errors.Exceptions;
using Runtime.Common.JWT;
using Runtime.DTO.ApiModels.Common;
using Runtime.RestClient.Interfaces.Unit;
using System.Security.Claims;

namespace Runtime.API.Controllers.DMT
{
    [Route("dmt")]
    public class DmtAuthController(IRedisCacheService redis, IJwtTokenGenerator jwt,
                                     ILogger logger, IRestClientUnit rest) : ApiController(redis, logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly IRedisCacheService _redis = redis;
        private readonly IJwtTokenGenerator _jwt = jwt;

        #endregion Private Fields

        #region Methods

        #region End Points

        #region POST

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest model)
        {
            string token = "";
            var result = await _rest.Auth.LoginAsync(model.Email, model.Password);
            if (result.IsError) return Problem(result.Errors);

            var cookies = result.Value;
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") != "Production")
            {
                token = _jwt.GenerateToken(model.Email, TimeSpan.FromHours(8));
                await _redis.SetCacheValueAsync(token, cookies);

                return Ok(token);
            }

            var authCookie = cookies.FirstOrDefault(c => c.Name.Equals(".ASPXAUTH", StringComparison.OrdinalIgnoreCase)) ?? throw new NotFoundException(".ASPXAUTH cookie in the response.");

            DateTime expiry;

            if (authCookie.Expires != DateTime.MinValue)
            {
                expiry = authCookie.Expires;
            }
            else
            {
                expiry = DateTime.UtcNow.AddHours(8);
            }

            token = _jwt.GenerateToken(model.Email, expiry - DateTime.UtcNow);
            await _redis.SetCacheValueAsync(token, cookies);

            return Ok(token);
        }

        #endregion POST

        #region GET

        [HttpGet("current")]
        [ProducesResponseType(typeof(object), 200)]
        public IActionResult Current()
        {
            var email = User.Claims.First(f => f.Type.Equals(ClaimTypes.Email)).Value;

            return Ok(new
            {
                email,
                role = "Admin",
                name = "Admin"
            });
        }

        #endregion GET

        #endregion End Points

        #endregion Methods
    }
}