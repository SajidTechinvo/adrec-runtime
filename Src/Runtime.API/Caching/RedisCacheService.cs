using Runtime.Common.Helpers;
using StackExchange.Redis;
using System.Text.Json;

namespace Runtime.API.Caching
{
    internal class RedisCacheService : IRedisCacheService
    {
        #region Private Fields

        private readonly IDatabase _redis;

        #endregion Private Fields

        #region Constructor

        public RedisCacheService()
        {
            var redis = ConnectionMultiplexer.Connect(AppSettingHelper.GetRedisConnection());

            _redis = redis.GetDatabase();
        }

        #endregion Constructor

        #region Methods

        public async Task SetCacheValueAsync<T>(string key, T value, TimeSpan? expiration = null)
        {
            await _redis.StringSetAsync(key, JsonSerializer.Serialize(value), expiration);
        }

        public async Task<T> GetCacheValueAsync<T>(string key)
        {
            var json = await _redis.StringGetAsync(key);
            if (!json.HasValue) return default;

            return JsonSerializer.Deserialize<T>(json);
        }

        #endregion Methods
    }
}