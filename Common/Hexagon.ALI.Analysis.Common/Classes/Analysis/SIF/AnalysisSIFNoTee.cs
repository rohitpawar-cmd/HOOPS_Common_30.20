using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.SIF;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.SIF
{
    public class AnalysisSIFNoTee : AnalysisBaseSif, IAnalysisSIFNoTee
    {
        public double? PressureStressMultiplier { get; set; }
    }
}
