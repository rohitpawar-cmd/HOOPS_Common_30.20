using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Enums.WindLoadEnums;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase.WindLoadCase.WindCases.IBC
{
    public class AnalysisWindCaseIBC_2018 : AnalysisWindLoad, IAnalysisWindCaseASCE7_2022, IAnalysisWindCaseASCE7_2016, IAnalysisWindCaseASCE7
    {
        public AnalysisWindCaseIBC_2018()
        {
            WindCode = WindCode.IBC;
            CodeYear = "2018";
        }
        [NotMapped]
        public string BasicWindSpeed { get; set; }

        public double? BasicWindSpeedSiValue { get; private set; }

        public WindExposure? WindExposure { get; set; }
        public double? StructuralDampingCoeff { get; set; }
        public double? StructureNaturalFrequency { get; set; }
        [NotMapped]
        public string GroundElevation { get; set; }

        public double? GroundElevationSiValue { get; private set; }
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
    }
}
