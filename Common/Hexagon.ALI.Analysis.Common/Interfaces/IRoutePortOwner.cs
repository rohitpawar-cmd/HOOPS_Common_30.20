using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IRoutePortOwner
    {
        [RelDef("OwnsRoutePorts")]
        List<RoutePort> OwnsRoutePorts { get; set; }
    }


}
