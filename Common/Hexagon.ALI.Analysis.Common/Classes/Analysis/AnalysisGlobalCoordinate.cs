using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.ComponentModel.DataAnnotations.Schema;
using Hexagon.ALI.Analysis.Common.Interfaces;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis
{
    [DefUID("AnalysisGlobalCoordinate")]
    public class AnalysisGlobalCoordinate : AnalysisBaseObject, IAnalysisGlobalCoordinate
    {
        public AnalysisGlobalCoordinate(AnalysisNode analysisNode)
        {
            Node = analysisNode;
        }

        public AnalysisGlobalCoordinate()
        {
        }

        public AnalysisNode Node { get; set; }
    }
}
