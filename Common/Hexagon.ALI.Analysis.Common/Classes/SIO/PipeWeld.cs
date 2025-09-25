using Hexagon.ALI.Analysis.Common.Interfaces;
using Hexagon.ALI.Analysis.Common.Interfaces.SIO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.SIO
{
    public class PipeWeld : ConnectionPart, ILocation
    {
        public PipeWeld()
        {

        }
        [NotMapped]
        public string LocationX
        {
            get;
            set;
        }

        public double? LocationXSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string LocationY
        {
            get;
            set;
        }

        public double? LocationYSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string LocationZ
        {
            get;
            set;
        }

        public double? LocationZSiValue
        {
            get;
            private set;
        }
    }
}
