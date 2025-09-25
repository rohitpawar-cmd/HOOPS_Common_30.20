using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IStartEndLocation
    {
        [UoM("LengthUoM")]
        [PPMProperty("StartLocX", "IStartEndLocation")]
        string StartLocX
        {
            get;
            set;
        }

        double? StartLocXSiValue
        {
            get;
        }

        [UoM("LengthUoM")]
        [PPMProperty("StartLocY", "IStartEndLocation")]
        string StartLocY
        {
            get;
            set;
        }

        double? StartLocYSiValue
        {
            get;
        }

        [UoM("LengthUoM")]
        [PPMProperty("StartLocZ", "IStartEndLocation")]
        string StartLocZ
        {
            get;
            set;
        }

        double? StartLocZSiValue
        {
            get;
        }

        [UoM("LengthUoM")]
        [PPMProperty("EndLocX", "IStartEndLocation")]
        string EndLocX
        {
            get;
            set;
        }

        double? EndLocXSiValue
        {
            get;
        }

        [UoM("LengthUoM")]
        [PPMProperty("EndLocY", "IStartEndLocation")]
        string EndLocY
        {
            get;
            set;
        }

        double? EndLocYSiValue
        {
            get;
        }

        [UoM("LengthUoM")]
        [PPMProperty("EndLocZ", "IStartEndLocation")]
        string EndLocZ
        {
            get;
            set;
        }

        double? EndLocZSiValue
        {
            get;
        }
    }
}
