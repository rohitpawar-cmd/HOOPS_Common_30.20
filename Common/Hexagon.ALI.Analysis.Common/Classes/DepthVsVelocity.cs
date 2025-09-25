using Hexagon.ALI.Analysis.Common.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes
{
    public class DepthVsVelocity : IDepthVsVelocity
    {
        public string Id { get; set; }
        [NotMapped]
        public string Depth { get; set; }
        public double? DepthSiValue { get; private set; }
        [NotMapped]
        public string Velocity { get; set; }
        public double? VelocitySiValue { get; private set; }
    }
}
