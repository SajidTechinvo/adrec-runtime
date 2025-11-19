using System.ComponentModel.DataAnnotations;
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
    }


    public class DmtSsoLoginRequest
    {
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        [JsonPropertyName("customerNameE")]
        public string CustomerNameE { get; set; }

        [JsonPropertyName("customerNameA")]
        public string CustomerNameA { get; set; }

        [JsonPropertyName("idCardExpiryDate")]
        public string IdCardExpiryDate { get; set; }

        [JsonPropertyName("uaepassuuid")]
        public string Uaepassuuid { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonPropertyName("nationalNumber")]
        public string NationalNumber { get; set; }

        [JsonPropertyName("userType")]
        public string UserType { get; set; }

        [JsonPropertyName("DeviceId")]
        public string DeviceId { get; set; }

        [JsonPropertyName("DeviceLang")]
        public string DeviceLang { get; set; }

        [JsonPropertyName("SourceSystem")]
        public string SourceSystem { get; set; }

        [JsonPropertyName("SourceSystemValue")]
        public string SourceSystemValue { get; set; }
    }

    public class SsoLoginRequest
    {
        public string Code { get; set; }
        public string State { get; set; }
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

    public class LogoutResponse
    {
        public string Message { get; set; }
    }

    public class SsoLoginResponse
    {
        [JsonPropertyName("displayNameA")]
        public string DisplayNameA { get; set; }

        [JsonPropertyName("displayNameE")]
        public string DisplayNameE { get; set; }

        [JsonPropertyName("applicationInboxNameA")]
        public string ApplicationInboxNameA { get; set; }

        [JsonPropertyName("applicationInboxNameE")]
        public string ApplicationInboxNameE { get; set; }

        [JsonPropertyName("urlArgs")]
        public string UrlArgs { get; set; }

        [JsonPropertyName("authCode")]
        public string AuthCode { get; set; }

        [JsonPropertyName("userId")]
        public int UserId { get; set; }

        [JsonPropertyName("customerId")]
        public int CustomerId { get; set; }
    }

    public class UaePassUserInfoResponse
    {
        [JsonPropertyName("sub")]
        public string Sub { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("nationalityEN")]
        public string NationalityEN { get; set; }

        [JsonPropertyName("firstnameEN")]
        public string FirstnameEN { get; set; }

        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        [JsonPropertyName("lastnameEN")]
        public string LastnameEN { get; set; }

        [JsonPropertyName("fullnameEN")]
        public string FullnameEN { get; set; }

        [JsonPropertyName("userType")]
        public string UserType { get; set; }

        [JsonPropertyName("nationalityAR")]
        public string NationalityAR { get; set; }

        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }
    }

    #endregion Response
}