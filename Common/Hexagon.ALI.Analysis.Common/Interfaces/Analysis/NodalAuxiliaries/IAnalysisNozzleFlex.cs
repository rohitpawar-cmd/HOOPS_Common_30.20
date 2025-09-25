using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries
{
    public interface IAnalysisNozzleFlex
    {
        [RelDef("AnalysisNozzleFlexToTankVesselNode")]
        AnalysisNode AnalysisNozzleFlexToTankVesselNode { get; set; }

        [PPMProperty("CosX", "IAnalysisNozzleFlex")]
        double? CosX { get; set; }

        [PPMProperty("CosY", "IAnalysisNozzleFlex")]
        double? CosY { get; set; }

        [PPMProperty("CosZ", "IAnalysisNozzleFlex")]
        double? CosZ { get; set; }

        [UoM("LengthUoM")]
        [PPMProperty("NozzleVesselOuterDiameter", "IAnalysisNozzleFlex")]
        string NozzleVesselOuterDiameter { get; set; }

        double? NozzleVesselOuterDiameterSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("NozzleWallThickness", "IAnalysisNozzleFlex")]
        string NozzleWallThickness { get; set; }

        double? NozzleWallThicknessSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("TankVesselOuterDiameter", "IAnalysisNozzleFlex")]
        string TankVesselOuterDiameter { get; set; }

        double? TankVesselOuterDiameterSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("TankVesselWallThickness", "IAnalysisNozzleFlex")]
        string TankVesselWallThickness { get; set; }

        double? TankVesselWallThicknessSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("TankVesselPadThickness", "IAnalysisNozzleFlex")]
        string TankVesselPadThickness { get; set; }

        double? TankVesselPadThicknessSiValue { get; }

        [PPMProperty("TankVesselMaterial", "IAnalysisNozzleFlex")]
        string TankVesselMaterial { get; set; }


        [NotMapped] string TankVesselNode { get; }
    }
}