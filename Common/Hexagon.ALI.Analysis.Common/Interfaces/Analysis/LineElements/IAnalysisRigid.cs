using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.ComponentModel;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.LineElementAuxiliaries
{
    public interface IAnalysisRigid
    {
        [PPMProperty("RigidType", "IAnalysisRigid")]
        RigidType? RigidType
        {
            get;
            set;
        }

        [UoM("ForceUoM")]
        [PPMProperty("RigidWeight", "IAnalysisRigid")]
        string RigidWeight
        {
            get;
            set;
        }

        double? RigidWeightSiValue
        {
            get;
        }        
    }

    public enum RigidType
    {
        [Description("Unspecified")]
        Unspecified = 0,
        [Description("Valve")]
        Valve = 1,
        [Description("Flange")]
        Flange = 2,
        [Description("Flange Pair")]
        FlangePair = 3,
        [Description("Flanged Valve")]
        FlangedValve = 4,
    }
}