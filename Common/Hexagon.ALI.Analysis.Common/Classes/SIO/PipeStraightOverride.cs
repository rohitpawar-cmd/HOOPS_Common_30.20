using Hexagon.ALI.Analysis.Common.Classes.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.SIO
{
    [DefUID("PipeStraightOverride")]
    public partial class PipeStraightOverride : PartOverride, IRteStraightPathOverride, IPartOverride
    {
        public PipeStraightOverride()
        {

        }


        #region PROPERTIES
        [NotMapped]
        public string StraightPathOverrideLength
        {
            get;
            set;
        }

        public double? StraightPathOverrideLengthSiValue
        {
            get;
            private set;
        }

        #endregion PROPERTIES
    }
}