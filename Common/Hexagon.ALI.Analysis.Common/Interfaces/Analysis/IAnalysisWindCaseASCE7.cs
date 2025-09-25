using Hexagon.ALI.Analysis.Common.Enums.WindLoadEnums;
using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisWindCaseASCE7_2022
    {
        double? StructuralDampingCoeff {  get; set; }
        double? StructureNaturalFrequency { get; set; }      
       
    }
    public interface IAnalysisWindCaseASCE7_2016
    {
        [UoM("ElevationUoM")]
        string GroundElevation { get; set; }
        double? GroundElevationSiValue { get; }
    }
    public interface IAnalysisWindCaseASCE7
    {
        [UoM("ElevationUoM")]
        string BasicWindSpeed { get; set; }
        double? BasicWindSpeedSiValue { get; }
        WindExposure? WindExposure { get; set; }
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
