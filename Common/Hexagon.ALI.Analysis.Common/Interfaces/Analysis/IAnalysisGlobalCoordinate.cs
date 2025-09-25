using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IAnalysisGlobalCoordinate
    {
        [PPMProperty("NodeId", "IAnalysisGlobalCoordinate")]
        AnalysisNode Node { get; set; }
    }
}

