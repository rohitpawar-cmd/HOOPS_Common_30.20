using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs
{
    public interface IAnalysisFlangeCheckNCOutput
    {
        [UoM("MomentOutputUoM")]
        [PPMProperty(nameof(TorsionMoment), nameof(IAnalysisFlangeCheckNCOutput))]
        string TorsionMoment { get; set; }
        double? TorsionMomentSiValue { get; }
        [UoM("MomentOutputUoM")]
        [PPMProperty(nameof(BendingMoment), nameof(IAnalysisFlangeCheckNCOutput))]
        string BendingMoment { get; set; }
        double? BendingMomentSiValue { get; }
        [UoM("StressUoM")]
        [PPMProperty(nameof(FactoredMoment), nameof(IAnalysisFlangeCheckNCOutput))]
        string FactoredMoment { get; set; }
        double? FactoredMomentSiValue { get; }
        [UoM("StressUoM")]
        [PPMProperty(nameof(YieldStrength), nameof(IAnalysisFlangeCheckNCOutput))]
        string YieldStrength { get; set; }
        double? YieldStrengthSiValue { get; }
        [UoM("AreaUoM")]
        [PPMProperty(nameof(AB), nameof(IAnalysisFlangeCheckNCOutput))]
        string AB { get; set; }
        double? ABSiValue { get; }

        [UoM("DiameterUoM")]
        [PPMProperty(nameof(C), nameof(IAnalysisFlangeCheckNCOutput))]
        string C { get; set; }
        double? CSiValue { get; }
    }
}
