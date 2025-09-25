using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IRteTurnPathOverride
    {
        [UoM("LengthUoM")]
        [PPMProperty("TurnPathOverrideBendRadius", "IRteTurnPathOverride")]
        string TurnPathOverrideBendRadius
        {
            get;
            set;
        }

        double? TurnPathOverrideBendRadiusSiValue
        {
            get;
        }

        [UoM("AngleUoM")]
        [PPMProperty("TurnPathOverrideBendAngle", "IRteTurnPathOverride")]
        string TurnPathOverrideBendAngle
        {
            get;
            set;
        }

        double? TurnPathOverrideBendAngleSiValue
        {
            get;
        }

        [PPMProperty("TurnPathOverrideBRadMulti", "IRteTurnPathOverride")]
        string TurnPathOverrideBRadMulti
        {
            get;
            set;
        }

        [UoM("LengthUoM")]
        [PPMProperty("TurnPathOverrideThroatRadius", "IRteTurnPathOverride")]
        string TurnPathOverrideThroatRadius
        {
            get;
            set;
        }

        double? TurnPathOverrideThroatRadiusSiValue
        {
            get;
        }

        [PPMProperty("NoOfMiters", "IRteTurnPathOverride")]
        string NoOfMiters
        {
            get;
            set;
        }
    }
}
