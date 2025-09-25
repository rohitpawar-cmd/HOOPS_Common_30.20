using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.ComponentModel;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Reports
{
    public enum MdmtStatus
    {
        [Description("Unknown")]
        Unkown = -1,
        [Description("OK")]
        OK,
        [Description("Impact")]
        Impact  
    }

    public interface IAnalysisReportOutputMDMT
    {        
        [UoM("ThicknessUoM")]
        [PPMProperty(nameof(PipeThickness), nameof(IAnalysisReportOutputMDMT))]
        string PipeThickness { get; set; }
        double? PipeThicknessSiValue { get; }

        [PPMProperty(nameof(MaterialID), nameof(IAnalysisReportOutputMDMT))]
        int? MaterialID { get; set; }

        [PPMProperty(nameof(Curve), nameof(IAnalysisReportOutputMDMT))]
        string Curve {  get; set; }

        [PPMProperty(nameof(PipingCode), nameof(IAnalysisReportOutputMDMT))]
        PipingCode? PipingCode { get; set; }

        [UoM("TemperatureUoM")]
        [PPMProperty(nameof(MinimumTemperature), nameof(IAnalysisReportOutputMDMT))]
        string MinimumTemperature { get; set; }
        double? MinimumTemperatureSiValue { get; }

        [UoM("TemperatureUoM")]
        [PPMProperty(nameof(BaseMDMT), nameof(IAnalysisReportOutputMDMT))]
        string BaseMDMT { get; set; }
        double? BaseMDMTSiValue { get; }

        [PPMProperty(nameof(StressRatio), nameof(IAnalysisReportOutputMDMT))]
        double? StressRatio { get; set; }

        [UoM("TemperatureUoM")]
        [PPMProperty(nameof(Reduction), nameof(IAnalysisReportOutputMDMT))]
        string Reduction { get; set; }
        double? ReductionSiValue { get; }

        [UoM("TemperatureUoM")]
        [PPMProperty(nameof(FinalMDMT), nameof(IAnalysisReportOutputMDMT))]
        string FinalMDMT { get; set; }
        double? FinalMDMTSiValue { get; }

        [PPMProperty(nameof(Status), nameof(IAnalysisReportOutputMDMT))]
        int? Status { get; set; }

        MdmtStatus? UserStatus { get; }

    }
}
