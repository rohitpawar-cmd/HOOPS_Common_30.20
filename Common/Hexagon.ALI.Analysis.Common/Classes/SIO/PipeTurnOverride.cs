using Hexagon.ALI.Analysis.Common.Classes.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.SIO
{
    [DefUID("PipeTurnOverride")]
    public partial class PipeTurnOverride : PartOverride, IRteTurnPathOverride, IPartOverride
    {
        public PipeTurnOverride()
        {

        }


        #region PROPERTIES
        [NotMapped]
        public string TurnPathOverrideBendRadius
        {
            get;
            set;
        }

        public double? TurnPathOverrideBendRadiusSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string TurnPathOverrideBendAngle
        {
            get;
            set;
        }

        public double? TurnPathOverrideBendAngleSiValue
        {
            get;
            private set;
        }

        public string TurnPathOverrideBRadMulti
        {
            get;
            set;
        }
        [NotMapped]
        public string TurnPathOverrideThroatRadius
        {
            get;
            set;
        }

        public double? TurnPathOverrideThroatRadiusSiValue
        {
            get;
            private set;
        }

        public string NoOfMiters
        {
            get;
            set;
        }
        #endregion PROPERTIES
    }
}