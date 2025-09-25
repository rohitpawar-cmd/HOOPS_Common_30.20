using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Enums.WindLoadEnums;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase.WindLoadCase.WindCases
{
    public class AnalysisWindCaseChinaGB50009_2012 : AnalysisWindLoad, IAnalysisWindCaseChinaGB50009
    {
        public AnalysisWindCaseChinaGB50009_2012()
        {
            WindCode = WindCode.China;
            CodeYear = "2012";
        }
        [NotMapped]
        public string WindPressure { get; set; }
        public double? WindPressureSiValue { get; private set; }
        [NotMapped]
        public string TotalWindHeight { get; set; }
        public double? TotalWindHeightSiValue { get; private set; }
        public TerrainCategory TerrainCategory { get; set; }
        public double? Frequency { get; set; }
    }
}
