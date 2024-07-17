using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guests_GuestApp.Service
{
    internal static class ConfigService
    {
        public static string GetConnectionString()
        {
            IConfiguration builder = new ConfigurationBuilder()
 .AddJsonFile("DAL/secrets.json", optional: true) // Add secrets.json
 .Build();
            // Read a value from the configuration
            return builder["ConnectionString"];
        }
    }
}
