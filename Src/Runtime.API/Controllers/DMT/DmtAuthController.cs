using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Runtime.API.Caching;
using Runtime.API.Controllers.Base;
using Runtime.Common.Errors.Exceptions;
using Runtime.Common.JWT;
using Runtime.Common.Settings;
using Runtime.DTO.ApiModels.Common;
using Runtime.RestClient.Interfaces.Unit;
using System.Security.Claims;

namespace Runtime.API.Controllers.DMT
{
    [Route("dmt")]
    public class DmtAuthController(IRedisCacheService redis, IJwtTokenGenerator jwt,
                                     ILogger logger, IRestClientUnit rest, IOptions<UaePassSettings> options) : ApiController(redis, logger)
    {
        #region Private Fields

        private readonly IRestClientUnit _rest = rest;
        private readonly UaePassSettings _settings = options.Value;
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
                await _redis.SetCacheValueAsync(model.Email, cookies);

                Response.Cookies.Append("token", token, new CookieOptions
                {
                    HttpOnly = true,
                    Secure = false,
                    SameSite = SameSiteMode.Lax,
                    Expires = DateTime.UtcNow.AddMinutes(30)
                });

                return Ok();
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
            await _redis.SetCacheValueAsync(model.Email, cookies);

            Response.Cookies.Append("token", token, new CookieOptions
            {
                HttpOnly = true,
                Secure = false,
                SameSite = SameSiteMode.Lax,
                Expires = DateTime.UtcNow.AddMinutes(30)
            });

            return Ok();
        }

        [HttpPost("logout")]
        [ProducesResponseType(200, Type = typeof(object))]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("token", new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.None
            });

            return Ok(new LogoutResponse() { Message = "Logged out successfully" });
        }

        [AllowAnonymous]
        [HttpPost("sso-login")]
        [ProducesResponseType(200, Type = typeof(object))]
        public async Task<IActionResult> SSOLogin(SsoLoginRequest model)
        {
            var uaePassUser = await _rest.Auth.GetUAEPassUserInfo(model.Code, model.State);
            if (uaePassUser.IsError) return Problem(uaePassUser.Errors);

            var dmtSsoLoginRequest = new DmtSsoLoginRequest
            {
                Email = uaePassUser.Value.Email,
                Uuid = uaePassUser.Value.Uuid,
                CustomerNameA = uaePassUser.Value.FirstnameEN,
                CustomerNameE = uaePassUser.Value.FirstnameEN,
                NationalNumber = "784199268747468",
                Mobile = uaePassUser.Value.Mobile,
                UserType = uaePassUser.Value.UserType,
                DeviceId = _settings.DeviceId,
                DeviceLang = _settings.DeviceLang,
                SourceSystem = _settings.SourceSystem,
                SourceSystemValue = _settings.SourceSystemValue
            };

            var ssoLoginResponse = await _rest.Auth.DmtSsoLogin(dmtSsoLoginRequest);
            if (ssoLoginResponse.IsError) return Problem(ssoLoginResponse.Errors);

            return Ok(ssoLoginResponse.Value);
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