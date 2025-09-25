using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables
{
    [DefUID("AnalysisMaterialAllowableStoomwezen")]
    public class AnalysisMaterialAllowableStoomwezen : AnalysisMaterial, IAnalysisMaterialAllowableStoomwezen
    {
        public AnalysisMaterial Material { get; set; }

        public string AnalysisMaterialId { get; set; }
        public string ElementID { get; set; }

        [NotMapped]
        public string AverageCreepStress { get; set; }
        public double? AverageCreepStressSiValue { get; private set; }

        [NotMapped]
        public string AverageCreepTensileStress { get; set; }
        public double? AverageCreepTensileStressSiValue { get; private set; }

        [NotMapped]
        public string MinimumCreepTensileStress { get; set; }
        public double? MinimumCreepTensileStressSiValue { get; private set; }

        [NotMapped]
        public string YieldStressDesignTemperature { get; set; }
        public double? YieldStressDesignTemperatureSiValue { get; private set; }
        public double? CyclicReductionFactor { get; set; }
        public double? StoomwezenConstant { get; set; }
        public double? CoefficientCM { get; set; }

        [NotMapped]
        public string TensileStrength { get; set; }
        public double? TensileStrengthSiValue { get; private set; }                           
    }
}
