using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisLocalForceMoments
    {
        #region PUBLIC PROPERTIES
        [UoM("ForceUoM")]
        [PPMProperty("LocalForceA", "IAnalysisLocalForceMoments")]
        string LocalForceA
        {
            get;
            set;
        }

        [UoM("ForceUoM")]
        [PPMProperty("LocalForceB", "IAnalysisLocalForceMoments")]
        string LocalForceB
        {
            get;
            set;
        }

        [UoM("ForceUoM")]
        [PPMProperty("LocalForceC", "IAnalysisLocalForceMoments")]
        string LocalForceC
        {
            get;
            set;
        }

        [UoM("MomentOutputUoM", "MomentInputUoM")]
        [PPMProperty("LocalMomentA", "IAnalysisLocalForceMoments")]
        string LocalMomentA
        {
            get;
            set;
        }

        [UoM("MomentOutputUoM", "MomentInputUoM")]
        [PPMProperty("LocalMomentB", "IAnalysisLocalForceMoments")]
        string LocalMomentB
        {
            get;
            set;
        }

        [UoM("MomentOutputUoM", "MomentInputUoM")]
        [PPMProperty("LocalMomentC", "IAnalysisLocalForceMoments")]
        string LocalMomentC
        {
            get;
            set;
        }
        #endregion

        #region SI VALUES
        double? LocalForceASiValue
        {
            get;
        }
        double? LocalForceBSiValue
        {
            get;
        }
        double? LocalForceCSiValue
        {
            get;
        }
        double? LocalMomentASiValue
        {
            get;
        }
        double? LocalMomentBSiValue
        {
            get;
        }
        double? LocalMomentCSiValue
        {
            get;
        }
        #endregion
    }
}
