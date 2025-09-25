using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IAnalysisNode
    {
        List<AnalysisLineElement> AnalysisLineElementOwners { get; set; }
        PipingSystem PipingSystem { get; set; }

        [PPMProperty("Flags", "IAnalysisNode")]
        int? Flags { get; set; }

        [PPMProperty("InputNodeOrder", "IAnalysisNode")]
        int InputNodeOrder { get; set; }

        [PPMProperty("NodeNumber", "IAnalysisNode")]
        string NodeNumber { get; set; }

        [RelDef("OwnsAnalysisNodeAuxiliaries", true)]
        List<AnalysisNodeAuxiliary> OwnsAnalysisNodeAuxiliaries { get; set; }
    }
}
