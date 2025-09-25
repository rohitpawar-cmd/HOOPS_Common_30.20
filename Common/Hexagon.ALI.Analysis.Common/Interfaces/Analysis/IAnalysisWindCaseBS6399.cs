using Hexagon.ALI.Analysis.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisWindCaseBS6399
    {
        [UoM("ElevationUoM")]
        string DesignWindSpeed { get; set; }
        double? DesignWindSpeedSiValue { get; }
        [UoM("ElevationUoM")]
        string TotalWindHeight { get; set; }
        double? TotalWindHeightSiValue { get; }
        [UoM("ElevationUoM")]
        string DistanceToCoastline { get; set; }
        double? DistanceToCoastlineSiValue { get; }
        [UoM("ElevationUoM")]
        string UpwindBuildingHeight { get; set; }
        double? UpwindBuildingHeightSiValue { get; }
        [UoM("ElevationUoM")]
        string UpwindBuildingSpacing { get; set; }
        double? UpwindBuildingSpacingSiValue { get; }
    }
}
