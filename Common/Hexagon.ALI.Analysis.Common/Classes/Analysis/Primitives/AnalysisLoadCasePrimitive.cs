using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives
{
    public class AnalysisLoadCasePrimitive : AnalysisPrimitive, IAnalysisLoadCasePrimitive
    {
        [RelDef()] public AnalysisLoadCase LoadCase { get; set; }

        public string LoadCaseID { get; set; }
    }
}
