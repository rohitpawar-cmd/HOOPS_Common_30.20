using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowableISO146922005
    {

        #region Failure Envelope for Plain Pipe
        [UoM("PressureUoM")]
        [PPMProperty(nameof(LongTermAxialStressRatio01), nameof(IAnalysisMaterialAllowableISO146922005))]
        string LongTermAxialStressRatio01 { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(LongTermAxialStressRatio11), nameof(IAnalysisMaterialAllowableISO146922005))]
        string LongTermAxialStressRatio11 { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(LongTermAxialStressRatio21), nameof(IAnalysisMaterialAllowableISO146922005))]
        string LongTermAxialStressRatio21 { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(LongTermHoopStressRatio11), nameof(IAnalysisMaterialAllowableISO146922005))]
        string LongTermHoopStressRatio11 { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(LongTermHoopStressRatio21), nameof(IAnalysisMaterialAllowableISO146922005))]
        string LongTermHoopStressRatio21 { get; set; }
        #endregion

        #region Failure Envelope for Joints/Fittings

        [UoM("PressureUoM")]
        [PPMProperty(nameof(QualifiedStressJoint), nameof(IAnalysisMaterialAllowableISO146922005))]
        string QualifiedStressJoint { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(QualifiedStressBend), nameof(IAnalysisMaterialAllowableISO146922005))]
        string QualifiedStressBend { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(QualifiedStressTee), nameof(IAnalysisMaterialAllowableISO146922005))]
        string QualifiedStressTee { get; set; }

        [PPMProperty(nameof(BiAxialStressRatioJoint), nameof(IAnalysisMaterialAllowableISO146922005))]
        double? BiAxialStressRatioJoint { get; set; }

        [PPMProperty(nameof(BiAxialStressRatioBend), nameof(IAnalysisMaterialAllowableISO146922005))]
        double? BiAxialStressRatioBend { get; set; }

        [PPMProperty(nameof(HoopModulusAxialModulusOfElasticity), nameof(IAnalysisMaterialAllowableISO146922005))]
        double? HoopModulusAxialModulusOfElasticity { get; set; }

        [PPMProperty(nameof(HandLay), nameof(IAnalysisMaterialAllowableISO146922005))]
        bool HandLay { get; set; }
        #endregion

        #region Other Partial Factors
        [PPMProperty(nameof(ChemicalResistancePartialFactor), nameof(IAnalysisMaterialAllowableISO146922005))]
        double? ChemicalResistancePartialFactor { get; set; }

        [PPMProperty(nameof(CyclicServicePartialFactor), nameof(IAnalysisMaterialAllowableISO146922005))]
        double? CyclicServicePartialFactor { get; set; }

        [PPMProperty(nameof(SystemDesignFactor), nameof(IAnalysisMaterialAllowableISO146922005))]
        double? SystemDesignFactor { get; set; }
        [PPMProperty(nameof(ThermalFactor), nameof(IAnalysisMaterialAllowableISO146922005))]
        double? ThermalFactor { get; set; }
        #endregion

        #region SI VALUES
        double? LongTermAxialStressRatio01SiValue { get; }
        double? LongTermAxialStressRatio11SiValue { get; }
        double? LongTermAxialStressRatio21SiValue { get; }
        double? LongTermHoopStressRatio11SiValue { get; }
        double? LongTermHoopStressRatio21SiValue { get; }
        double? QualifiedStressJointSiValue { get; }
        double? QualifiedStressBendSiValue { get; }
        double? QualifiedStressTeeSiValue { get; }
        #endregion
    }
}
