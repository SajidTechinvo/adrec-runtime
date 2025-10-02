using ErrorOr;

namespace Runtime.Common.Errors
{
    public partial class Errors
    {
        public static Error UnauthorizedAPI(string description) => Error.Custom(1401, "Unauthorized", description);

        public static Error NotFoundAPI(string description) => Error.Custom(1404, "Not Found", description);

        public static Error MethodNotAllowed() => Error.Custom(1405, "Method Not Allowed", "Method Not Allowed");

        public static Error BadRequest(string description) => Error.Custom(1400, "Bad Request", description);
    }
}