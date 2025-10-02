namespace Runtime.API.Caching
{
    public interface IRedisCacheService
    {
        Task SetCacheValueAsync<T>(string key, T value, TimeSpan? expiration = null);

        Task<T> GetCacheValueAsync<T>(string key);
    }
}