using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries;
using System.ComponentModel.DataAnnotations.Schema;
using Hexagon.ALI.Analysis.Common.Enums;
using System.ComponentModel;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs.NozzleFlex
{
    [DefUID("AnalysisNozzleFlexAPI650")]
    public class AnalysisNozzleFlexAPI650 : AnalysisNozzleFlex, IAnalysisNozzleFlexAPI650
    {
        public AnalysisNozzleFlexAPI650(AnalysisNode analysisNode = null) : base(analysisNode)
        {
        }
        public AnalysisNozzleFlexAPI650()
        {

        }
        public AnalysisOperatingPrimitive AnalysisDisplacementPrimitive { get; set; }
        [NotMapped]
        public string NozzleDistanceToTank { get; set; }

        public double? NozzleDistanceToTankSiValue { get; protected set; }

        public NozzleReinforcingType? NozzleReinforcingType { get; set; }
        [NotMapped]
        public string TankModulusOfElasticity { get; set; }

        public double? TankModulusOfElasticitySiValue { get; protected set; }
        [NotMapped]
        public string TankCoefficientOfThermalExpansion { get; set; }

        public double? TankCoefficientOfThermalExpansionSiValue { get; protected set; }
        [NotMapped]
        public string TankTemperatureChange { get; set; }

        public double? TankTemperatureChangeSiValue { get; protected set; }
        [NotMapped]
        public string TankFluidHeight { get; set; }

        public double? TankFluidHeightSiValue { get; protected set; }

        public double? TankFluidStandardOfGravity { get; set; }


        [NotMapped] public string DisplacementVector => AnalysisDisplacementPrimitive != null ? $"D{AnalysisDisplacementPrimitive.Number}" : "";
    }
}