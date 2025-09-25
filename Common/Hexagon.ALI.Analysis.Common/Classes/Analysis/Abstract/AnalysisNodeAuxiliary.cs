using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract
{
    [DefUID("AnalysisNodeAuxiliary")]
    public abstract class AnalysisNodeAuxiliary : AnalysisBaseObject, IAnalysisNodeAuxiliary
    {
        [RelDef()] public AnalysisNode AnalysisNode { get; set; }
        public string AnalysisNodeId { get; set; }
        public AnalysisNodeAuxiliary(AnalysisNode parent = null)
        {
            AnalysisNode = parent;
        }
        public AnalysisLineElement AnalysisLineElement { get; set; }
        public string AnalysisLineElementId { get; set; }
        public override string ToString() => $"{GetType().Name}-N{AnalysisNode.NodeNumber}";
    }
    [DefUID("AnalysisNodeAuxiliaryOuput")]
    public abstract class AnalysisNodeAuxiliaryOutput : AnalysisNodeAuxiliary, IAnalysisNodeAuxiliaryOutput
    {
        [RelDef()] public AnalysisLoadCase AnalysisLoadCase { get; set; }
        public string AnalysisLoadCaseId { get; set; }
        public AnalysisNodeAuxiliaryOutput(AnalysisNode parent = null, AnalysisLoadCase loadCase = null) : base(parent)
        {
            AnalysisLoadCase = loadCase;
            AnalysisNode = parent;
        }

        public override string ToString() => $"{GetType().Name}-L{AnalysisLoadCase.LoadCaseNumber}-N{AnalysisNode.NodeNumber}";
    }
}