using Hexagon.ALI.Analysis.Common.Classes.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs
{
    [DefUID("AnalysisFlangeCheckYieldStrength")]
    public class AnalysisFlangeCheckYieldStrength : AnalysisFlangeCheckVector, IAnalysisFlangeCheckYieldStrength
    {
        public AnalysisFlangeCheckYieldStrength()
        {
        }

        [NotMapped]
        public string YieldStrength
        {
            get;
            set;
        }

        public double? YieldStrengthSiValue
        {
            get;
            private set;
        }
        [RelDef()] public AnalysisFlangeCheckNC AnalysisFlangeCheckNC { get; set; }
        public string AnalysisFlangeCheckNCId { get; set; }

        [NotMapped]
        public new string EvaluationMethod => AnalysisFlangeCheckNC?.EvaluationMethod ?? "";
    }
}
