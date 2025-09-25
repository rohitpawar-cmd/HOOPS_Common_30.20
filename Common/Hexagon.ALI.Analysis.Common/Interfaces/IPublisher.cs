using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Models;
using System;
using System.Threading.Tasks;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{

    public interface IPublisher
    {
        Task<ExecutionMetadata> PersistPipingSystemAsync(PipingSystem ps);
        Task<PipingSystem> GetPipingSystemAsync();
        void SetLogStartLine(Func<string> getLogStartLine);
    }
}
