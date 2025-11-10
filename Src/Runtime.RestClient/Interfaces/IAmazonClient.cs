namespace Runtime.RestClient.Interfaces
{
    public interface IAmazonClient
    {
        Task ReadFileAsync(string fileName);
    }
}
