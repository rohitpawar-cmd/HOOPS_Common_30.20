using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IDepthVsVelocity
    {
        string Depth { get; set; }
        [UoM("ElevationUoM")]
        double? DepthSiValue { get; }
        string Velocity { get; set; }
        [UoM("ElevationUoM")]
        double? VelocitySiValue { get; }
    }
}
