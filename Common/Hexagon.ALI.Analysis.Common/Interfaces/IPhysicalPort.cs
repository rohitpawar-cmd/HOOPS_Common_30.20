using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IPhysicalPort
    {
        PhysicalPort Port { get; set; }
        string PortId { get; set; }
        [RelDef("PhysicalPortToPort")]
        List<PhysicalPort> PhysicalPortToPort { get; set; }

    }
    public abstract class PhysicalPort : RoutePort, IPhysicalPort
    {
        public string PortId { get; set; }
        [RelDef()] public List<PhysicalPort> PhysicalPortToPort { get; set; } = new List<PhysicalPort>();
        [RelDef()] public PhysicalPort Port { get; set; }
    }
}
