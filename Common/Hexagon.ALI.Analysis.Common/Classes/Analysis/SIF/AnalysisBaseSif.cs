using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.SIF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.SIF
{
    public abstract class AnalysisBaseSif : AnalysisBaseObject
    {
        public SIFType? SIFType { get; set; }
        public double? WeldStrFactWc { get; set; }
        public AnalysisNode IntersectionNode { get; set; }
    }
}
