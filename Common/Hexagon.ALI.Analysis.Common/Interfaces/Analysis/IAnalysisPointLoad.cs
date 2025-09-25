using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisPointLoad
    {
        [UoM("ForceUoM")]
        [PPMProperty("FX", "IAnalysisPointLoad")]
        string FX
        {
            get;
            set;
        }

        double? FXSiValue
        {
            get;
        }

        [UoM("ForceUoM")]
        [PPMProperty("FY", "IAnalysisPointLoad")]
        string FY
        {
            get;
            set;
        }

        double? FYSiValue
        {
            get;
        }

        [UoM("ForceUoM")]
        [PPMProperty("FZ", "IAnalysisPointLoad")]
        string FZ
        {
            get;
            set;
        }

        double? FZSiValue
        {
            get;
        }

        [UoM("MomentOutputUoM", "MomentInputUoM")]
        [PPMProperty("MX", "IAnalysisPointLoad")]
        string MX
        {
            get; set;
        }

        double? MXSiValue
        {
            get;
        }

        [UoM("MomentOutputUoM", "MomentInputUoM")]
        [PPMProperty("MY", "IAnalysisPointLoad")]
        string MY
        {
            get; set;
        }

        double? MYSiValue
        {
            get;
        }

        [UoM("MomentOutputUoM", "MomentInputUoM")]
        [PPMProperty("MZ", "IAnalysisPointLoad")]
        string MZ
        {
            get; set;
        }

        double? MZSiValue
        {
            get;
        }
    }
}
