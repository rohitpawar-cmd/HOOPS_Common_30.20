using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IRtePipePathOverride
    {
        [UoM("NominalDiameterUoM")]
        [PPMProperty("PipePathOverrideNPD", "IRtePipePathOverride")]
        string PipePathOverrideNPD
        {
            get;
            set;
        }

        double? PipePathOverrideNPDSiValue
        {
            get;
        }

        [UoM("LengthUoM")]
        [PPMProperty("PipePathOverrideOuterDiameter", "IRtePipePathOverride")]
        string PipePathOverrideOuterDiameter
        {
            get;
            set;
        }

        double? PipePathOverrideOuterDiameterSiValue
        {
            get;
        }

    }
}
