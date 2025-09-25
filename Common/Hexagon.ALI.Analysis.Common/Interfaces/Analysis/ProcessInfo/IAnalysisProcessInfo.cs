using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces.ProcessInfo
{
    public interface IAnalysisProcessInfo
    {
        List<AnalysisLineElement> AnalysisLineElements { get; set; }        

        [UoM("TemperatureUoM")]
        [PPMProperty(nameof(AnalysisTemp), nameof(IAnalysisProcessInfo))]
        string AnalysisTemp { get; set; }

        double? AnalysisTempSiValue { get; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(AnalysisPressure), nameof(IAnalysisProcessInfo))]
        string AnalysisPressure { get; set; }

        double? AnalysisPressureSiValue { get; }

        [UoM("FluidDensityUoM")]
        [PPMProperty(nameof(AnalysisFluidDensity), nameof(IAnalysisProcessInfo))]
        string AnalysisFluidDensity { get; set; }

        double? AnalysisFluidDensitySiValue { get; }

        [UoM("SlopeUoM")]
        [PPMProperty(nameof(AlphaDeltaT), nameof(IAnalysisProcessInfo))]
        string AlphaDeltaT { get; set; }
        double? AlphaDeltaTSiValue { get; }
    }
}
