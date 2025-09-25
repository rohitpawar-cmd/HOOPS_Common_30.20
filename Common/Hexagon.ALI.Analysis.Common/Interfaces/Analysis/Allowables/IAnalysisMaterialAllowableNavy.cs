using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowableNavy505
    {
        [PPMProperty(nameof(FactorForMinimumWallThickness), nameof(IAnalysisMaterialAllowableNavy505))]
        double? FactorForMinimumWallThickness { get; set; }
    }
}
