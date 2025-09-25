using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.ComponentModel.DataAnnotations.Schema;


namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract
{
    public abstract class AnalysisVectorAuxiliary : AnalysisBaseObject, IAnalysisVectorAuxiliary
    {
        protected AnalysisVectorAuxiliary()
        {
            AnalysisPrimitive = new AnalysisOperatingPrimitive();
        }
        [RelDef()] public AnalysisOperatingPrimitive AnalysisPrimitive { get; set; }
        public string AnalysisPrimitiveId { get; set; }
        [NotMapped]
        public string PrimitiveName => $"{AnalysisPrimitive?.PrimitiveType}{AnalysisPrimitive?.Number}";
    }
}
