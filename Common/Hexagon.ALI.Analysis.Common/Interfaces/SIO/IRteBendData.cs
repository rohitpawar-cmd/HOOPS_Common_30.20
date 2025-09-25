using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IRteBendData
    {
        [UoM("AngleUoM")]
        [PPMProperty("RteBendDataBendAngle", "IRteBendData")]
        string RteBendDataBendAngle
        {
            get;
            set;
        }

        double? RteBendDataBendAngleSiValue
        {
            get;
        }

        [UoM("LengthUoM")]
        [PPMProperty("RteBendDataBendRadius", "IRteBendData")]
        string RteBendDataBendRadius
        {
            get;
            set;
        }

        double? RteBendDataBendRadiusSiValue
        {
            get;
        }

        [PPMProperty("RteBendDataBRadMulti", "IRteBendData")]
        string RteBendDataBRadMulti
        {
            get;
            set;
        }

        [PPMProperty("RteBendDataNoOfMiters", "IRteBendData")]
        string RteBendDataNoOfMiters
        {
            get;
            set;
        }

        [UoM("LengthUoM")]
        [PPMProperty("RteBendDataThroatRadius", "IRteBendData")]
        string RteBendDataThroatRadius
        {
            get;
            set;
        }

        double? RteBendDataThroatRadiusSiValue
        {
            get;
        }
    }
}
