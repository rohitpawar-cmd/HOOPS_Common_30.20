using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Enums.WindLoadEnums;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase.WindLoadCase.WindCases
{
    public class AnalysisWindCaseAustralia1170_2002 : AnalysisWindLoad, IAnalysisWindCaseAS_NZS_1170
    {
        public AnalysisWindCaseAustralia1170_2002()
        {
            WindCode = WindCode.Australia;
            CodeYear = "2002";
        }
        [NotMapped]
        public string DesignWindSpeed { get; set; }

        public double? DesignWindSpeedSiValue { get; private set; }
        [NotMapped]
        public string SurfaceRoughnessHeight { get; set; }

        public double? SurfaceRoughnessHeightSiValue { get; private set; }
        [NotMapped]
        public string AvgBuildingSpacing { get; set; }

        public double? AvgBuildingSpacingSiValue { get; private set; }
        [NotMapped]
        public string AvgBuildingBreadth { get; set; }

        public double? AvgBuildingBreadthSiValue { get; private set; }
        [NotMapped]
        public string AvgBuildingHeight { get; set; }

        public double? AvgBuildingHeightSiValue { get; private set; }
        public WindRegion? WindRegion { get; set; }
        public TerrainCategory? TerrainCategory { get; set; }
        public double? LeeEffectMultiplier { get; set; }
        public double? HillShapeFactor { get; set; }
        public double? WindDirectionMultiplier { get; set; }
        public bool ConvertToPermissableSpeed { get; set; } = false;
        public double? SiteElevation { get; set; }
        public int? NumberOfUpwindBuildings { get; set; }

    }
}
