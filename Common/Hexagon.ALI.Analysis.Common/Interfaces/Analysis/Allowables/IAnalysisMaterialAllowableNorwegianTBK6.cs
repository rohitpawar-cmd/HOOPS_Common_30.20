using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowableNorwegianTBK6
    {
        [PPMProperty(nameof(CircumferentialJointFactor), nameof(IAnalysisMaterialAllowableNorwegianTBK6))]
        double? CircumferentialJointFactor { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(UltimateTensileStrength), nameof(IAnalysisMaterialAllowableNorwegianTBK6))]
        string UltimateTensileStrength { get; set; }

        double? UltimateTensileStrengthSiValue { get; }

        [PPMProperty(nameof(AllowableStress7000LoadCycles), nameof(IAnalysisMaterialAllowableNorwegianTBK6))]
        double? AllowableStress7000LoadCycles { get; set; }        
    }
}
