using Hexagon.ALI.Analysis.Common.Classes.Analysis.LineElements;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.LineElements;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis
{
    [DefUID("AnalysisExpansionJoint")]
    public class AnalysisExpansionJoint : AnalysisPipe, IAnalysisExpansionJoint
    {
        public AnalysisExpansionJoint()
        {
        }

        [NotMapped]
        public string AxialStiffness { get; set; }

        [NotMapped]
        public string TransverseStiffness { get; set; }

        [NotMapped]
        public string BendingStiffness { get; set; }

        [NotMapped]
        public string TorsionalStiffness { get; set; }
        [NotMapped]
        public string EffectiveId { get; set; }

        public double? AxialStiffnessSiValue { get; private set; }

        public double? TransverseStiffnessSiValue { get; private set; }

        public double? BendingStiffnessSiValue { get; private set; }

        public double? TorsionalStiffnessSiValue { get; private set; }
        public double? EffectiveIdSiValue { get; private set; }


        public override string ToString()
        {
            return string.IsNullOrEmpty(Name) ? base.ToString().Replace("Element", "Expansion Joint") : Name;
        }
    }
}
