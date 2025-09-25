using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.ComponentModel;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries
{
    public interface IAnalysisNozzleFlexPD5500
    {
        [PPMProperty("VesselType", "IAnalysisNozzleFlexPD5500")]
        VesselType? VesselType { get; set; }
    }

    public enum VesselType
    {
        [Description("Cylinder")]
        Cylinder = 1,
        [Description("Sphere")]
        Sphere = 2,
    }
}