using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs
{
    public interface IAnalysisStress
    {
        [UoM("StressUoM")]
        [PPMProperty(nameof(Axial), nameof(IAnalysisStress))]
        string Axial { get; set; }

        [UoM("StressUoM")]
        [PPMProperty(nameof(Bending), nameof(IAnalysisStress))]
        string Bending { get; set; }

        [UoM("StressUoM")]
        [PPMProperty(nameof(Torsion), nameof(IAnalysisStress))]
        string Torsion { get; set; }

        [UoM("StressUoM")]
        [PPMProperty(nameof(Hoop), nameof(IAnalysisStress))]
        string Hoop { get; set; }

        [PPMProperty(nameof(SIFIndexInplane), nameof(IAnalysisStress))]
        double? SIFIndexInplane { get; set; }

        [PPMProperty(nameof(SIFIndexOutplane), nameof(IAnalysisStress))]
        double? SIFIndexOutplane { get; set; }

        [PPMProperty(nameof(CodeStandard), nameof(IAnalysisStress))]
        PipingCode? CodeStandard { get; set; }

        [UoM("StressUoM")]
        [PPMProperty(nameof(Code), nameof(IAnalysisStress))]
        string Code { get; set; }

        [UoM("StressUoM")]
        [PPMProperty(nameof(Allowable), nameof(IAnalysisStress))]
        string Allowable { get; set; }



        #region SI VALUES
        double? AxialSiValue { get; }
        double? BendingSiValue { get; }
        double? TorsionSiValue { get; }
        double? HoopSiValue { get; }
        double? CodeSiValue { get; }
        double? AllowableSiValue { get; }
        #endregion
    }
}
