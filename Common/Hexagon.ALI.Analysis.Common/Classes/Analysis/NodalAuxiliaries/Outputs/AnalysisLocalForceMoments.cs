using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Outputs
{
    [DefUID("AnalysisLocalForceMoments")]
    public class AnalysisLocalForceMoments : AnalysisForceMomentOutput
    {
        public AnalysisLocalForceMoments(AnalysisNode node = null, AnalysisLoadCase loadCase = null) : base(node, loadCase)
        {
        }
        public AnalysisLocalForceMoments()
        {

        }
    }
}
