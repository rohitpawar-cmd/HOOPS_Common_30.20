using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisWind
    {
        List<AnalysisLineElement> AnalysisLineElements { get; set; }
        double? WindShapeFactor { get; set; }
    }
}
