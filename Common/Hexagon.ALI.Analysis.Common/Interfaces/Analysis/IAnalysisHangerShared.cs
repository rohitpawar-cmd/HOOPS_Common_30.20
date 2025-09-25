using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisHangerShared
    {
        [UoM("ForceUoM")]
        [PPMProperty(nameof(OperatingLoad), nameof(IAnalysisHangerShared))]
        string OperatingLoad { get; set; }

        [UoM("TranslationalUoM")]
        [PPMProperty(nameof(UserSpringRate), nameof(IAnalysisHangerShared))]
        string UserSpringRate { get; set; }

        [PPMProperty(nameof(LoadVariation), nameof(IAnalysisHangerShared))]
        double? LoadVariation { get; set; }

        #region SI VALUES
        double? UserSpringRateSiValue { get; }
        double? OperatingLoadSiValue { get; }
        #endregion
    }
}
