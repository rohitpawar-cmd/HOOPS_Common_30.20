using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs;
using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries
{
    public interface IAnalysisFlangeCheckYieldStrength
    {
        AnalysisFlangeCheckNC AnalysisFlangeCheckNC { get; set; }
        string AnalysisFlangeCheckNCId { get; set; }

        [UoM("StressUoM")]
        [PPMProperty(nameof(YieldStrength), nameof(IAnalysisFlangeCheckYieldStrength))]
        string YieldStrength { get; set; }
        double? YieldStrengthSiValue { get; }
    }
}
