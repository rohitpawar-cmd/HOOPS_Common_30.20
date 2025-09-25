using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisRestraintReaction
    {

        #region PUBLIC PROPERTIES
        [UoM("ForceUoM")]
        [PPMProperty("ResultantForce", "IAnalysisRestraintReaction")]
        string ResultantForce
        {
            get;
            set;
        }

        [UoM("MomentOutputUoM", "MomentInputUoM")]
        [PPMProperty("ResultantMoment", "IAnalysisRestraintReaction")]
        string ResultantMoment
        {
            get; set;
        }

        [PPMProperty("RigidOrFlexFlag", "IAnalysisRestraintReaction")]
        int? RigidOrFlexFlag
        {
            get;
            set;
        }

        [PPMProperty("RestraintType", "IAnalysisRestraintReaction")]
        RestraintType? RestraintType
        {
            get;
            set;
        }

        string RestraintTypeDisplay { get; }

        #endregion

        #region SI VALUES
        double? ResultantForceSiValue
        {
            get;
        }
        double? ResultantMomentSiValue
        {
            get;
        }

        #endregion
    }
}
