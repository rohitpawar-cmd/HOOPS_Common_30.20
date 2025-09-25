using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowableJPI
    {
        [PPMProperty("LongitudinaWeldJointEfficiency", nameof(IAnalysisMaterialAllowableJPI))]
        double? LongitudinaWeldJointEfficiency { get; set; }

        [PPMProperty("CompositionType", nameof(IAnalysisMaterialAllowableJPI))]
        string CompositionType { get; set; }
    }
}
