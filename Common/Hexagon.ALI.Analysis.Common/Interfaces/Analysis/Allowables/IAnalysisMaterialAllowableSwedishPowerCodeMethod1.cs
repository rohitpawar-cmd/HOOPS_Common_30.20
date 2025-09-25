using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowableSwedishPowerCodeMethod1
    {
        [PPMProperty(nameof(CircumferentialJointFactor), nameof(IAnalysisMaterialAllowableSwedishPowerCodeMethod1))]
        double? CircumferentialJointFactor { get; set; }
        
        [PPMProperty(nameof(StigmaMultiplier), nameof(IAnalysisMaterialAllowableSwedishPowerCodeMethod1))]
        double? StigmaMultiplier { get; set; }
        
        [PPMProperty(nameof(BetaSeffCalculation), nameof(IAnalysisMaterialAllowableSwedishPowerCodeMethod1))]
        double? BetaSeffCalculation { get; set; }
    }
}
