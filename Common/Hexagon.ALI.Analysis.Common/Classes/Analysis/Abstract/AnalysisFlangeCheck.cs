using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract
{
    [DefUID("AnalysisFlangeCheck")]
    public abstract class AnalysisFlangeCheck : AnalysisBaseObject, IAnalysisFlangeCheck
    {
        public AnalysisFlangeCheck()
        {
        }
        public AnalysisLineElement AnalysisLineElement { get; set; }
        public string AnalysisLineElementId { get; set; }
        public AnalysisNode FromNode { get; set; }
        public string FromNodeId { get; set; }
        public AnalysisNode ToNode { get; set; }
        public string ToNodeId { get; set; }
        [NotMapped]
        public string EvaluationMethod { get; internal set; }
        [NotMapped]
        public string FlangeLocation => !string.IsNullOrEmpty(FromNodeId) && !string.IsNullOrEmpty(ToNodeId) ? "Both" : !string.IsNullOrEmpty(FromNodeId) ? "From" : !string.IsNullOrEmpty(ToNodeId) ? "To" : "";
        [NotMapped]
        public IEnumerable<AnalysisFlangeCheckVector> FlangeVectors { get; internal set; }
    }

    public abstract class AnalysisFlangeCheckVector : AnalysisBaseObject
    {
        public int VectorNumber { get; set; }

        [NotMapped]
        public string EvaluationMethod { get; internal set; }

    }
}       

