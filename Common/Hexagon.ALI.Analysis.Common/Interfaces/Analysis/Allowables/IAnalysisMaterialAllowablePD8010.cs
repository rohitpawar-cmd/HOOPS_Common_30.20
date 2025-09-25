using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowablePD8010
    {
        [PPMProperty(nameof(WeldJointFactor), nameof(IAnalysisMaterialAllowablePD8010))]
        double? WeldJointFactor { get; set; }

        [PPMProperty(nameof(RestrainedFactor), nameof(IAnalysisMaterialAllowablePD8010))]
        double? RestrainedFactor { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(MinimumYieldStress), nameof(IAnalysisMaterialAllowableGPTCZ380))]
        string MinimumYieldStress { get; set; }
        double? MinimumYieldStressSiValue { get; }

        [PPMProperty(nameof(DesignFactor), nameof(IAnalysisMaterialAllowablePD8010))]
        double? DesignFactor { get; set; }

        [PPMProperty(nameof(DesignFactorTable2), nameof(IAnalysisMaterialAllowablePD8010))]
        double? DesignFactorTable2 { get; set; }
    }
}
