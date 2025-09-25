using Hexagon.ALI.Analysis.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisWindCaseIS875_1998
    {
        [UoM("ElevationUoM")]
        string BasicWindSpeed { get; set; }
        double? BasicWindSpeedSiValue { get; }
    }
}
