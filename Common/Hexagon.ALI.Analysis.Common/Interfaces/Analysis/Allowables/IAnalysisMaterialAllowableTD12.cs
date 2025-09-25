using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowableTD12
    {
        [PPMProperty("SystemDesignFactor", nameof(IAnalysisMaterialAllowableTD12))]
        double? SystemDesignFactor { get; set; }

        [PPMProperty("MaterialShakedownFactor", nameof(IAnalysisMaterialAllowableTD12))]
        double? MaterialShakedownFactor { get; set; }
    }
}
