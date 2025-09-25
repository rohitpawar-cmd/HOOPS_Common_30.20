using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisWaveLoad
    {
        [UoM("ElevationUoM")]
        string SurfaceVelocity { get; set; }
        double? SurfaceVelocitySiValue { get; }
        [UoM("ElevationUoM")]
        string WaterDepth { get; set; }
        double? WaterDepthSiValue { get; }
        [UoM("ElevationUoM")]
        string WaveHeight { get; set; }
        string WaveHeightSiValue { get; }
        [UoM("ElevationUoM")]
        string FreeSurfaceElevation { get; set; }
        string FreeSurfaceElevationSiValue { get; }
        [UoM("LengthUoM")]
        string KinematicViscosity { get; set; }
        string KinematicViscositySiValue { get; }
        [UoM("FluidDensityUoM")]
        string WaterDensity { get; set; }
        string WaterDensitySiValue { get; }
    }
}
