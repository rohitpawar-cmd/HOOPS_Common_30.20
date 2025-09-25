using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase
{
    public class AnalysisLoadCaseComponent : AnalysisBaseObject
    {
        public AnalysisLoadCaseDefinition LoadCaseDefinition { get; set; }
        public AnalysisPrimitive Primitive { get; set; }
        public int ComponentOrderNumber { get; set; }
        public double Factor { get; set; }
    }
}
