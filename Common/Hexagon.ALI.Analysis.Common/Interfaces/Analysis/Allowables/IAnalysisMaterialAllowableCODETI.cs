using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowableCODETI
    {
        [PPMProperty(nameof(LongitudinalWeldJointEfficiency), nameof(IAnalysisMaterialAllowableCODETI))]
        double? LongitudinalWeldJointEfficiency { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(HydroTestAllowablePressure), nameof(IAnalysisMaterialAllowableCODETI))]
        string HydroTestAllowablePressure { get; set; }


        #region SI VALUES
        double? HydroTestAllowablePressureSiValue { get; }
        #endregion
    }
}
