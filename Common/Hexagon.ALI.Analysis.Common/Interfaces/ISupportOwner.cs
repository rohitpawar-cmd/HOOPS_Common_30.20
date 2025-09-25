using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface ISupportOwner
    {
        [RelDef("OwnsSupports")]
        List<Support> OwnsSupports { get; set; }

    }
}
