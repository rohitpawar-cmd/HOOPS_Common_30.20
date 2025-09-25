using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Enums.WindLoadEnums;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase.WindLoadCase.WindCases.ASCE7
{
    public class AnalysisWindCaseASCE7_2005 : AnalysisWindLoad, IAnalysisWindCaseASCE7, IAnalysisWindCaseASCE7_2022
    {
        public AnalysisWindCaseASCE7_2005()
        {
            WindCode = WindCode.ASCE;
            CodeYear = "2005";
        }
        [NotMapped]
        public string BasicWindSpeed { get; set; }

        public double? BasicWindSpeedSiValue { get; private set; }

        public WindExposure? WindExposure { get; set; }
        public double? StructuralDampingCoeff { get; set; }
        public double? StructureNaturalFrequency { get; set; }
        [NotMapped]
        public string HillHeight { get; set; }

        public double? HillHeightSiValue { get; private set; }
        [NotMapped]
        public string CrestDistance { get; set; }

        public double? CrestDistanceSiValue { get; private set; }
        [NotMapped]
        public string DistanceToSite { get; set; }

        public double? DistanceToSiteSiValue { get; private set; }

        public HillType? HillType { get; set; }
        public double? ImportanceFactor { get; set; }
        public int? StructuralClassification { get; set; }
    }
}
