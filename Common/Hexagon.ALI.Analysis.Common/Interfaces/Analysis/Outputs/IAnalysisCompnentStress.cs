using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs
{
    public interface IAnalysisComponentStress
    {
        [UoM("StressUoM")]
        [PPMProperty(nameof(SLP), nameof(IAnalysisComponentStress))]
        string SLP { get; set; }

        [UoM("StressUoM")]
        [PPMProperty(nameof(SL), nameof(IAnalysisComponentStress))]
        string SL { get; set; }

        [UoM("StressUoM")]
        [PPMProperty(nameof(FA), nameof(IAnalysisComponentStress))]
        string FA { get; set; }

        [UoM("StressUoM")]
        [PPMProperty(nameof(Shear), nameof(IAnalysisComponentStress))]
        string Shear { get; set; }
        [UoM("StressUoM")]
        [PPMProperty(nameof(Shear3D), nameof(IAnalysisComponentStress))]
        string Shear3D { get; set; }
        [UoM("StressUoM")]
        [PPMProperty(nameof(VonMises), nameof(IAnalysisComponentStress))]
        string VonMises { get; set; }
        [PPMProperty(nameof(SIFIndexTorsion), nameof(IAnalysisComponentStress))]
        double? SIFIndexTorsion { get; set; }

        [PPMProperty(nameof(SIFIndexAxial), nameof(IAnalysisComponentStress))]
        double? SIFIndexAxial { get; set; }

        [PPMProperty(nameof(SIFIndexPressure), nameof(IAnalysisComponentStress))]
        double? SIFIndexPressure { get; set; }

        [PPMProperty(nameof(SIFIndexShear), nameof(IAnalysisComponentStress))]
        double? SIFIndexShear { get; set; }

        [PPMProperty(nameof(HoopIn), nameof(IAnalysisComponentStress))]
        double? HoopIn { get; set; }

        [PPMProperty(nameof(HoopOut), nameof(IAnalysisComponentStress))]
        double? HoopOut { get; set; }

        [PPMProperty(nameof(Ratio), nameof(IAnalysisComponentStress))]
        double? Ratio { get; set; }
        [UoM("StressUoM")]
        [PPMProperty(nameof(HoopCode), nameof(IAnalysisComponentStress))]
        string HoopCode { get; set; }

        [UoM("StressUoM")]
        [PPMProperty(nameof(HoopAllowableCode), nameof(IAnalysisComponentStress))]
        string HoopAllowableCode { get; set; }

        [PPMProperty(nameof(HoopRatio), nameof(IAnalysisComponentStress))]
        double? HoopRatio { get; set; }

        [UoM("StressUoM")]
        [PPMProperty(nameof(LongitundinalCode), nameof(IAnalysisComponentStress))]
        string LongitundinalCode { get; set; }

        [UoM("StressUoM")]
        [PPMProperty(nameof(LongitundinalAllowableCode), nameof(IAnalysisComponentStress))]
        string LongitundinalAllowableCode { get; set; }

        [PPMProperty(nameof(LongitundinalRatio), nameof(IAnalysisComponentStress))]
        double? LongitundinalRatio { get; set; }

        [UoM("StressUoM")]
        [PPMProperty(nameof(CombCode), nameof(IAnalysisComponentStress))]
        string CombCode { get; set; }

        [UoM("StressUoM")]
        [PPMProperty(nameof(CombAllowableCode), nameof(IAnalysisComponentStress))]
        string CombAllowableCode { get; set; }

        [PPMProperty(nameof(CombRatio), nameof(IAnalysisComponentStress))]
        double? CombRatio { get; set; }

        [UoM("StressUoM")]
        [PPMProperty(nameof(RingBend), nameof(IAnalysisComponentStress))]
        string RingBend { get; set; }

        [UoM("StressUoM")]
        [PPMProperty(nameof(Roping), nameof(IAnalysisComponentStress))]
        string Roping { get; set; }
        double? SLPSiValue { get; }
        double? ShearSiValue { get; }
        double? Shear3DSiValue { get; }
        double? VonMisesSiValue { get; }
        double? RingBendSiValue { get; }
        double? SLSiValue { get; }
        double? CombAllowableCodeSiValue { get; }
        double? CombCodeSiValue { get; }
        double? HoopAllowableCodeSiValue { get; }
        double? HoopCodeSiValue { get; }
        double? LongitundinalAllowableCodeSiValue { get; }
        double? LongitundinalCodeSiValue { get; }
        double? RopingSiValue { get; }
    }
}
