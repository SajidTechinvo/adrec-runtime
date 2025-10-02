namespace Runtime.Common.Errors.Exceptions
{
    public class BadRequestException(string message) : Exception($"{message}")
    { }
}