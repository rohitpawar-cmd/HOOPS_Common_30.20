using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Enums.WindLoadEnums;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase.WindLoadCase.WindCases
{
    public class AnalysisWindCaseMexico_1993 : AnalysisWindLoad, IAnalysisWindCaseMexico_1993
    {
        public AnalysisWindCaseMexico_1993()
        {
            WindCode = WindCode.Mexico;
            CodeYear = "1993";
        }
        public double? TopographicFactor { get; set; }
        public double? DampingFactor { get; set; }
        public double? StrouhalNumber { get; set; } = 1.10;
        public double? BarometricHeight { get; set; }
        public double? Frequency { get; set; }

        public TerrainCategory TerrainCategory { get; set; }
        public StructureClass StructureClass { get; set; }
        [NotMapped]
        public string TotalWindHeight { get; set; }

        public double? TotalWindHeightSiValue { get; private set; }
        [NotMapped]
        public string DesignWindSpeed { get; set; }

        public double? DesignWindSpeedSiValue { get; private set; }
        [NotMapped]
        public string AmbientTemprature { get; set; }

        public double? AmbientTempratureSiValue { get; private set; }
    }
}

