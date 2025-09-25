using Hexagon.ALI.Analysis.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisWindCaseUBC
    {
        [UoM("ElevationUoM")]
        string DesignWindSpeed { get; set; }
        double? DesignWindSpeedSiValue { get; }
    }
}
