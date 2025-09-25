using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IPipeline
    {
        PipingSystem PipingSystem { get; set; }
        [RelDef("PipelineRuns")]
        List<PipeRun> OwnsPipeRuns { get; set; }

    }
}