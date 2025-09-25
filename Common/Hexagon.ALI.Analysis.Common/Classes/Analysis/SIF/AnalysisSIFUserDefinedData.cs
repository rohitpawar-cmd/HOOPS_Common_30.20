using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.SIF;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.SIF
{
    public class AnalysisSIFUserDefinedData : AnalysisBaseObject, IAnalysisSIFBaseData, IAnalysisSIFUserDefinedData, IAnalysisSIFData
    {
        public AnalysisOperatingPrimitive ElasticModulusPrimitive { get; set; }
        public AnalysisOperatingPrimitive PressurePrimitive { get; set; }
        public AnalysisBaseSif AnalysisBaseSif { get; set; }
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
        public double? NuclearB1 { get; set; }
        public double? NuclearB2 { get; set; }
    }
}
