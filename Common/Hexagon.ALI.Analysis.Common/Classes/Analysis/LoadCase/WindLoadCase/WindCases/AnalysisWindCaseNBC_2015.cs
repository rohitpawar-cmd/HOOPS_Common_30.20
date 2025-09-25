using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Enums.WindLoadEnums;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase.WindLoadCase.WindCases
{
    public class AnalysisWindCaseNBC_2015 : AnalysisWindLoad, IAnalysisWindCaseNBC, IAnalysisWindCaseNBC_2015
    {
        public AnalysisWindCaseNBC_2015()
        {
            WindCode = WindCode.NBC;
            CodeYear = "2015";
        }
        [NotMapped]
        public string WindPressure { get; set; }

        public double? WindPressureSiValue { get; private set; }
        [NotMapped]
        public string HeightOfWindwardFace { get; set; }

        public double? HeightOfWindwardFaceSiValue { get; private set; }
        [NotMapped]
        public string DesignWindSpeed { get; set; }

        public double? DesignWindSpeedSiValue { get; private set; }

        public double? ImportanceFactor { get; set; }
        public ExposureConstant ExposureConstant { get; set; }
        public double? StructuralDampingCoeff { get; set; }
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
