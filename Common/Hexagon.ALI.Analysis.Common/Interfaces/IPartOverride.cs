using Hexagon.ALI.Analysis.Common.Classes.Analysis.LineElements;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IPartOverride
    {
        Item Item { get; set; }
        string ItemId { get; set; }
        [RelDef("PartOverrideToAnalysisPipe")]
        List<AnalysisPipe> AnalysisBeams { get; set; }

    }
}
