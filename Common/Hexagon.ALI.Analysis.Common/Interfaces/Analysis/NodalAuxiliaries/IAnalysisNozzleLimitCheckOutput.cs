using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries
{
    public interface IAnalysisNozzleLimitCheckOutput
    {
        [PPMProperty(nameof(ForcesCheck), nameof(IAnalysisNozzleLimitCheckOutput))]
        double? ForcesCheck
        {
            get;
            set;
        }
        [UoM("ForceUoM")]
        [PPMProperty(nameof(FA), nameof(IAnalysisNozzleLimitCheckOutput))]
        string FA
        {
            get;
            set;
        }

        double? FASiValue
        {
            get;
        }

        [UoM("ForceUoM")]
        [PPMProperty(nameof(FB), nameof(IAnalysisNozzleLimitCheckOutput))]
        string FB
        {
            get;
            set;
        }

        double? FBSiValue
        {
            get;
        }

        [UoM("ForceUoM")]
        [PPMProperty(nameof(FC), nameof(IAnalysisNozzleLimitCheckOutput))]
        string FC
        {
            get;
            set;
        }

        double? FCSiValue
        {
            get;
        }
        [PPMProperty(nameof(MomentsCheck), nameof(IAnalysisNozzleLimitCheckOutput))]
        double? MomentsCheck
        {
            get;
            set;
        }
        [UoM("MomentOutputUoM")]
        [PPMProperty(nameof(MA), nameof(IAnalysisNozzleLimitCheckOutput))]
        string MA
        {
            get; set;
        }

        double? MASiValue
        {
            get;
        }

        [UoM("MomentOutputUoM")]
        [PPMProperty(nameof(MB), nameof(IAnalysisNozzleLimitCheckOutput))]
        string MB
        {
            get; set;
        }

        double? MBSiValue
        {
            get;
        }

        [UoM("MomentOutputUoM")]
        [PPMProperty(nameof(MC), nameof(IAnalysisNozzleLimitCheckOutput))]
        string MC
        {
            get; set;
        }

        double? MCSiValue
        {
            get;
        }
    }
}
