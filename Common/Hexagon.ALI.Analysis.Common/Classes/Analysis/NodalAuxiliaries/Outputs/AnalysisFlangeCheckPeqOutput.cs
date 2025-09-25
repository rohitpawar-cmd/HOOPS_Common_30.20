using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.DTOs.Enums;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Outputs
{
    public class AnalysisFlangeCheckPeqOutput : AnalysisNodeAuxiliaryOutput, IAnalysisFlangeOutput, IAnalysisFlangeCheckPeqOutput
    {
        public AnalysisFlangeCheckPeqOutput(AnalysisNode node = null, AnalysisLoadCase loadCase = null) : base(node, loadCase)
        {
        }
        public AnalysisFlangeCheckPeqOutput()
        {

        }
        public double Ratio { get; set; }
        [NotMapped]
        public string AllowablePreassure { get; set; }

        public double? AllowablePreassureSiValue { get; private set; }
        [NotMapped]
        public string G_C { get; set; }

        public double? G_CSiValue { get; private set; }
        [NotMapped]
        public string Bending { get; set; }

        public double? BendingSiValue { get; private set; }
        [NotMapped]
        public string Axial { get; set; }

        public double? AxialSiValue { get; private set; }
        [NotMapped]
        public string PEquivalent { get; set; }

        public double? PEquivalentSiValue { get; private set; }
        [NotMapped]
        public string Rating { get; set; }

        public double? RatingSiValue { get; private set; }

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
