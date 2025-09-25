using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces;
using Hexagon.ALI.Analysis.Common.Interfaces.SIO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Classes.SIO
{
    [DefUID("PipingPort")]
    [ExcludeFromCodeCoverage]
    public class PipingPort : PhysicalPort, IPipePort, ILocation, IPipingPort, IRoutePort, IPhysicalPort, IRoutePortOwner
    {
        public PipingPort()
        {
        }
        public PhysicalPort PhysicalPort { get; set; }
        #region RELATIONS

        public List<ConnectionPart> Parts { get; set; } = new List<ConnectionPart> { };
        #endregion RELATIONS

        public string pipingOutsideDiameter;
        public string reinforcedWallThickness;

        #region PROPERTIES


        public string PipePortIndex
        {
            get;
            set;
        }
        [NotMapped]
        public string PipePortNpd
        {
            get;
            set;
        }

        public double? PipePortNpdSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string PipingOutsideDiameter
        {
            get;
            set;
        }

        public double? PipingOutsideDiameterSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string ReinforcedWallThickness
        {
            get;
            set;
        }

        public double? ReinforcedWallThicknessSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string WallThicknessOrGrooveSetback
        {
            get;
            set;
        }

        public double? WallThicknessOrGrooveSetbackSiValue
        {
            get;
            private set;
        }

        public string PipePortScheduleThickness
        {
            get;
            set;
        }

        public string PipePortSchedulePractice
        {
            get;
            set;
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
        public List<RoutePort> OwnsRoutePorts { get; set; }

        #endregion PROPERTIES
    }
}