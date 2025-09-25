using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries
{
    public class AnalysisMaterialAllowableDataSet : AnalysisVectorAuxiliary, IAnalysisMaterialAllowableDataSet
    {
        public AnalysisMaterial Material { get; set; }
        public string AnalysisMaterialId { get; set; }
        public double? ThermalExpansion { get; set; }        
        public double? CyclicStressRangeReduction { get; set; }
        public double? TemperatureDeratingFactor { get; set; }
        public double? ElasticModulusSiValue { get; private set; }
        public double? AllowableStressSiValue { get; private set; }
        [NotMapped]
        public string ElasticModulus { get; set; }
        [NotMapped]
        public string AllowableStress { get; set; }
        // Added as part of A20-179-24, needed for ISO-14962 Editions 2005 and 2017
        [NotMapped]
        public double? PartialTemperatureFactor { get; set; }

        // Added as part of A20-179-25, needed for DNV 2005
        [NotMapped]
        public double? MaterialUltimateTensileStrength { get; set; }

        // Added as part of Story A20-179-26, needed for Piping Code BS7159
        [NotMapped]
        public double? FatigueFactor { get; set; }

        // Added as part of Story A20-179-28, needed for Piping Code UKOOA
        [NotMapped]
        public string AllowableDesignStressHoopDirection { get; set; }

        // Added as part of Story A20-179-28, needed for Piping Code UKOOA
        [NotMapped]
        public double? IdealizedAllowableStressEvelope { get; set; }

        // Added as part of Story A20-179-28, needed for Piping Code TD12
        [NotMapped]
        public string UltimateTensileStrength { get; set; }

        [NotMapped]
        public double? AllowableDesignStressHoopDirectionSiValue { get; private set; }
        [NotMapped]
        public double? UltimateTensileStrengthSiValue { get; private set; }
        [NotMapped]
        public string MaterialName => Material?.DisplayName;
        [NotMapped]
        public int? VectorNumber => AnalysisPrimitive?.Number;
        [NotMapped]
        public double? DisplayTemp { get; set; }
    }
}
