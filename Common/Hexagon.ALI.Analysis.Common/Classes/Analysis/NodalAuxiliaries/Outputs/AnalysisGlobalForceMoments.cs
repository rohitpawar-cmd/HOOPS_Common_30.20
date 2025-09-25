using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Outputs
{
    [DefUID("AnalysisGlobalForceMoments")]
    public class AnalysisGlobalForceMoments : AnalysisForceMomentOutput, IAnalysisGlobalForceMoments
    {
        public AnalysisGlobalForceMoments(AnalysisNode node = null, AnalysisLoadCase loadCase = null) : base(node, loadCase)
        {
        }
        public AnalysisGlobalForceMoments()
        {

        }
        [NotMapped]
        public string Axial
        {
            get;
            set;
        }

        public double? AxialSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string Shear
        {
            get;
            set;
        }

        public double? ShearSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string Bending
        {
            get;
            set;
        }

        public double? BendingSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string Torsion
        {
            get;
            set;
        }

        public double? TorsionSiValue
        {
            get;
            private set;
        }
    }
}
