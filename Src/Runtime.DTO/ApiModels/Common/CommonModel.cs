﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Runtime.DTO.ApiModels.Common
{
    #region Request

    public class VerifyPhoneModel
    {
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        public int Code { get; set; }
    }

    public class VerifyEmailModel
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }

        public int Code { get; set; }
    }

    public class SetPasswordRequest
    {
        [JsonPropertyName("password")]
        [Required]
        public string Password { get; set; }
    }

    public class ResetPasswordRequest
    {
        [JsonPropertyName("current_password")]
        [Required]
        public string CurrentPassword { get; set; }

        [JsonPropertyName("new_password")]
        [Required]
        public string NewPassword { get; set; }
    }

    public class LoginRequest
    {
        [JsonPropertyName("email")]
        [Required(AllowEmptyStrings = false)]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; }

        public string Token { get; set; }
    }

    public class ForgotPassword
    {
        [JsonPropertyName("email")]
        [Required(AllowEmptyStrings = false)]
        public string Email { get; set; }

        [Required]
        [JsonPropertyName("reset_token")]
        public Guid ResetToken { get; set; }

        [JsonPropertyName("password")]
        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; }
    }

    public class CreatePasswordRequest
    {
        [JsonPropertyName("password")]
        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; }
    }

    public class EmailModel
    {
        [EmailAddress]
        [JsonPropertyName("email")]
        [Required(AllowEmptyStrings = false)]
        public string Email { get; set; }

        public bool IsForgetRequest { get; set; }
    }

    public class PhoneModel
    {
        [JsonPropertyName("phone")]
        [Required(AllowEmptyStrings = false)]
        public string Phone { get; set; }
    }

    #endregion Request

    #region Response

    public class LoginResponse<TData>
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; } = "bearer";

        public TData User { get; set; }

        public string Role { get; set; }
    }

    public class IdAndName
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class IdAndValue
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class IdAndValue<T>
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public T Value { get; set; }
    }

    public class ForgotPasswordLinkResponse
    {
        public string Link { get; set; }
    }

    public class ForgetPasswordVerifyCodeResponse
    {
        public string Message { get; set; }
        public Guid Token { get; set; }
    }

    public class SendOtpResponse
    {
        public string Message { get; set; }
        public int Code { get; set; }
    }

    #endregion Response
}