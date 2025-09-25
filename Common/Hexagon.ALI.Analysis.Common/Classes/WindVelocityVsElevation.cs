using Hexagon.ALI.Analysis.Common.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes
{
    public class WindVelocityVsElevation : IWindVelocityVsElevation
    {
        public string Id { get; set; }
        [NotMapped]
        public string Velocity { get; set; }

        public double? VelocitySiValue { get; private set; }
        [NotMapped]
        public string Elevation { get; set; }

        public double? ElevationSiValue { get; private set; }
    }
}
