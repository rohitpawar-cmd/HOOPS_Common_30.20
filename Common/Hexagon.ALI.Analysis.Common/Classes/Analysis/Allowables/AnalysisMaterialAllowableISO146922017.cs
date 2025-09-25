using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables
{
    public class AnalysisMaterialAllowableISO146922017 : AnalysisMaterial, IAnalysisMaterialAllowableISO146922017
    {
        public AnalysisMaterial Material { get; set; }

        public string AnalysisMaterialId { get; set; }

        #region Failue Envelope

        [NotMapped]
        public string LongTermAxialStressRatio01 { get; set; }
        public double? LongTermAxialStressRatio01SiValue { get; set; }

        [NotMapped]
        public string LongTermAxialStressRatio21 { get; set; }
        public double? LongTermAxialStressRatio21SiValue { get; set; }

        [NotMapped]
        public string LongTermHoopStressRatio21 { get; set; }
        public double? LongTermHoopStressRatio21SiValue { get; set; }

        [NotMapped]
        public string LongTermAxialStressPartiallyRestrainedHydraulic { get; set; }
        public double? LongTermAxialStressPartiallyRestrainedHydraulicSiValue { get; set; }

        [NotMapped]
        public string LongTermHoopStressPartiallyRestrainedHydraulic { get; set; }
        public double? LongTermHoopStressPartiallyRestrainedHydraulicSiValue { get; set; }
        #endregion

        #region Other Partial Factors
        public double? DesignLifetimeFactor { get; set; }
        public double? ChemicalResistancePartialFactor { get; set; }
        public double? CyclicServicePartialFactor { get; set; }
        public double? SystemDesignFactor { get; set; }
        #endregion

        public double? HoopModulusAxialModulusOfElasticity { get; set; }

        [NotMapped]
        public string CurveRadius { get; set; }
        public double? CurveRadiusSiValue { get; set; }
        public bool Buried { get; set; }

        [NotMapped]
        public string HoopBendingModulus { get; set; }
        public double? HoopBendingModulusSiValue { get; set; }
        public string ShapeFactorPipeZoneEmbedment { get; set; }

        [NotMapped]
        public string VerticalPipeDeflection { get; set; }
        public double? VerticalPipeDeflectionSiValue { get; set; }
        public string PipeRestrainedStatus { get; set; }
    }
}
