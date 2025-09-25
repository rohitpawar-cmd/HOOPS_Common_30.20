using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives
{
    public class AnalysisOperatingPrimitive : AnalysisPrimitive, IAnalysisOperatingPrimitive
    {
        public List<AnalysisProcessInfo> AnalysisOperatingPrimitiveToAnalysisProcessInfo { get; set; } = new List<AnalysisProcessInfo>();
        public List<AnalysisMaterialAllowableDataSet> AnalysisOperatingPrimitiveToAnalysisMaterialAllowableDataSet { get; set; } = new List<AnalysisMaterialAllowableDataSet>();
        public List<AnalysisUniformLoadDataSet> AnalysisOperatingPrimitiveToAnalysisUniformLoadDataSet { get; set; } = new List<AnalysisUniformLoadDataSet>();
        public List<AnalysisWaveLoad> AnalysisOperatingPrimitiveToAnalysisWaveLoad { get; set; } = new List<AnalysisWaveLoad>();
        public List<AnalysisWindLoad> AnalysisOperatingPrimitiveToAnalysisWindLoad { get; set; } = new List<AnalysisWindLoad>();
        public List<AnalysisDisplacement> AnalysisOperatingPrimitiveToAnalysisDisplacement { get; set; } = new List<AnalysisDisplacement>();
        public List<AnalysisAppliedPointForce> AnalysisOperatingPrimitiveToAnalysisAppliedPointForce { get; set; } = new List<AnalysisAppliedPointForce>();
    }
}
