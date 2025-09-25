using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Outputs
{
    public class AnalysisDNVDetailsOutput : AnalysisNodeAuxiliaryOutput, IAnalysisDNVDetailsOutput
    {
        public AnalysisDNVDetailsOutput(AnalysisNode node = null, AnalysisLoadCase loadCase = null) : base(node, loadCase)
        {
        }
        public AnalysisDNVDetailsOutput()
        {

        }
        [NotMapped]
        public string Depth { get; set; }
        public double? DepthSiValue { get; private set; }
        [NotMapped]
        public string P_ext { get; set; }
        public double? P_extSiValue { get; private set; }
        [NotMapped]
        public string P_int_1 { get; set; }
        public double? P_int_1SiValue { get; private set; }
        [NotMapped]
        public string P_int_2 { get; set; }
        public double? P_int_2SiValue { get; private set; }
        [NotMapped]
        public string FunctionalAxialForce { get; set; }
        public double? FunctionalAxialForceSiValue { get; private set; }
        [NotMapped]
        public string EnvironmentalAxialForce { get; set; }
        public double? EnvironmentalAxialForceSiValue { get; private set; }
        [NotMapped]
        public string FunctionalMoment { get; set; }
        public double? FunctionalMomentSiValue { get; private set; }
        [NotMapped]
        public string EnvironmentalMoment { get; set; }
        public double? EnvironmentalMomentSiValue { get; private set; }
        public string FunctionalStrain { get; set; }
        public string EnvironmentalStrain { get; set; }
    }
}
