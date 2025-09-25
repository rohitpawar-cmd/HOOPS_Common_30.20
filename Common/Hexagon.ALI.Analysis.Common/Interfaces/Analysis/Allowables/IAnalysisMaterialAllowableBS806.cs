using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowableBS806
    {
        [PPMProperty(nameof(FactorForMinimumWallThickness), nameof(IAnalysisMaterialAllowableBS806))]
        double? FactorForMinimumWallThickness { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(SustainedStressLimit), nameof(IAnalysisMaterialAllowableBS806))]
        string SustainedStressLimit { get; set; }


        #region SI VALUES
        double? SustainedStressLimitSiValue { get; }
        #endregion
    }
}
