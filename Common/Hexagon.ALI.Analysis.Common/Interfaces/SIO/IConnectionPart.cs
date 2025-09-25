using Hexagon.ALI.Analysis.Common.Classes;
using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.SIO
{
    public interface IConnectionPart
    {
        PipingPort PipingPort { get; set; }
        string PipingPortId { get; set; }

        PipeRunItem PipeRunItem { get; set; }
        string PipeRunItemId { get; set; }
    }
    public abstract class ConnectionPart : SIOEntity, IConnectionPart
    {
        public PipingPort PipingPort { get; set; }
        public string PipingPortId { get; set; }
        [RelDef()] public PipeRunItem PipeRunItem { get; set; }
        public string PipeRunItemId { get; set; }

    }
}
