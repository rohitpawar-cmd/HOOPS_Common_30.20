using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Outputs
{
    public class AnalysisDNVComponentsOutput : AnalysisNodeAuxiliaryOutput, IAnalysisDNVComponentsOutput, IAnalysisDNVCommonOutput
    {
        public AnalysisDNVComponentsOutput(AnalysisNode node = null, AnalysisLoadCase loadCase = null) : base(node, loadCase)
        {
        }
        public AnalysisDNVComponentsOutput()
        {

        }
        [NotMapped]
        public string InputWallThickness { get; set; }
        public double? InputWallThicknessSiValue { get; private set; }
        [NotMapped]
        public string T_min_1 { get; set; }
        public double? T_min_1SiValue { get; private set; }
        public string Utility_1 { get; set; }
        [NotMapped]
        public string T_min_2 { get; set; }
        public double? T_min_2SiValue { get; private set; }
        public string Utility_2 { get; set; }
        [NotMapped]
        public string T_min_3 { get; set; }
        public double? T_min_3SiValue { get; private set; }
        public string Utility_3 { get; set; }
        [NotMapped]
        public string T_min_4 { get; set; }
        public double? T_min_4SiValue { get; private set; }
        public string Utility_4 { get; set; }
        public string Warning { get; set; }
    }
}
