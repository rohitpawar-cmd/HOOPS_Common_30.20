using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs
{
    public interface IAnalysisDNVComponentsOutput
    {
        [UoM("ThicknessUoM")]
        [PPMProperty(nameof(T_min_1), nameof(IAnalysisDNVComponentsOutput))]
        string T_min_1 { get; set; }
        [PPMProperty(nameof(T_min_1SiValue), nameof(IAnalysisDNVComponentsOutput))]
        double? T_min_1SiValue { get; }
        [PPMProperty(nameof(Utility_1), nameof(IAnalysisDNVComponentsOutput))]
        string Utility_1 { get; set; }
        [UoM("ThicknessUoM")]
        [PPMProperty(nameof(T_min_2), nameof(IAnalysisDNVComponentsOutput))]
        string T_min_2 { get; set; }
        [PPMProperty(nameof(T_min_2SiValue), nameof(IAnalysisDNVComponentsOutput))]
        double? T_min_2SiValue { get; }
        [PPMProperty(nameof(Utility_2), nameof(IAnalysisDNVComponentsOutput))]
        string Utility_2 { get; set; }
        [UoM("ThicknessUoM")]
        [PPMProperty(nameof(T_min_3), nameof(IAnalysisDNVComponentsOutput))]
        string T_min_3 { get; set; }
        [PPMProperty(nameof(T_min_3SiValue), nameof(IAnalysisDNVComponentsOutput))]
        double? T_min_3SiValue { get; }
        [PPMProperty(nameof(Utility_3), nameof(IAnalysisDNVComponentsOutput))]
        string Utility_3 { get; set; }
        [UoM("ThicknessUoM")]
        [PPMProperty(nameof(T_min_4), nameof(IAnalysisDNVComponentsOutput))]
        string T_min_4 { get; set; }
        [PPMProperty(nameof(T_min_4SiValue), nameof(IAnalysisDNVComponentsOutput))]
        double? T_min_4SiValue { get; }
        [PPMProperty(nameof(Utility_4), nameof(IAnalysisDNVComponentsOutput))]
        string Utility_4 { get; set; }
        [PPMProperty(nameof(Warning), nameof(IAnalysisDNVComponentsOutput))]
        string Warning { get; set; }
    }
}
