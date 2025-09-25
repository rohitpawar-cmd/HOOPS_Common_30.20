using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowableHPSGL
    {
        [PPMProperty("LongitudinaWeldJointEfficiency", nameof(IAnalysisMaterialAllowableHPSGL))]
        double? LongitudinaWeldJointEfficiency { get; set; }

        [PPMProperty("CompositionType", nameof(IAnalysisMaterialAllowableHPSGL))]
        string CompositionType { get; set; }
    }
}
