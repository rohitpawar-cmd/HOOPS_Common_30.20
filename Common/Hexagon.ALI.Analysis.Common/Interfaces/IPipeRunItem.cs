using Hexagon.ALI.Analysis.Common.Classes.Analysis.LineElements;
using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.SIO;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IPipeRunItem
    {
        PipeRun PipeRun { get; set; }

        [RelDef("PipeRunItemToAnalysisPipe")]
        List<AnalysisPipe> AnalysisAbstractPipe { get; set; }

        [RelDef("OwnsConnectionParts")]
        List<ConnectionPart> ConnectionParts { get; set; }
    }

    public abstract class PipeRunItem : Item, IPipeRunItem, IRoutePortOwner, IPipeCommon, IItem
    {
        [RelDef()] public PipeRun PipeRun { get; set; }
        public List<AnalysisPipe> AnalysisAbstractPipe { get; set; } = new List<AnalysisPipe>();
        public List<ConnectionPart> ConnectionParts { get; set; } = new List<ConnectionPart>();
        public List<RoutePort> OwnsRoutePorts { get; set; } = new List<RoutePort>();
    }


}