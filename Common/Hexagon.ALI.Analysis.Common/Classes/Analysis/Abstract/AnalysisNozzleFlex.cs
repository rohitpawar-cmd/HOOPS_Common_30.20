using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract
{
    [DefUID("AnalysisNozzleFlex")]
    public abstract class AnalysisNozzleFlex : AnalysisNodeAuxiliary, IAnalysisNozzleFlex
    {
        public AnalysisNozzleFlex(AnalysisNode analysisNode = null) : base(analysisNode)
        {
            AnalysisNozzleFlexToTankVesselNode = null;
        }

        public AnalysisNode AnalysisNozzleFlexToTankVesselNode { get; set; }
        public string AnalysisNozzleFlexToTankVesselNodeId { get; set; }

        public double? CosX { get; set; }

        public double? CosY { get; set; }

        public double? CosZ { get; set; }
        [NotMapped]
        public string NozzleVesselOuterDiameter { get; set; }

        public double? NozzleVesselOuterDiameterSiValue { get; protected set; }
        [NotMapped]
        public string NozzleWallThickness { get; set; }

        public double? NozzleWallThicknessSiValue { get; protected set; }
        [NotMapped]
        public string TankVesselOuterDiameter { get; set; }

        public double? TankVesselOuterDiameterSiValue { get; protected set; }
        [NotMapped]
        public string TankVesselWallThickness { get; set; }

        public double? TankVesselWallThicknessSiValue { get; protected set; }
        [NotMapped]
        public string TankVesselPadThickness { get; set; }

        public double? TankVesselPadThicknessSiValue { get; protected set; }

        public string TankVesselMaterial { get; set; }

        [NotMapped] public string TankVesselNode => AnalysisNozzleFlexToTankVesselNode?.NodeNumber ?? "";
    }
}