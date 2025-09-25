using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowableCANZ662
    {
        [PPMProperty(nameof(LocationFactor), nameof(IAnalysisMaterialAllowableCANZ662))]
        double? LocationFactor { get; set; }

        [PPMProperty(nameof(TemperatureDeratingFactor), nameof(IAnalysisMaterialAllowableCANZ662))]
        double? TemperatureDeratingFactor { get; set; }

        [PPMProperty(nameof(ConditionADesignFactor), nameof(IAnalysisMaterialAllowableCANZ662))]
        double? ConditionADesignFactor { get; set; }

        [PPMProperty(nameof(ConditionBDesignFactor), nameof(IAnalysisMaterialAllowableCANZ662))]
        double? ConditionBDesignFactor { get; set; }

        [PPMProperty(nameof(LongitudinalWeldJointEfficiency), nameof(IAnalysisMaterialAllowableCANZ662))]
        double? LongitudinalWeldJointEfficiency { get; set; }

        [PPMProperty(nameof(RestrainedFactor), nameof(IAnalysisMaterialAllowableCANZ662))]
        double? RestrainedFactor { get; set; }

        [PPMProperty(nameof(MinimumYieldStrength), nameof(IAnalysisMaterialAllowableCANZ662))]
        double? MinimumYieldStrength { get; set; }
    }
}
