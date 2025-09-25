using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries
{
    [DefUID("AnalysisHanger")]
    public class AnalysisHanger : AnalysisSupport, IAnalysisHanger, IAnalysisHangerShared
    {
        public AnalysisHanger() : base(null, null)
        {

        }

        public AnalysisHanger(Support sioSupport = null, AnalysisNode node = null) : base(sioSupport, node)
        {
        }

        public List<AnalysisNode> AnalysisHangerFreeRestaintAtNode { get; set; } = new List<AnalysisNode>();

        public HangerTable? HangerTable { get; set; }
        public bool? ExtendedRange { get; set; }
        public bool? ColdLoad { get; set; }
        [NotMapped]
        public string AvailableSpace { get; set; }
        public double? LoadVariation { get; set; }
        [NotMapped]
        public string RigidDisplacement { get; set; }
        [NotMapped]
        public string MaxTravelLimit { get; set; }
        public int InputNumberofHangers { get; set; }
        public bool? ShortRangeSprings { get; set; }
        [NotMapped]
        public string OperatingLoad { get; set; }
        [NotMapped]
        public string HardwareWeight { get; set; }
        public HangerMultiLoadCaseOption? MultiLoadCaseOption { get; set; }
        public HangerFreeCodeType? FreeCodeType { get; set; }
        public bool? HotLoadCentered { get; set; }
        [NotMapped]
        public string UserSpringRate { get; set; }
        [NotMapped]
        public string UserColdLoad { get; set; }
        [NotMapped]
        public string UserConstantLoad { get; set; }
        public int MaximumNumberofHangersAllowed {  get; set; }


        public double? AvailableSpaceSiValue { get; private set; }
        public double? RigidDisplacementSiValue { get; set; }
        public double? MaxTravelLimitSiValue { get; private set; }
        public double? OperatingLoadSiValue { get; private set; }
        public double? HardwareWeightSiValue { get; private set; }
        public double? UserSpringRateSiValue { get; private set; }
        public double? UserColdLoadSiValue { get; private set; }
        public double? UserConstantLoadSiValue { get; private set; }
    }
}