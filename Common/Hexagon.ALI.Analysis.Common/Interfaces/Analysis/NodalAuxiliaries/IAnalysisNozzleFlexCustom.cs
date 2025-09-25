using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries
{
    public interface IAnalysisNozzleFlexCustom
    {
        [UoM("StressUoM")]
        [PPMProperty("NozzleAxial", "IAnalysisNozzleFlexCustom")]
        string NozzleAxial { get; set; }

        double? NozzleAxialSiValue { get; }

        [UoM("RotationalStiffnessUoM")]
        [PPMProperty("NozzleTorsional", "IAnalysisNozzleFlexCustom")]
        string NozzleTorsional { get; set; }

        double? NozzleTorsionalSiValue { get; }

        [UoM("RotationalStiffnessUoM")]
        [PPMProperty("InPlaneBending", "IAnalysisNozzleFlexCustom")]
        string InPlaneBending { get; set; }

        double? InPlaneBendingSiValue { get; }

        [UoM("RotationalStiffnessUoM")]
        [PPMProperty("OutPlaneBending", "IAnalysisNozzleFlexCustom")]
        string OutPlaneBending { get; set; }

        double? OutPlaneBendingSiValue { get; }
    }
}