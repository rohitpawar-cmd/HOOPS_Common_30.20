using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IOrientation
    {
        [PPMProperty("RadialOrientX", "IOrientation")]
        double RadialOrientX
        {
            get; set;
        }

        [PPMProperty("RadialOrientY", "IOrientation")]
        double RadialOrientY
        {
            get; set;
        }

        [PPMProperty("RadialOrientZ", "IOrientation")]
        double RadialOrientZ
        {
            get; set;
        }

        [PPMProperty("OrientationX", "IOrientation")]
        double OrientationX
        {
            get; set;
        }

        [PPMProperty("OrientationY", "IOrientation")]
        double OrientationY
        {
            get; set;
        }

        [PPMProperty("OrientationZ", "IOrientation")]
        double OrientationZ
        {
            get; set;
        }

        [PPMProperty("UVectorX", "IOrientation")]
        double UVectorX
        {
            get; set;
        }

        [PPMProperty("UVectorY", "IOrientation")]
        double UVectorY
        {
            get; set;
        }

        [PPMProperty("UVectorZ", "IOrientation")]
        double UVectorZ
        {
            get; set;
        }
    }
}
