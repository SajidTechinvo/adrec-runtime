namespace Runtime.RestClient.Interfaces
{
    public interface IAmazonClient
    {
        Task<string> ReadFileAsync(string fileName);
    }
}
