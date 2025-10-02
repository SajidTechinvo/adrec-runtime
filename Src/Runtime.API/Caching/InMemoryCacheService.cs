using Microsoft.Extensions.Caching.Memory;
using System.Text.Json;

namespace Runtime.API.Caching
{
    internal class InMemoryCacheService(IMemoryCache cache) : IRedisCacheService
    {
        #region Methods

        private readonly IMemoryCache _cache = cache;

        public async Task SetCacheValueAsync<T>(string key, T value, TimeSpan? expiration = null)
        {
            var options = new MemoryCacheEntryOptions();
            if (expiration.HasValue)
                options.SetAbsoluteExpiration(expiration.Value);

            var serialized = JsonSerializer.Serialize(value);
            _cache.Set(key, serialized, options);

            await Task.CompletedTask;
        }

        public async Task<T> GetCacheValueAsync<T>(string key)
        {
            if (_cache.TryGetValue(key, out string serialized))
            {
                return JsonSerializer.Deserialize<T>(serialized);
            }

            return await Task.FromResult(default(T));
        }

        #endregion Methods
    }
}