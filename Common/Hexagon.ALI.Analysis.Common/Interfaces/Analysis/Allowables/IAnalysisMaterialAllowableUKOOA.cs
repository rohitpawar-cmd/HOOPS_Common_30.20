using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowableUKOOA
    {
        [PPMProperty(nameof(SystemDesignFactor_f2), nameof(IAnalysisMaterialAllowableUKOOA))]
        double? SystemDesignFactor_f2 { get; set; }

        [PPMProperty(nameof(MeanTemperatureChangeMultiplier_K), nameof(IAnalysisMaterialAllowableUKOOA))]
        double? MeanTemperatureChangeMultiplier_K { get; set; }
    }
}
