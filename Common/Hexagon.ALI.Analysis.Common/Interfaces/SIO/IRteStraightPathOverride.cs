using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IRteStraightPathOverride
    {
        [UoM("LengthUoM")]
        [PPMProperty("StraightPathOverrideLength", "IRteStraightPathOverride")]
        string StraightPathOverrideLength
        {
            get;
            set;
        }

        double? StraightPathOverrideLengthSiValue
        {
            get;
        }
    }
}
