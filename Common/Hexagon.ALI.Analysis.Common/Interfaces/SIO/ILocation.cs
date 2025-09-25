using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface ILocation
    {
        [UoM("LengthUoM")]
        [PPMProperty("LocationX", "ILocation")]
        string LocationX
        {
            get;
            set;
        }

        double? LocationXSiValue
        {
            get;
        }

        [UoM("LengthUoM")]
        [PPMProperty("LocationY", "ILocation")]
        string LocationY
        {
            get; set;
        }

        double? LocationYSiValue
        {
            get;
        }

        [UoM("LengthUoM")]
        [PPMProperty("LocationZ", "ILocation")]
        string LocationZ
        {
            get; set;
        }

        double? LocationZSiValue
        {
            get;
        }
    }
}
