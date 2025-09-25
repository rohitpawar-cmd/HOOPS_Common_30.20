using Hexagon.ALI.Analysis.Common.Helpers;


namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowableGPTCZ380
    {
        [PPMProperty(nameof(LongitudinalWeldJointEfficiency), nameof(IAnalysisMaterialAllowableGPTCZ380))]
        double? LongitudinalWeldJointEfficiency { get; set; }

        [PPMProperty(nameof(ConstructionDesignFactor), nameof(IAnalysisMaterialAllowableGPTCZ380))]
        double? ConstructionDesignFactor { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(MinimumYieldStress), nameof(IAnalysisMaterialAllowableGPTCZ380))]
        string MinimumYieldStress { get; set; }

        double? MinimumYieldStressSiValue { get; }
    }
}
