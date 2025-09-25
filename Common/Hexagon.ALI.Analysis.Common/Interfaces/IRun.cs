using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IRun
    {
        [RelDef("RunBranchPorts")]
        List<BranchEndPort> RunBranchPorts { get; set; }

        [RelDef("RunEnd1BranchPort")]
        BranchEndPort RunEnd1BranchPort { get; set; }
        string RunEnd1BranchPortId { get; set; }

        [RelDef("RunEnd2BranchPort")]
        BranchEndPort RunEnd2BranchPort { get; set; }
        string RunEnd2BranchPortId { get; set; }

    }

}
