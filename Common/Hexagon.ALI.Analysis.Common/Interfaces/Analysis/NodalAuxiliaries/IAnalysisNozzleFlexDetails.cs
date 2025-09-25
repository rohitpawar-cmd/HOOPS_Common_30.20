using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries
{
    public interface IAnalysisNozzleFlexDetails
    {
        [UoM("LengthUoM")]
        [PPMProperty("NozzleDistanceToStiffenerHead", "IAnalysisNozzleFlexDetails")]
        string NozzleDistanceToStiffenerHead { get; set; }

        double? NozzleDistanceToStiffenerHeadSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("NozzleDistanceToOppositeStiffener", "IAnalysisNozzleFlexDetails")]
        string NozzleDistanceToOppositeStiffener { get; set; }

        double? NozzleDistanceToOppositeStiffenerSiValue { get; }

        [UoM("TemperatureUoM")]
        [PPMProperty("VesselTemperature", "IAnalysisNozzleFlexDetails")]
        string VesselTemperature { get; set; }

        double? VesselTemperatureSiValue { get; }
    }
}