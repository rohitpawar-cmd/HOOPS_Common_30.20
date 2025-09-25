using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;
using Hexagon.ALI.Analysis.Common.Helpers;


namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowableDataSet
    {
        AnalysisMaterial Material { get; set; }
        string AnalysisMaterialId { get; set; }
        
        [PPMProperty(nameof(ThermalExpansion), nameof(IAnalysisMaterialAllowableDataSet))]
        double? ThermalExpansion { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(ElasticModulus), nameof(IAnalysisMaterialAllowableDataSet))]
        string ElasticModulus { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(AllowableStress), nameof(IAnalysisMaterialAllowableDataSet))]
        string AllowableStress { get; set; }

        [PPMProperty(nameof(CyclicStressRangeReduction), nameof(IAnalysisMaterialAllowableDataSet))]
        double? CyclicStressRangeReduction { get; set; }

        // needed for Piping Code GPTCZ380
        [PPMProperty(nameof(TemperatureDeratingFactor), nameof(IAnalysisMaterialAllowableDataSet))]
        double? TemperatureDeratingFactor { get; set; }

        // Property Used in the ISO 14692 Codes
        [PPMProperty(nameof(PartialTemperatureFactor), nameof(IAnalysisMaterialAllowableDataSet))]
        double? PartialTemperatureFactor { get; set; }

        [PPMProperty(nameof(MaterialUltimateTensileStrength), nameof(IAnalysisMaterialAllowableDataSet))]
        double? MaterialUltimateTensileStrength { get; set; }

        // Added as part of Story A20-179-26, needed for Piping Code BS7159
        [PPMProperty(nameof(FatigueFactor), nameof(IAnalysisMaterialAllowableDataSet))]
        double? FatigueFactor { get; set; }

        // Added as part of Story A20-179-28, needed for Piping Code UKOOA
        [UoM("PressureUoM")]
        [PPMProperty(nameof(AllowableDesignStressHoopDirection), nameof(IAnalysisMaterialAllowableDataSet))]
        string AllowableDesignStressHoopDirection { get; set; }

        // Added as part of Story A20-179-28, needed for Piping Code UKOOA
        [PPMProperty(nameof(IdealizedAllowableStressEvelope), nameof(IAnalysisMaterialAllowableDataSet))]
        double? IdealizedAllowableStressEvelope { get; set; }

        // Added as part of Story A20-179-28, needed for Piping Code TD12
        [UoM("PressureUoM")]
        [PPMProperty(nameof(UltimateTensileStrength), nameof(IAnalysisMaterialAllowableDataSet))]
        string UltimateTensileStrength { get; set; }

        #region SI VALUES
        double? ElasticModulusSiValue { get; }
        double? AllowableStressSiValue { get; }
        double? AllowableDesignStressHoopDirectionSiValue { get; }
        double? UltimateTensileStrengthSiValue { get; }
        #endregion
    }
}
