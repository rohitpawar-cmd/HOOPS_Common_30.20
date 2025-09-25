using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces.SIO
{
    public interface IPipingPort : IPipePort
    {
        [RelDef("PipingPortOwnsParts")]
        List<ConnectionPart> Parts { get; set; }

    }
}
