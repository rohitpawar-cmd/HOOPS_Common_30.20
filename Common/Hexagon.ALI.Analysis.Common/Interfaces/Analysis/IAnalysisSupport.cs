using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisSupport
    {
        [RelDef("AnalysisSupportToCAnalysisNode")]
        AnalysisNode AnalysisSupportToCAnalysisNode { get; set; }

        [RelDef("OwnsSupport", false, true)]
        Support OwnsSupport { get; set; }
    }
}
