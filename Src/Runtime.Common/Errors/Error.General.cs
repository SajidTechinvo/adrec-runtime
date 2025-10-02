using ErrorOr;

namespace Runtime.Common.Errors
{
    public partial class Errors
    {
        protected Errors()
        {
        }

        public static Error NotFound(string title) => Error.NotFound(code: "Not Found", description: $"{title} not found.");

        public static Error Unauthorized(string message = null) => Error.Unauthorized(code: "Unauthorized", description: message);

        public static Error AlreadyExist(string title) => Error.Conflict(code: "Already exists", description: $"{title} already exists.");

        public static Error UnauthorizedRequest() => Error.Unauthorized(code: "Request unauthorized", description: "Change password request is not authorized");

        public static Error PasswordMismatch() => Error.Unexpected(code: "Invalid Password", description: $"Current password is incorrect");

        public static Error LinkExpired() => Error.Unexpected(code: "Link Expired", description: $"Link expired");

        public static Error IncorrectCode() => Error.Failure(code: "Incorrect Code", description: $"Incorrect Code");

        public static Error CodeExpired() => Error.Failure(code: "Code Expired", description: $"Code Expired");

        public static Error CodeUsed() => Error.Failure(code: "Code already used", description: "Code already used");

        public static Error ResetRequestInvalid() => Error.Failure("Invalid reset request", description: "No reset password request found.");

        public static Error InvalidToken() => Error.Failure("Invalid Token", description: "Invalid Token.");
    }
}