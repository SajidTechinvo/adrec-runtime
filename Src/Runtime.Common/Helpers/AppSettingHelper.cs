using Microsoft.Extensions.Configuration;
using Runtime.Common.Errors.Exceptions;
using System.Diagnostics;

namespace Runtime.Common.Helpers
{
    public static class AppSettingHelper
    {
        #region Private Methods

        private static string GetSettingValue(string parentKey, string childKey)
        {
            try
            {
                IConfigurationRoot configuration = GetSettingConfiguration();

                if (!configuration.GetSection(parentKey).Exists())
                {
                    throw new NotFoundException(parentKey);
                }

                if (!configuration.GetSection(parentKey).GetSection(childKey).Exists())
                {
                    throw new NotFoundException(childKey);
                }

                return configuration.GetSection(parentKey).GetSection(childKey).Value;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        private static IConfigurationRoot GetSettingConfiguration()
        {
            try
            {
                var env = string.Empty;
                var currentEnv = $"{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}";
                if (!string.IsNullOrWhiteSpace(currentEnv))
                    env = $".{currentEnv}";

                return new ConfigurationBuilder()
                            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                            .AddJsonFile($"appsettings{env}.json")
                            .Build();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        #endregion Private Methods

        #region Fields

        #region Parent Sections

        public const string CustomSettings = "CustomSettings";

        public const string FilePaths = "File_Paths";

        public const string EmailSettings = "Email_Settings";

        #endregion Parent Sections

        #region Child Sections

        public const string Secret = "Secret";

        public const string BaseURL = "Base_Url";

        public const string UserPath = "User_Path";

        public const string AdminPath = "Admin_Path";

        public const string PlayerPath = "Player_Path";

        public const string PostPath = "Post_Path";

        public const string GroupPath = "Group_Path";
        public const string StoryPath = "Story_Path";
        public const string EventPath = "Event_Path";
        public const string ChatPath = "Chat_Path";
        public const string BadgePath = "Badge_Path";
        public const string StatPath = "Stat_Path";
        public const string BucketName = "Bucket_Name";
        public const string NotificationPath = "Notification_Path";

        #endregion Child Sections

        #endregion Fields

        #region Methods

        #region Custom Settings

        public static string GetSecret()
        {
            return GetSettingValue(CustomSettings, Secret);
        }

        public static string GetBaseURL()
        {
            return GetSettingValue(CustomSettings, BaseURL);
        }

        public static string GetServiceBuilderUrl() => GetSettingValue("CustomSettings", "ServiceBuilderUrl");

        public static string[] GetOrigins()
        {
            IConfigurationRoot configuration = GetSettingConfiguration();

            if (!configuration.GetSection("Origins").Exists())
            {
                throw new NotFoundException("Origins");
            }

            return configuration.GetSection("Origins").GetChildren().Select(s => s.Value).ToArray();
        }

        public static string GetEmailApiKey() => GetSettingValue("EmailSettings", "ApiKey");

        public static string GetHostURL() => GetSettingValue("CustomSettings", "HostURL");

        public static string GetRedisConnection() => GetSettingValue("CustomSettings", "Redis");

        public static bool UseRedis() => bool.Parse(GetSettingValue("CustomSettings", "UseRedis"));

        public static string GetSwaggerURL() => GetSettingValue("CustomSettings", "SwaggerURL");

        #endregion Custom Settings

        #region Connection Strings

        public static string GetDefaultConnection()
        {
            return GetSettingValue("ConnectionStrings", "DefaultConnection");
        }

        #endregion Connection Strings

        #region File Paths

        public static string GetDataPath() => GetSettingValue("FilePaths", "Data");

        #endregion File Paths

        #endregion Methods
    }
}