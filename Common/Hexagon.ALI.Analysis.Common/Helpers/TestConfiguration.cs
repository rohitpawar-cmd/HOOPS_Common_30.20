using System;
using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Helpers
{
    [ExcludeFromCodeCoverage]
    internal class TestConfiguration
    {
        public string TENANT_ID = "1";
        public string PREFIX = "http://";
        public string URI = "localhost";
        public bool RESET_DB = true;
        public bool GET_SAM_TOKEN = false;
        public bool PRINT_LOGS = true;
        public string DB_NAME = "SDXDEV";
        public string CONNECTION_STRING = "Server=localhost,1434;MultipleActiveResultSets=True;User ID=sa;Password=Password.100;TrustServerCertificate=True;Encrypt=false";

        public string SCHEMA_SERVICE_ADDRESS
        {
            get { return $"{PREFIX}{URI}:5006"; }
        }

        public string DATA_ACCESS_SERVICE_ADDRESS
        {
            get { return $"{PREFIX}{URI}:5001"; }
        }

        public string CONFIG_SERVICE_ADDRESS_V2
        {
            get { return $"{PREFIX}{URI}:5033"; }
        }
        public void SetEnvironmentVariables()
        {
            Environment.SetEnvironmentVariable("SCHEMA_SERVICE_ADDRESS", SCHEMA_SERVICE_ADDRESS);
            Environment.SetEnvironmentVariable("DATA_ACCESS_SERVICE_ADDRESS", DATA_ACCESS_SERVICE_ADDRESS);
            Environment.SetEnvironmentVariable("CONFIG_SERVICE_ADDRESS_V2", CONFIG_SERVICE_ADDRESS_V2);
            Environment.SetEnvironmentVariable("PPM_REDIS_CONNECTION_STRING", $"{URI}:6379,allowAdmin=True,connectTimeout=500,defaultDatabase=1,ssl=False,abortConnect=False,connectRetry=3");
            Environment.SetEnvironmentVariable("AMQP_MESSAGE_SERVICE_ADDRESS", $"{URI}:5011");
            Environment.SetEnvironmentVariable("PPM_CONFIG_CACHE_MOCK", $"{URI},allowAdmin=True,connectTimeout=500,defaultDatabase=1,ssl=False,abortConnect=False,connectRetry=3");
        }

        public void DisposeEnvironmentVariables()
        {
            Environment.SetEnvironmentVariable("SCHEMA_SERVICE_ADDRESS", string.Empty);
            Environment.SetEnvironmentVariable("DATA_ACCESS_SERVICE_ADDRESS", string.Empty);
            Environment.SetEnvironmentVariable("CONFIG_SERVICE_ADDRESS_V2", string.Empty);
            Environment.SetEnvironmentVariable("PPM_REDIS_CONNECTION_STRING", string.Empty);
            Environment.SetEnvironmentVariable("AMQP_MESSAGE_SERVICE_ADDRESS", string.Empty);
            Environment.SetEnvironmentVariable("PPM_CONFIG_CACHE_MOCK", string.Empty);
        }
    }
}
