using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Enums;
using System.ComponentModel;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries
{
    public interface IAnalysisNozzleLimitCheck
    {
        [PPMProperty("ComparisonMethod", "IAnalysisNozzleLimitCheck")]
        ComparisonMethod? ComparisonMethod { get; set; }

        [PPMProperty("RefVectorX", "IAnalysisNozzleLimitCheck")]
        double? RefVectorX { get; set; }

        [PPMProperty("RefVectorY", "IAnalysisNozzleLimitCheck")]
        double? RefVectorY { get; set; }

        [PPMProperty("RefVectorZ", "IAnalysisNozzleLimitCheck")]
        double? RefVectorZ { get; set; }
    }

    public enum ComparisonMethod
    {
        [Description("Absolute")]
        Absolute = 0,
        [Description("SRSS")]
        SRSS = 1,
        [Description("Unity Check")]
        UnityCheck = 2,
    }
}
