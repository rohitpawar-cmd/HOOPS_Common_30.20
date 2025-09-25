using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries
{
    public interface IAnalysisNozzleFlexAPI650
    {
        [RelDef("AnalysisDisplacementPrimitive")]
        AnalysisOperatingPrimitive AnalysisDisplacementPrimitive { get; set; }

        [UoM("LengthUoM")]
        [PPMProperty("NozzleDistanceToTank", "IAnalysisNozzleFlexAPI650")]
        string NozzleDistanceToTank { get; set; }

        double? NozzleDistanceToTankSiValue { get; }

        [PPMProperty("NozzleReinforcingType", "IAnalysisNozzleFlexAPI650")]
        NozzleReinforcingType? NozzleReinforcingType { get; set; }

        [UoM("StressUoM")]
        [PPMProperty("TankModulusOfElasticity", "IAnalysisNozzleFlexAPI650")]
        string TankModulusOfElasticity { get; set; }

        double? TankModulusOfElasticitySiValue { get; }

        [UoM("CoefficientOfThermalExpansionUoM")]
        [PPMProperty("TankCoefficientOfThermalExpansion", "IAnalysisNozzleFlexAPI650")]
        string TankCoefficientOfThermalExpansion { get; set; }

        double? TankCoefficientOfThermalExpansionSiValue { get; }

        [UoM("TemperatureUoM")]
        [PPMProperty("TankTemperatureChange", "IAnalysisNozzleFlexAPI650")]
        string TankTemperatureChange { get; set; }

        double? TankTemperatureChangeSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("TankFluidHeight", "IAnalysisNozzleFlexAPI650")]
        string TankFluidHeight { get; set; }

        double? TankFluidHeightSiValue { get; }

        [PPMProperty("TankFluidStandardOfGravity", "IAnalysisNozzleFlexAPI650")]
        double? TankFluidStandardOfGravity { get; set; }

        [NotMapped] string DisplacementVector { get; }
    }

    public enum NozzleReinforcingType
    {
        [Description("Shell")]
        Shell = 1,
        [Description("Nozzle")]
        Nozzle = 2,
    }
}