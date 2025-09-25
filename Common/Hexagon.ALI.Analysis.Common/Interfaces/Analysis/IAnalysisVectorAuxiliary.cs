using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;
using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisVectorAuxiliary
    {
        [RelDef("OperatingPrimitive", true)]
        AnalysisOperatingPrimitive AnalysisPrimitive { get; set; }
        string AnalysisPrimitiveId { get; set; }
        string PrimitiveName { get; }
    }    
}
