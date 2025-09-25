using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.DTOs.Enums;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Outputs
{
    public class AnalysisFlangeCheckNCOutput : AnalysisNodeAuxiliaryOutput, IAnalysisFlangeCheckNCOutput
    {
        public AnalysisFlangeCheckNCOutput(AnalysisNode node = null, AnalysisLoadCase loadCase = null) : base(node, loadCase)
        {
        }
        public AnalysisFlangeCheckNCOutput()
        {

        }
        public double Ratio { get; set; }
        [NotMapped]
        public string C { get; set; }

        public double? CSiValue { get; private set; }
        [NotMapped]
        public string BendingMoment { get; set; }

        public double? BendingMomentSiValue { get; private set; }
        [NotMapped]
        public string TorsionMoment { get; set; }

        public double? TorsionMomentSiValue { get; private set; }
        [NotMapped]
        public string FactoredMoment { get; set; }

        public double? FactoredMomentSiValue { get; private set; }
        [NotMapped]
        public string AB { get; set; }

        public double? ABSiValue { get; private set; }
        [NotMapped]
        public string YieldStrength { get; set; }

        public double? YieldStrengthSiValue { get; private set; }

        [NotMapped]
        public ReportPassFailStatus? PassFailStatus
        {
            get
            {
                if (Ratio < 100)
                {
                    return ReportPassFailStatus.Pass;
                }
                if (Ratio >= 100)
                {
                    return ReportPassFailStatus.Fail;
                }
                return null;
            }
        }
    }
}
