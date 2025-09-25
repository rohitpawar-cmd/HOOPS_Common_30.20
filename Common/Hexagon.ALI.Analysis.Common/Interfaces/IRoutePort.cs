using Hexagon.ALI.Analysis.Common.Classes;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IRoutePort
    {
        RoutePort RoutePortOwner { get; set; }
        string RoutePortOwnerId { get; set; }

    }
    public abstract class RoutePort : SIOEntity, IRoutePort
    {
        public RoutePort RoutePortOwner { get; set; }
        public string RoutePortOwnerId { get; set; }
    }
}
