using Moq;

namespace Hexagon.ALI.Analysis.Common.Entities.L0.Tests
{

    public class UtilitiesTests
    {
        private readonly Mock<Func<int>> mockFunc = new Mock<Func<int>>();
        private readonly Mock<Func<int, string>> mockoneFunc = new Mock<Func<int, string>>();
        private readonly Mock<Func<int, string, double>> mocktwoFunc = new Mock<Func<int, string, double>>();
        private readonly Mock<Func<int, string, double, float>> mockthreeFunc = new Mock<Func<int, string, double, float>>();
        private readonly Mock<Func<int, string, double, float, object>> mockfourFunc = new Mock<Func<int, string, double, float, object>>();


        public interface TestAsync
        {
            Task<string> GetString();
        }
        private async Task<string> TestAsyncExecutionWithoutRetry(TestAsync test)
        {
            var s = await test.GetString();
            return s;
        }

    }
}


