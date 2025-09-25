using System;
using System.IO;

namespace Hexagon.ALI.Analysis.Common.Helpers
{
    internal class LaunchSettingsFixture : IDisposable
    {
        public string TenantId;
        public string Token;

        public string SamToken;
        public TestConfiguration TestsConfiguration;

        public class TokenResponse
        {
            public string Access_token { get; set; }
        }


        public LaunchSettingsFixture()
        {
            //Need to pass test configuration from json for test with different configurations
            TestsConfiguration = new TestConfiguration();

            if (TestsConfiguration.PRINT_LOGS)
            {
                if (File.Exists("NLog.config"))
                {
                    NLog.LogManager.Configuration = new NLog.Config.XmlLoggingConfiguration("NLog.config");
                }
            }

            TestsConfiguration.SetEnvironmentVariables();
        }


        public void Dispose()
        {
            TestsConfiguration.DisposeEnvironmentVariables();
            GC.SuppressFinalize(this);
        }

    }
}
