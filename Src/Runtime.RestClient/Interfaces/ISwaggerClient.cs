namespace Runtime.RestClient.Interfaces
{
    public interface ISwaggerClient
    {
        Task<string> GetSwaggerJson(string url);
    }
}