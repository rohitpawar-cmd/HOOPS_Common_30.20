using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Enums.WindLoadEnums;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase.WindLoadCase.WindCases
{
    public class AnalysisWindCaseEurope1991_2005 : AnalysisWindLoad, IAnalysisWindCaseEurope1991
    {
        public AnalysisWindCaseEurope1991_2005()
        {
            WindCode = WindCode.Europe;
            CodeYear = "2005";
        }
        public double? DirectionalFactor_Cdir { get; set; }
        public double? SeasonFactor_Cseason { get; set; }
        public double? StructrualFactor_CsCd { get; set; } = 1.10;
        public double? StructuralDampingCoeff { get; set; }

        public TerrainCategory TerrainCategory { get; set; }
        [NotMapped]
        public string ReferenceWindVelocity { get; set; }

        public double? ReferenceWindVelocitySiValue { get; private set; }
    }
}

