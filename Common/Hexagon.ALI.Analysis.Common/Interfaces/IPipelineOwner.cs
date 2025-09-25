using Hexagon.ALI.Analysis.Common.Classes;
using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IPipelineOwner
    {
        [RelDef("OwnsPipelines")]
        List<Pipeline> OwnsPipelines { get; set; }
    }

    public abstract class PipelineOwner : SIOEntity, IPipelineOwner
    {
        public List<Pipeline> OwnsPipelines { get; set; } = new List<Pipeline>();
    }

}
