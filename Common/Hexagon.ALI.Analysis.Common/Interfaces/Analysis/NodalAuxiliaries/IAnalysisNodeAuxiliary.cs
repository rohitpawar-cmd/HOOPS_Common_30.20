using Hexagon.ALI.Analysis.Common.Classes.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries
{
    public interface IAnalysisNodeAuxiliary
    {
        [RelDef("AnalysisNodeAuxiliaryToAnalysisNode", false, true)]
        AnalysisNode AnalysisNode { get; set; }
    }
    public interface IAnalysisNodeAuxiliaryOutput
    {
        [RelDef("AnalysisNodeAuxiliaryToAnalysisLoadCase", false, true)]
        AnalysisLoadCase AnalysisLoadCase { get; set; }
    }
}
