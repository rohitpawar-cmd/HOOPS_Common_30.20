using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Enums.WindLoadEnums;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase.WindLoadCase.WindCases
{
    public class AnalysisWindCaseBS6399_1997 : AnalysisWindLoad, IAnalysisWindCaseBS6399
    {
        public AnalysisWindCaseBS6399_1997()
        {
            WindCode = WindCode.BS6399;
            CodeYear = "1997";
        }
        [NotMapped]
        public string DesignWindSpeed { get; set; }

        public double? DesignWindSpeedSiValue { get; private set; }
        [NotMapped]
        public string TotalWindHeight { get; set; }

        public double? TotalWindHeightSiValue { get; private set; }
        [NotMapped]
        public string DistanceToCoastline { get; set; }

        public double? DistanceToCoastlineSiValue { get; private set; }
        [NotMapped]
        public string UpwindBuildingHeight { get; set; }

        public double? UpwindBuildingHeightSiValue { get; private set; }
        [NotMapped]
        public string UpwindBuildingSpacing { get; set; }

        public double? UpwindBuildingSpacingSiValue { get; private set; }
        public PipeSurface? PipeSurface { get; set; }
        public PipeLocation? PipeLocation { get; set; }
        public FactorKb? FactorKb { get; set; }
        public double? SiteElevation { get; set; }
        public double? AnnualProbabilityFactor { get; set; }
        public double? DirectionalFactor { get; set; }
        public double? SeasonalFactor { get; set; }
    }
}
