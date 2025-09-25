using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Enums.WindLoadEnums;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase.WindLoadCase.WindCases
{
    public class AnalysisWindCaseIS875_1998 : AnalysisWindLoad, IAnalysisWindCaseIS875_1998
    {
        public AnalysisWindCaseIS875_1998()
        {
            WindCode = WindCode.IS875;
            CodeYear = "1998";
        }
        public int WindZoneNumber { get; set; }
        public double? RiskFactor { get; set; }
        public EquipmentClass EquipmentClass { get; set; }
        public TerrainCategory TerrainCategory { get; set; }
        public double? TopographyFactor { get; set; }
        public bool WseGustResponseFactor { get; set; } = false;
        public double? StructuralDampingCoeff { get; set; }
        [NotMapped]
        public string BasicWindSpeed { get; set; }

        public double? BasicWindSpeedSiValue { get; private set; }
    }
}

