using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;
using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.SIF
{
    public interface IAnalysisSIFBaseData
    {
        [PPMProperty(nameof(ElasticModulusPrimitive), nameof(IAnalysisSIFBaseData))]
        AnalysisOperatingPrimitive ElasticModulusPrimitive { get; set; }

        [PPMProperty(nameof(PressurePrimitive), nameof(IAnalysisSIFBaseData))]
        AnalysisOperatingPrimitive PressurePrimitive { get; set; }
    }
}
