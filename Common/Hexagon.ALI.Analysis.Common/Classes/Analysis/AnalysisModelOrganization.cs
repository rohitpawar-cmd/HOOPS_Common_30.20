using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis
{
    public class AnalysisModelOrganization : AnalysisBaseObject, IAnalysisModelOrganization, IAnalysisGraphics
    {
        public string CAESARIILineNumber { get; set; }
        public int? Red { get; set; }
        public int? Green { get; set; }
        public int? Blue{ get; set; }
        public double? Visibility { get; set; }
        [RelDef()] public List<AnalysisLineElement> AnalysisLineElements { get; set; } = new List<AnalysisLineElement>();
    }
}
