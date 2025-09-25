using Hexagon.ALI.Analysis.Common.Helpers;


namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowableRCCMCD
    {
        [UoM("PressureUoM")]
        [PPMProperty(nameof(DifferenceOperatingPeakPressure), nameof(IAnalysisMaterialAllowableRCCMCD))]
        string DifferenceOperatingPeakPressure { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(HydroTestAllowablePressure), nameof(IAnalysisMaterialAllowableRCCMCD))]
        string HydroTestAllowablePressure { get; set; }


        #region SI VALUES
        double? DifferenceOperatingPeakPressureSiValue { get; }
        double? HydroTestAllowablePressureSiValue { get; }
        #endregion
    }
}
