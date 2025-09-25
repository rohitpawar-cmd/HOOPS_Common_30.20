using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract
{
    [DefUID("AnalysisPrimitive")]
    public abstract class AnalysisPrimitive : AnalysisBaseObject, IAnalysisPrimitive
    {
        [RelDef()] public PipingSystem PipingSystem { get; set; }
        public string PipingSystemId { get; set; }
        public PrimitiveType PrimitiveType { get; set; } = PrimitiveType.UNDEFINED;
        public int? Number { get; set; }
    }
}

