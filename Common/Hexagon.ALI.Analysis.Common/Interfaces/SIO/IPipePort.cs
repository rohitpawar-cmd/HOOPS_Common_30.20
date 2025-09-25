using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IPipePort
    {
        [PPMProperty("PipePortIndex", "IPipePort")]
        string PipePortIndex
        {
            get;
            set;
        }

        [UoM("NominalDiameterUoM")]
        [PPMProperty("PipePortNpd", "IPipePort")]
        string PipePortNpd
        {
            get;
            set;
        }

        double? PipePortNpdSiValue
        {
            get;
        }

        [UoM("LengthUoM")]
        [PPMProperty("PipingOutsideDiameter", "IPipePort")]
        string PipingOutsideDiameter
        {
            get;
            set;
        }

        double? PipingOutsideDiameterSiValue
        {
            get;
        }

        [UoM("LengthUoM")]
        [PPMProperty("ReinforcedWallThickness", "IPipePort")]
        string ReinforcedWallThickness
        {
            get;
            set;
        }

        double? ReinforcedWallThicknessSiValue
        {
            get;
        }

        [UoM("LengthUoM")]
        [PPMProperty("WallThicknessOrGrooveSetback", "IPipePort")]
        string WallThicknessOrGrooveSetback
        {
            get;
            set;
        }

        double? WallThicknessOrGrooveSetbackSiValue
        {
            get;
        }

        [PPMProperty("PipePortScheduleThickness", "IPipePort")]
        string PipePortScheduleThickness
        {
            get;
            set;
        }

        [PPMProperty("PipePortSchedulePractice", "IPipePort")]
        string PipePortSchedulePractice
        {
            get;
            set;
        }
    }
}
