using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.SIO
{
    [DefUID("BranchEndPort")]
    public class BranchEndPort : SIOEntity, IBranchEndPort, ILocation
    {
        public BranchEndPort()
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
        public PipeRun PipeRun { get; set; }
        public PipeRun RunEnd1 { get; set; }
        public string RunEnd1Id { get; set; }
        public PipeRun RunEnd2 { get; set; }
        public string RunEnd2Id { get; set; }
    }
}