﻿using Microsoft.Extensions.Configuration;

namespace Negocio.Helper
{
    internal class ApplicationConfiguration
    {
        private static IConfigurationRoot _configuration;

        static ApplicationConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("negociosettings.json", optional: true, reloadOnChange: true);
            _configuration = builder.Build();
        }

        public static string GetSetting(string key)
        {
            return (
                (_configuration != null && _configuration[key] != null) ? _configuration[key]! : ""
            );
        }
    }
}
