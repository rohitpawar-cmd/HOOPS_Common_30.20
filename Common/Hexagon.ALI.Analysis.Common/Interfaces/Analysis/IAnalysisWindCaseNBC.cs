using Hexagon.ALI.Analysis.Common.Enums.WindLoadEnums;
using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisWindCaseNBC
    {
        [UoM("PressureUoM")]
        string WindPressure { get; set; }
        double? WindPressureSiValue { get; }
        [UoM("ElevationUoM")]
        string HeightOfWindwardFace { get; set; }
        double? HeightOfWindwardFaceSiValue { get; }
        [UoM("ElevationUoM")]
        string DesignWindSpeed { get; set; }
        double? DesignWindSpeedSiValue { get; }
    }
    public interface IAnalysisWindCaseNBC_2005
    {
        double? RoughnessFactor { get; set; }
    }
    public interface IAnalysisWindCaseNBC_2015
    {
        [UoM("ElevationUoM")]
        string HillHeight { get; set; }
        double? HillHeightSiValue { get; }
        [UoM("ElevationUoM")]
        string CrestDistance { get; set; }
        double? CrestDistanceSiValue { get; }
        [UoM("ElevationUoM")]
        string DistanceToSite { get; set; }
        double? DistanceToSiteSiValue { get; }
        HillType? HillType { get; set; }
    }
}
