using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Outputs
{
    public class AnalysisDNVThicknessOutput : AnalysisNodeAuxiliaryOutput, IAnalysisDNVThicknessOutput, IAnalysisDNVCommonOutput
    {
        public AnalysisDNVThicknessOutput(AnalysisNode node = null, AnalysisLoadCase loadCase = null) : base(node, loadCase)
        {
        }
        public AnalysisDNVThicknessOutput()
        {

        }
        [NotMapped]
        public string InputWallThickness { get; set; }
        public double? InputWallThicknessSiValue { get; private set; }
        [NotMapped]
        public string BurstOperationTmin { get; set; }
        public double? BurstOperationTminSiValue { get; private set; }
        [NotMapped]
        public string BurstSystemTestTmin { get; set; }
        public double? BurstSystemTestTminSiValue { get; private set; }
        [NotMapped]
        public string CollapseTmin { get; set; }
        public double? CollapseTminSiValue { get; private set; }
        [NotMapped]
        public string PropagationBucklingTmin { get; set; }
        public double? PropagationBucklingTminSiValue { get; private set; }
        [NotMapped]
        public string LCC_aTmin { get; set; }
        public double? LCC_aTminSiValue { get; private set; }
        [NotMapped]
        public string LCC_bTmin { get; set; }
        public double? LCC_bTminSiValue { get; private set; }
        [NotMapped]
        public string DCC_aTmin { get; set; }
        public double? DCC_aTminSiValue { get; private set; }
        [NotMapped]
        public string DCC_bTmin { get; set; }
        public double? DCC_bTminSiValue { get; private set; }

    }
}