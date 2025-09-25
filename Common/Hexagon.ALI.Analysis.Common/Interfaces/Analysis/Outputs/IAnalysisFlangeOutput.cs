using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs
{
    public interface IAnalysisFlangeOutput
    {
        [PPMProperty(nameof(Ratio), nameof(IAnalysisFlangeOutput))]
        double Ratio { get; set; }

        [UoM("StressUoM")]
        [PPMProperty(nameof(AllowablePreassure), nameof(IAnalysisFlangeOutput))]
        string AllowablePreassure { get; set; }
        double? AllowablePreassureSiValue { get; }
        [UoM("LengthUoM")]
        [PPMProperty(nameof(G_C), nameof(IAnalysisFlangeOutput))]
        string G_C { get; set; }
        double? G_CSiValue { get; }
        [UoM("MomentOutputUoM")]
        [PPMProperty(nameof(Bending), nameof(IAnalysisFlangeOutput))]
        string Bending { get; set; }
        double? BendingSiValue { get; }
    }
}
