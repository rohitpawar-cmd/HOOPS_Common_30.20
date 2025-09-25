using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    internal interface IAnalysisOperatingPrimitive
    {
        [RelDef("AnalysisOperatingPrimitiveToAnalysisProcessInfo", true, false)]
        List<AnalysisProcessInfo> AnalysisOperatingPrimitiveToAnalysisProcessInfo { get; set; }

        [RelDef("AnalysisOperatingPrimitiveToAnalysisMaterialAllowableDataSet", true, false)]
        List<AnalysisMaterialAllowableDataSet> AnalysisOperatingPrimitiveToAnalysisMaterialAllowableDataSet { get; set; }

        [RelDef("AnalysisOperatingPrimitiveToAnalysisUniformLoadDataSet", true, false)]
        List<AnalysisUniformLoadDataSet> AnalysisOperatingPrimitiveToAnalysisUniformLoadDataSet { get; set; }

        [RelDef("AnalysisOperatingPrimitiveToAnalysisWaveLoad", true, false)]
        List<AnalysisWaveLoad> AnalysisOperatingPrimitiveToAnalysisWaveLoad { get; set; }

        [RelDef("AnalysisOperatingPrimitiveToAnalysisWindLoad", true, false)]
        List<AnalysisWindLoad> AnalysisOperatingPrimitiveToAnalysisWindLoad { get; set; }

        [RelDef("AnalysisOperatingPrimitiveToAnalysisDisplacement", true, false)]
        List<AnalysisDisplacement> AnalysisOperatingPrimitiveToAnalysisDisplacement { get; set; }

        [RelDef("AnalysisOperatingPrimitiveToAnalysisAppliedPointForce", true, false)]
        List<AnalysisAppliedPointForce> AnalysisOperatingPrimitiveToAnalysisAppliedPointForce { get; set; }
    }
}
