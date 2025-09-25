using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs
{
    [DefUID("AnalysisDisplacementPrimitive")]
    public class AnalysisDisplacement : AnalysisNodeAuxiliary, IAnalysisDisplacement, IAnalysisVectorAuxiliary
    {
        public AnalysisDisplacement(AnalysisNode node = null) : base(node)
        {
        }
        public AnalysisDisplacement()
        {
        }


        public int? VectorNumber { get; set; }
        [NotMapped]
        public string DX { get; set; }
        [NotMapped]
        public string DY { get; set; }
        [NotMapped]
        public string DZ { get; set; }
        [NotMapped]
        public string RX { get; set; }
        [NotMapped]
        public string RY { get; set; }
        [NotMapped]
        public string RZ { get; set; }
        
        public double? DXSiValue { get; private set; }
        public double? DYSiValue { get; private set; }
        public double? DZSiValue { get; private set; }
        public double? RXSiValue { get; private set; }
        public double? RYSiValue { get; private set; }
        public double? RZSiValue { get; private set; }

        [NotMapped]
        public string PrimitiveName => $"{AnalysisPrimitive?.PrimitiveType}{AnalysisPrimitive?.Number}";

        public AnalysisOperatingPrimitive AnalysisPrimitive { get; set; }
        public string AnalysisPrimitiveId { get; set; }
    }
}