using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Enums.WindLoadEnums;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase.WindLoadCase.WindCases
{
    public class AnalysisWindCaseBrazilNBR6123_1988 : AnalysisWindLoad, IAnalysisWindCaseBrazilNBR6123
    {
        public AnalysisWindCaseBrazilNBR6123_1988()
        {
            WindCode = WindCode.Brazil;
            CodeYear = "1988";
        }
        [NotMapped]
        public string BasicWindVelocity { get; set; }

        public double? BasicWindVelocitySiValue { get; private set; }
        [NotMapped]
        public string TotalWindHeight { get; set; }

        public double? TotalWindHeightSiValue { get; private set; }

        public double? TopographicFactor { get; set; }
        public double? StatisticalFactor { get; set; }
        public double? Frequency { get; set; }
        public RoughnessCategory RoughnessCategory { get; set; }
        public DimensionClass DimensionClass { get; set; }
        public PipeSurface PipeSurfaceCondition { get; set; }
    }
}
