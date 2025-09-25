using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowableStoomwezen
    {
        [UoM("PressureUoM")]
        [PPMProperty(nameof(AverageCreepStress), nameof(IAnalysisMaterialAllowableStoomwezen))]
        string AverageCreepStress { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(AverageCreepTensileStress), nameof(IAnalysisMaterialAllowableStoomwezen))]
        string AverageCreepTensileStress { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(MinimumCreepTensileStress), nameof(IAnalysisMaterialAllowableStoomwezen))]
        string MinimumCreepTensileStress { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(YieldStressDesignTemperature), nameof(IAnalysisMaterialAllowableStoomwezen))]
        string YieldStressDesignTemperature { get; set; }

        [PPMProperty(nameof(CyclicReductionFactor), nameof(IAnalysisMaterialAllowableStoomwezen))]
        double? CyclicReductionFactor { get; set; }

        [PPMProperty(nameof(StoomwezenConstant), nameof(IAnalysisMaterialAllowableStoomwezen))]
        double? StoomwezenConstant { get; set; }

        [PPMProperty(nameof(CoefficientCM), nameof(IAnalysisMaterialAllowableStoomwezen))]
        double? CoefficientCM { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(TensileStrength), nameof(IAnalysisMaterialAllowableStoomwezen))]
        string TensileStrength { get; set; }

        #region SI VALUES
        double? AverageCreepStressSiValue { get; }
        double? AverageCreepTensileStressSiValue { get; }
        double? MinimumCreepTensileStressSiValue { get; }
        double? YieldStressDesignTemperatureSiValue { get; }
        double? TensileStrengthSiValue { get; }
        #endregion
    }
}
