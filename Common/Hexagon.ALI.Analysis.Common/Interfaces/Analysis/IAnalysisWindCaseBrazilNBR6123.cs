using Hexagon.ALI.Analysis.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisWindCaseBrazilNBR6123
    {
        [UoM("ElevationUoM")]
        string BasicWindVelocity { get; set; }
        double? BasicWindVelocitySiValue { get; }
        [UoM("ElevationUoM")]
        string TotalWindHeight { get; set; }
        double? TotalWindHeightSiValue { get; }
    }
}
