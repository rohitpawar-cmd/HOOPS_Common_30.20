using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs
{
    public interface IAnalysisDNVCommonOutput
    {
        [UoM("ThicknessUoM")]
        [PPMProperty(nameof(InputWallThickness), nameof(IAnalysisDNVCommonOutput))]
        string InputWallThickness { get; set; }
        [PPMProperty(nameof(InputWallThicknessSiValue), nameof(IAnalysisDNVCommonOutput))]
        double? InputWallThicknessSiValue { get; }
    }
}
