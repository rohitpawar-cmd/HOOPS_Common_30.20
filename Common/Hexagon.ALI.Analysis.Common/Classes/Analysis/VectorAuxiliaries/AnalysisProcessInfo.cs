using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using Hexagon.ALI.Analysis.Common.Interfaces.ProcessInfo;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries
{
    [DefUID("AnalysisProcessInfo")]
    public class AnalysisProcessInfo : AnalysisVectorAuxiliary, IAnalysisProcessInfo, IAnalysisRunAuxiliary
    {
        public AnalysisProcessInfo()
        {
        }
        [NotMapped]
        public string AnalysisTemp { get; set; }
        public double? AnalysisTempSiValue { get; private set; }
        [NotMapped]
        public string AnalysisPressure { get; set; }
        public double? AnalysisPressureSiValue { get; private set; }
        [NotMapped]
        public string AnalysisFluidDensity { get; set; }
        public double? AnalysisFluidDensitySiValue { get; private set; }
        [NotMapped]
        public string AlphaDeltaT { get; set; }
        public double? AlphaDeltaTSiValue { get; private set; }


        [RelDef()] public List<AnalysisLineElement> AnalysisLineElements { get; set; }
        public List<AnalysisPrimitive> AnalysisPrimitives { get; set; }

        public override string ToString()
        {
            return AnalysisPrimitive?.Name == null ? base.ToString() : AnalysisPrimitive?.Name;
        }
    }
}