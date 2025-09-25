using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;
using System.ComponentModel;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries
{
    public interface IAnalysisHanger
    {
        [RelDef("AnalysisHangerFreeRestaintAtNode")]
        List<AnalysisNode> AnalysisHangerFreeRestaintAtNode { get; set; }

        [PPMProperty("HangerTable", "IAnalysisHanger")]
        HangerTable? HangerTable { get; set; }

        [PPMProperty("ExtendedRange", "IAnalysisHanger")]
        bool? ExtendedRange { get; set; }

        [PPMProperty("ColdLoad", "IAnalysisHanger")]
        bool? ColdLoad { get; set; }

        [PPMProperty("HotLoadCentered", "IAnalysisHanger")]
        bool? HotLoadCentered { get; set; }

        [UoM("LengthUoM")]
        [PPMProperty("AvailableSpace", "IAnalysisHanger")]
        string AvailableSpace { get; set; }

        [UoM("LengthUoM")]
        [PPMProperty("RigidDisplacement", "IAnalysisHanger")]
        string RigidDisplacement { get; set; }

        [UoM("LengthUoM")]
        [PPMProperty("MaxTravelLimit", "IAnalysisHanger")]
        string MaxTravelLimit { get; set; }

        [PPMProperty("InputNumberofHangers", "IAnalysisHanger")]
        int InputNumberofHangers { get; set; }

        [PPMProperty("ShortRangeSprings", "IAnalysisHanger")]
        bool? ShortRangeSprings { get; set; }

        [UoM("ForceUoM")]
        [PPMProperty("OperatingLoad", "IAnalysisHanger")]
        string OperatingLoad { get; set; }

        [UoM("ForceUoM")]
        [PPMProperty("HardwareWeight", "IAnalysisHanger")]
        string HardwareWeight { get; set; }

        [PPMProperty("MultiLoadCaseOption", "IAnalysisHanger")]
        HangerMultiLoadCaseOption? MultiLoadCaseOption { get; set; }


        [PPMProperty("FreeCodeType", "IAnalysisHanger")]
        HangerFreeCodeType? FreeCodeType { get; set; }

        [UoM("ForceUoM")]
        [PPMProperty("UserColdLoad", "IAnalysisHanger")]
        string UserColdLoad { get; set; }

        [UoM("ForceUoM")]
        [PPMProperty("UserConstantLoad", "IAnalysisHanger")]
        string UserConstantLoad { get; set; }

        #region SI VALUES
        double? AvailableSpaceSiValue { get; }
        double? RigidDisplacementSiValue { get; }
        double? MaxTravelLimitSiValue { get; }
        double? OperatingLoadSiValue { get; }
        double? HardwareWeightSiValue { get; }
        double? UserColdLoadSiValue { get; }
        double? UserConstantLoadSiValue { get; }
        #endregion
    }
}
