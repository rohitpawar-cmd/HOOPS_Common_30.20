using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IWindVelocityVsElevation
    {
        string Velocity { get; set; }
        [UoM("ElevationUoM")]
        double? VelocitySiValue { get; }
        string Elevation { get; set; }
        [UoM("ElevationUoM")]
        double? ElevationSiValue { get; }
    }
}
