using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Enums.WindLoadEnums;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries
{
    public abstract class AnalysisWindLoad : AnalysisVectorAuxiliary
    {
        public WindCode WindCode { get; set; }
        public string CodeYear { get; set; }
        public double? CosX { get; set; }
        public double? CosY { get; set; }
        public double? CosZ { get; set; }
    }
}