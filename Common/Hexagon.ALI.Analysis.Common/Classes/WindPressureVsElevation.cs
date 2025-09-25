using Hexagon.ALI.Analysis.Common.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes
{
    public class WindPressureVsElevation : IWindPressureVsElevation
    {
        public string Id { get; set; }
        [NotMapped]
        public string Pressure { get; set; }
        public double? PressureSiValue { get; private set; }
        [NotMapped]
        public string Elevation { get; set; }
        public double? ElevationSiValue { get; private set; }
    }
}
