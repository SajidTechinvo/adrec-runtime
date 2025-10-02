namespace Runtime.Common.Errors.Exceptions
{
    public class GeneralException(string message, Exception innerException = null) : Exception($"{message}", innerException)
    { }
}