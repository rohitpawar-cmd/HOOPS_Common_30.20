using Hexagon.ALI.Analysis.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisWindCaseMexico_1993
    {
        [UoM("ElevationUoM")]
        string TotalWindHeight { get; set; }
        double? TotalWindHeightSiValue { get; }
        [UoM("ElevationUoM")]
        string DesignWindSpeed { get; set; }
        double? DesignWindSpeedSiValue { get; }
        [UoM("TemperatureUoM")]
        string AmbientTemprature { get; set; }
        double? AmbientTempratureSiValue { get; }
    }
}
