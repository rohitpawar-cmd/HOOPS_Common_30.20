using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.ComponentModel;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowableB31
    {
        [PPMProperty(nameof(Eff), nameof(IAnalysisMaterialAllowableB31))]
        double? Eff { get; set; }

        [PPMProperty(nameof(MinimumWallThicknessCalculation), nameof(IAnalysisMaterialAllowableB31))]
        double? MinimumWallThicknessCalculation { get; set; }

        [PPMProperty(nameof(DesignFactor), nameof(IAnalysisMaterialAllowableB31))]
        DesignFactor? DesignFactor { get; set; }

        [PPMProperty(nameof(HoopStressFactor), nameof(IAnalysisMaterialAllowableB31))]
        double? HoopStressFactor { get; set; }

        [PPMProperty(nameof(AllowableStressIndicator), nameof(IAnalysisMaterialAllowableB31))]
        AllowableStressIndicator? AllowableStressIndicator { get; set; }

        [PPMProperty(nameof(Fac), nameof(IAnalysisMaterialAllowableB31))]
        double? Fac { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(SpecifiedMinimumYieldStress), nameof(IAnalysisMaterialAllowableB31))]
        string SpecifiedMinimumYieldStress { get; set; }
        double? SpecifiedMinimumYieldStressSiValue { get; }

        [PPMProperty(nameof(CoefficientY), nameof(IAnalysisMaterialAllowableB31))]
        double? CoefficientY { get; set; }

        [PPMProperty(nameof(DesignFactorF), nameof(IAnalysisMaterialAllowableB31))]
        double? DesignFactorF { get; set; }

        [PPMProperty(nameof(AllowMaximumStressRangeFactor), nameof(IAnalysisMaterialAllowableB31))]
        AllowableMaximumStressRange? AllowMaximumStressRangeFactor { get; set; }
    }

    public enum DesignFactor
    {
        [Description("Offshore Pipeline")]
        OffshorePipeline = 0,
        [Description("Offshore Riser/Platform")]
        OffshoreRiser = 1,
        [Description("Custom")]
        Custom = 2,
    }

    public enum AllowableStressIndicator
    {
        [Description("Restrained Pipeline")]
        RestrainedPipeline = 0,
        [Description("Unrestrained Pipeline")]
        UnrestrainedPipeline = 1,
        [Description("CAESAR II Determines")]
        CaesarIIDetermines = 2,
        [Description("Inland Riser/Platform")]
        InlandRiser = 3,
    }

    public enum AllowableMaximumStressRange
    {
        [Description("Off")]
        Off = 0,
        [Description("On")]
        On = 1,
    }
}
