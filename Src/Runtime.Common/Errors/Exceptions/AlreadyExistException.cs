namespace Runtime.Common.Errors.Exceptions
{
    public class AlreadyExistException(string message) : Exception($"{message} already exist")
    { }
}