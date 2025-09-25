using Hexagon.ALI.Analysis.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisWindCaseAS_NZS_1170
    {
        [UoM("ElevationUoM")]
        string DesignWindSpeed { get; set; }
        double? DesignWindSpeedSiValue { get; }
        [UoM("ElevationUoM")]
        string SurfaceRoughnessHeight { get; set; }
        double? SurfaceRoughnessHeightSiValue { get; }
        [UoM("ElevationUoM")]
        string AvgBuildingSpacing { get; set; }
        double? AvgBuildingSpacingSiValue { get; }
        [UoM("ElevationUoM")]
        string AvgBuildingBreadth { get; set; }
        double? AvgBuildingBreadthSiValue { get; }
        [UoM("ElevationUoM")]
        string AvgBuildingHeight { get; set; }
        double? AvgBuildingHeightSiValue { get; }
    }
}
