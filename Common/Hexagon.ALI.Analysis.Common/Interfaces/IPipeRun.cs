using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IPipeRun
    {
        Pipeline Pipeline { get; set; }

        [RelDef("PipeRunItems")]
        List<PipeRunItem> PipeRunItems { get; set; }
    }
}
