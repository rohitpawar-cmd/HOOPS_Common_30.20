using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IWindPressureVsElevation
    {
        string Pressure { get; set; }
        [UoM("PressureUoM")]
        double? PressureSiValue { get; }
        string Elevation { get; set; }
        [UoM("ElevationUoM")]
        double? ElevationSiValue { get; }
    }
}
