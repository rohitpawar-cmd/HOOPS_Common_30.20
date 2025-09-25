using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowableSwedishPowerCodeMethod2
    {
        [PPMProperty(nameof(CircumferentialJointFactor), nameof(IAnalysisMaterialAllowableSwedishPowerCodeMethod2))]
        double? CircumferentialJointFactor { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(UltimateTensileStrength), nameof(IAnalysisMaterialAllowableSwedishPowerCodeMethod2))]
        string UltimateTensileStrength { get; set; }

        [PPMProperty(nameof(BetaSeffCalculation), nameof(IAnalysisMaterialAllowableSwedishPowerCodeMethod2))]
        double? BetaSeffCalculation { get; set; }

        #region SI VALUES
        double? UltimateTensileStrengthSiValue { get; }
        #endregion
    }
}
