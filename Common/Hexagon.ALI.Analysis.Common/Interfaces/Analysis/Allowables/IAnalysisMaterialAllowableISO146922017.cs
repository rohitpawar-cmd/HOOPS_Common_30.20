using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowableISO146922017
    {

        #region Failure Envelope
        [UoM("PressureUoM")]
        [PPMProperty(nameof(LongTermAxialStressRatio01), nameof(IAnalysisMaterialAllowableISO146922017))]
        string LongTermAxialStressRatio01 { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(LongTermAxialStressRatio21), nameof(IAnalysisMaterialAllowableISO146922017))]
        string LongTermAxialStressRatio21 { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(LongTermHoopStressRatio21), nameof(IAnalysisMaterialAllowableISO146922017))]
        string LongTermHoopStressRatio21 { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(LongTermAxialStressPartiallyRestrainedHydraulic), nameof(IAnalysisMaterialAllowableISO146922017))]
        string LongTermAxialStressPartiallyRestrainedHydraulic { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(LongTermHoopStressPartiallyRestrainedHydraulic), nameof(IAnalysisMaterialAllowableISO146922017))]
        string LongTermHoopStressPartiallyRestrainedHydraulic { get; set; }
        #endregion

        #region Other Partial Factors

        [PPMProperty(nameof(DesignLifetimeFactor), nameof(IAnalysisMaterialAllowableISO146922017))]
        double? DesignLifetimeFactor { get; set; }
        [PPMProperty(nameof(ChemicalResistancePartialFactor), nameof(IAnalysisMaterialAllowableISO146922017))]
        double? ChemicalResistancePartialFactor { get; set; }

        [PPMProperty(nameof(CyclicServicePartialFactor), nameof(IAnalysisMaterialAllowableISO146922017))]
        double? CyclicServicePartialFactor { get; set; }

        [PPMProperty(nameof(SystemDesignFactor), nameof(IAnalysisMaterialAllowableISO146922017))]
        double? SystemDesignFactor { get; set; }
        #endregion

        [PPMProperty(nameof(HoopModulusAxialModulusOfElasticity), nameof(IAnalysisMaterialAllowableISO146922017))]
        double? HoopModulusAxialModulusOfElasticity { get; set; }

        [UoM("LengthUoM")]
        [PPMProperty(nameof(CurveRadius), nameof(IAnalysisMaterialAllowableISO146922017))]
        string CurveRadius { get; set; }

        [PPMProperty(nameof(Buried), nameof(IAnalysisMaterialAllowableISO146922017))]
        bool Buried { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(HoopBendingModulus), nameof(IAnalysisMaterialAllowableISO146922017))]
        string HoopBendingModulus { get; set; }

        [PPMProperty(nameof(ShapeFactorPipeZoneEmbedment), nameof(IAnalysisMaterialAllowableISO146922017))]
        string ShapeFactorPipeZoneEmbedment { get; set; }

        [UoM("LengthUoM")]
        [PPMProperty(nameof(VerticalPipeDeflection), nameof(IAnalysisMaterialAllowableISO146922017))]
        string VerticalPipeDeflection { get; set; }

        [PPMProperty(nameof(PipeRestrainedStatus), nameof(IAnalysisMaterialAllowableISO146922017))]
        string PipeRestrainedStatus { get; set; }


        #region SI VALUES
        double? LongTermAxialStressRatio01SiValue { get; set; }
        double? LongTermAxialStressRatio21SiValue { get; set; }
        double? LongTermHoopStressRatio21SiValue { get; set; }
        double? LongTermAxialStressPartiallyRestrainedHydraulicSiValue { get; set; }
        double? LongTermHoopStressPartiallyRestrainedHydraulicSiValue { get; set; }
        double? CurveRadiusSiValue { get; set; }
        double? HoopBendingModulusSiValue { get; set; }
        double? VerticalPipeDeflectionSiValue { get; set; }
        #endregion
    }
}
