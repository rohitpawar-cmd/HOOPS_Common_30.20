using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs.SIF;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.SIF;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.SIF
{
    public class AnalysisSIFOutput : AnalysisBaseObject, IAnalysisSIFBaseData, IAnalysisSIFOutput, IAnalysisSIFData
    {        
        public TeeComposition Composition { get; set; }
        public AnalysisOperatingPrimitive ElasticModulusPrimitive { get; set; }
        public AnalysisOperatingPrimitive PressurePrimitive { get; set; }
        public AnalysisSIFFittingOutput SIFFittingOutput { get; set; }
        public double? InplaneSIF { get; set; }
        public double? InplaneIndex { get; set; }
        public double? InplaneFlexibility { get; set; }
        public double? OutplaneSIF { get; set; }
        public double? OutplaneIndex { get; set; }
        public double? OutplaneFlexibility { get; set; }
        public double? TorsionSIF { get; set; }
        public double? TorsionIndex { get; set; }
        public double? TorsionFlexibility { get; set; }
        public double? AxialSIF { get; set; }
        public double? AxialIndex { get; set; }
        public double? AxialFlexibility { get; set; }
        public double? PressureSIF { get; set; }
        public double? PressureIndex { get; set; }
        public double? PressureFlexibility { get; set; }
        public double? ShearSIF { get; set; }
        public double? ShearIndex { get; set; }

    }
}
