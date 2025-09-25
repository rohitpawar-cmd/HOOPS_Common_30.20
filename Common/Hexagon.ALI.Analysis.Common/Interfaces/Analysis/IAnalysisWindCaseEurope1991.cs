using Hexagon.ALI.Analysis.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisWindCaseEurope1991
    {
        [UoM("ElevationUoM")]
        string ReferenceWindVelocity { get; set; }
        double? ReferenceWindVelocitySiValue { get; }
    }
}
