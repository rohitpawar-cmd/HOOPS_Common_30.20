using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis
{
    public class AnalysisWind : AnalysisBaseObject, IAnalysisWind
    {
        public double? WindShapeFactor { get; set; }
        public List<AnalysisLineElement> AnalysisLineElements { get; set; } = new List<AnalysisLineElement>();
    }
}
