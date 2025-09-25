using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs
{
    public interface IAnalysisDNVThicknessOutput
    {
        [UoM("ThicknessUoM")]
        [PPMProperty(nameof(BurstOperationTmin), nameof(IAnalysisDNVThicknessOutput))]
        string BurstOperationTmin { get; set; }
        [PPMProperty(nameof(BurstOperationTminSiValue), nameof(IAnalysisDNVThicknessOutput))]
        double? BurstOperationTminSiValue { get; }
        [UoM("ThicknessUoM")]
        [PPMProperty(nameof(BurstSystemTestTmin), nameof(IAnalysisDNVThicknessOutput))]
        string BurstSystemTestTmin { get; set; }
        [PPMProperty(nameof(BurstSystemTestTminSiValue), nameof(IAnalysisDNVThicknessOutput))]
        double? BurstSystemTestTminSiValue { get; }
        [UoM("ThicknessUoM")]
        [PPMProperty(nameof(CollapseTmin), nameof(IAnalysisDNVThicknessOutput))]
        string CollapseTmin { get; set; }
        [PPMProperty(nameof(CollapseTminSiValue), nameof(IAnalysisDNVThicknessOutput))]
        double? CollapseTminSiValue { get; }
        [UoM("ThicknessUoM")]
        [PPMProperty(nameof(PropagationBucklingTmin), nameof(IAnalysisDNVThicknessOutput))]
        string PropagationBucklingTmin { get; set; }
        [PPMProperty(nameof(PropagationBucklingTmin), nameof(IAnalysisDNVThicknessOutput))]
        double? PropagationBucklingTminSiValue { get; }
        [UoM("ThicknessUoM")]
        [PPMProperty(nameof(LCC_aTmin), nameof(IAnalysisDNVThicknessOutput))]
        string LCC_aTmin { get; set; }
        [PPMProperty(nameof(LCC_aTminSiValue), nameof(IAnalysisDNVThicknessOutput))]
        double? LCC_aTminSiValue { get; }
        [UoM("ThicknessUoM")]
        [PPMProperty(nameof(LCC_bTmin), nameof(IAnalysisDNVThicknessOutput))]
        string LCC_bTmin { get; set; }
        [PPMProperty(nameof(LCC_bTminSiValue), nameof(IAnalysisDNVThicknessOutput))]
        double? LCC_bTminSiValue { get; }
        [UoM("ThicknessUoM")]
        [PPMProperty(nameof(DCC_aTmin), nameof(IAnalysisDNVThicknessOutput))]
        string DCC_aTmin { get; set; }
        [PPMProperty(nameof(DCC_aTminSiValue), nameof(IAnalysisDNVThicknessOutput))]
        double? DCC_aTminSiValue { get; }
        [UoM("ThicknessUoM")]
        [PPMProperty(nameof(DCC_bTmin), nameof(IAnalysisDNVThicknessOutput))]
        string DCC_bTmin { get; set; }
        [PPMProperty(nameof(DCC_bTminSiValue), nameof(IAnalysisDNVThicknessOutput))]
        double? DCC_bTminSiValue { get; }
    }
}
