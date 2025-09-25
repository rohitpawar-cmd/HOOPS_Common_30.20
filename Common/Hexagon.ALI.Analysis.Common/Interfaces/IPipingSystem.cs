using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IPipingSystem
    {
        [RelDef("OwnsAnalysisLoadCase", true)]
        List<AnalysisLoadCase> OwnsAnalysisLoadCase { get; set; }

        [RelDef("OwnsAnalysisNode", true)]
        List<AnalysisNode> OwnsAnalysisNode { get; set; }

        [RelDef("OwnsAnalysisLineElements", true)]
        List<AnalysisLineElement> OwnsAnalysisLineElements { get; set; }

        [RelDef("OwnsAnalysisOperatingPrimitive", true)]
        List<AnalysisOperatingPrimitive> OwnsAnalysisOperatingPrimitive { get; set; }

        [RelDef("OwnsAnalysisLoadCasePrimitive", true)]
        List<AnalysisLoadCasePrimitive> OwnsAnalysisLoadCasePrimitive { get; set; }
    }
}
