using Hexagon.ALI.Analysis.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisWindCaseChinaGB50009
    {
        [UoM("PressureUoM")]
        string WindPressure { get; set; }
        double? WindPressureSiValue { get; }
        [UoM("ElevationUoM")]
        string TotalWindHeight { get; set; }
        double? TotalWindHeightSiValue { get; }
    }
}
